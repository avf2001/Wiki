# Конфигурация
Расположение файла конфигурации
```
/etc/nginx/nginx.conf
```
```
$ sudo nginx -t         # проверить конфигурацию
$ sudo nginx -s reload  # проверить конфигурацию и перезагрузить
```
# Сервис
```
# Проверка работы nginx
$ sudo systemctl status nginx

# Запуск nginx
$ sudo systemctl start nginx
```

# nginx prometheus exporter
## Installation (RedOS)
1.
```bash
sudo dnf install nginx-prometheus-exporter
```
2.
```bash
sudo systemctl status nginx-prometheus-exporter
sudo systemctl start nginx-prometheus-exporter
```
3.
```bash
sudo nano /etc/nginx/nginx.conf
```
