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
```bash
sudo dnf install nginx-prometheus-exporter
```
```
sudo systemctl status nginx-prometheus-exporter
sudo systemctl start nginx-prometheus-exporter
```
