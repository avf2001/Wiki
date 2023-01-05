# Содержание
* [Общая информация](#общая-информация)
  * [Информация о Docker](#информация-о-docker)
  * [Конфигурация docker](#конфигурация-docker)
  * [Проверка работы с docker hub](#проверка-работы-с-docker-hub)
  * [Использование дискового пространства](#использование-дискового-пространства)
  * [Запуск docker без sudo](#запуск-docker-без-sudo)
  * [Проверка работы службы](#проверка-работы-службы)
* [Контейнеры](#контейнеры)
  * [Создание контейнера](#создание-контейнера)
  * [Остановка контейнера](#остановка-контейнера)
  * [Подключение к командной строке запущенного контейнера](#подключение-к-командной-строке-запущенного-контейнера)
* [Образы](#образы)
  * [Получение списка образов](#получение-списка-образов)
  * [Удаление образа](#удаление-образа)
    * [Удаление всех образов (только для Powershell)]() 
# Общая информация
## Информация о Docker
```shell
docker version
```
## Конфигурация docker
```shell
docker info
```
## Проверка работы с docker hub
```shell
docker run --rm hello-world
// или
docker container run --rm hello-world
```
## Использование дискового пространства
```cmd
> docker system df # статистика использования системных ресурсов
> docker system prune # удаление неиспользуемых ресурсов (контейнеров, сетей, образов и т.д.)
```
## Запуск docker без sudo
```
$ sudo usermod -aG docker <username>
$ logout # необходимо выйти из системы
```
## Проверка работы службы
```shell
$ sudo systemctl status docker
```
# Контейнеры
## Создание контейнера
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
## Остановка контейнера
```shell
$ sudo docker rm -f <CONTAINER_ID | CONTAINER_NAME> # остановка и удаление контейнера
```
## Подключение к командной строке запущенного контейнера
```shell
$ sudo docker exec -it <CONTAINER_ID | CONTAINER_NAME> sh
```
# Образы
## Получение списка образов
```shell
> docker images
```
## Удаление образа
```shell
> docker rmi <IMAGE_ID|IMAGE_NAME>
> docker rmi <IMAGE_ID|IMAGE_NAME> --force # принудительное удаление
```
### Удаление всех образов (только для Powershell)
```powershell
> docker rm $(docker ps -a -q)
```
