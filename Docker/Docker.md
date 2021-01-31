# Содержание
* Общая информация
  * Информация о Docker
* Контейнеры
* Образы
# Общая информация
## Информация о Docker
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
## Использование дискового пространства
```shell
docker system df
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
Полученине информации о контейнерах
```shell
docker container stats
```
Подключение к работающему контейнеру
```shell
docker attach <CONTAINER_ID | CONTAINER_NAME>
```
# Образы
## Получение списка образов
```shell
> docker images
```
## Удаление образа
```shell
> docker rmi <IMAGE_ID>
```
Удаление всех образов (только для Powershell)
```powershell
> docker rm $(docker ps -a -q)
```
