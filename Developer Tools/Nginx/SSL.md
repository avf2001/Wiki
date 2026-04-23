# Настройка SSL
1. Создать папку, в которой будут храниться SSL сертификаты
```shell
sudo mkdir -p /etc/nginx/ssl
```

2. Сгенерировать SSL сертификат
```shell
sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout /etc/nginx/ssl/selfsigned.key -out /etc/nginx/ssl/selfsigned.crt
```

3. Отредкатировать файл конфигурации nginx

```shell
sudo nano /etc/nginx/nginx.conf
```
```
server {
    listen       80;
    listen       [::]:80;
    server_name  _;
    root         /usr/share/nginx/html;

    ...

    return 301 https://$server_name$request_uri;
}

server {
	listen       443 ssl;
    listen       [::]:443 ssl;
    # http2        on;
    server_name  _;
    root         /usr/share/nginx/html;

    ssl_certificate "/etc/nginx/ssl/selfsigned.crt";
    ssl_certificate_key "/etc/nginx/ssl/selfsigned.key";

    location /some/location {
        ...
    }
}

```

4. Проверить конфигурацию nginx
```shell
sudo nginx -t
```

5. Если все ок, то перезапустить Nnginx
```shell
sudo systemctl reload nginx
```
