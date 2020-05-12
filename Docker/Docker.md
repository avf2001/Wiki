Получить информацию по docker
```shell
docker version
```
Посмотреть конфигурацию docker
```shell
docker info
```
Проверка работы с docker hub
```shell
docker run --rm hello-world
// или
docker container run --rm hello-world
```
# Контейнеры
Создание контейнера
```shell
docker container create <options> <image name:tag>
```
Получение информации о контейнерах
```shell
docker ps <options>
docler container ls <options>

docker ps # информация только по запущенным контейнерам
```
Полученине информации о контейнере
```shell
docker container stats
```
