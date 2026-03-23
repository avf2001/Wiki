# Очистка ресурсов дискового пространства
Просмотреть ресурсы, используемые Docker'ом:
```shell
docker system df              # Просмотр используемых ресурсов
docker system prune -a -f     # Очистка гнеиспользуемых ресурсов
```
## Большой объем в папке /var/lib/docker/containers
```shell
sudo sh -c "truncate -s 0 /var/lib/docker/containers/*/*-json.log"
```

