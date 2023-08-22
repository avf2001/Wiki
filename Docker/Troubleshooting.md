# Очистка ресурсов, используемых Docker
Просмотреть ресурсы, используемые Docker'ом:
```shell
$ docker system df
```
# Большой объем в папке /var/lib/docker/containers
## Решение
Может не всегда работать
```shell
$ docker system prune -a -f
```
