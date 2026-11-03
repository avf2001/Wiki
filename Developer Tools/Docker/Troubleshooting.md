# Очистка ресурсов дискового пространства
Просмотреть ресурсы, используемые Docker'ом:
```shell
docker system df              # Просмотр используемых ресурсов
docker system prune -a -f     # Очистка неиспользуемых ресурсов
```

## Большой объем в папке /var/lib/docker/containers
```shell
sudo sh -c "truncate -s 0 /var/lib/docker/containers/*/*-json.log"
```

## Просмотр причин unhealthy
```shell
docker inspect --format='{{json .State.Health}}' <имя_или_id_контейнера_grafana> | jq
```
