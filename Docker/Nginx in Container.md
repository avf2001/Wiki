# 1. Запустить контейнер Nginx
$ sudo docker run -d --name nginx-base -p 80:80 nginx:latest

# 2. Скопировать из контейнера Nginx файл конфигурации
$ sudo docker cp nginx-base:/etc/nginx/conf.d/default.conf ~/default.conf

# 3. Внести изменения в файл конфигурации

# 4. Скопировать файл конфигурации обратно в Nginx контейнер
$ sudo docker cp ./default.conf nginx-base:/etc/nginx/conf.d/

# 5. Проверить конфигурацию контейнера
$ sudo docker exec nginx-base nginx -t

# 6. Перезапустить контейнер 
$ sudo docker exec nginx-base nginx -s reload

... не завершено ...

Source: https://www.theserverside.com/blog/Coffee-Talk-Java-News-Stories-and-Opinions/Docker-Nginx-reverse-proxy-setup-example
