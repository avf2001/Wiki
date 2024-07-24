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
  * [Получение информации о контейнерах](#получение-информации-о-контейнерах)
  * Подключение к работающему контейнеру
  * [Остановка контейнера](#остановка-контейнера)
  * [Перезапуск контейнера](#перезапуск-контейнера)
  * [Подключение к командной строке запущенного контейнера](#подключение-к-командной-строке-запущенного-контейнера)
* [Образы](#образы)
  * [Получение списка образов](#получение-списка-образов)
  * [Удаление образа](#удаление-образа)
    * [Удаление всех образов (только для Powershell)](#удаление-всех-образов-только-для-powershell) 
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
# статистика использования системных ресурсов
> docker system df

# удаление неиспользуемых ресурсов (контейнеров, сетей, образов и т.д.)
> docker system prune

# очистка логов контейнеров в папке /var/lib/docker/containers
> sudo sh -c "truncate -s 0 /var/lib/docker/containers/*/*-json.log"
```
## Запуск docker без sudo
```
$ sudo usermod -aG docker <username>
$ sudo usermod -aG docker $USER # текущий пользователь
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
## Получение информации о контейнерах
```shell
$ docler container ls <options>

$ docker ps <options>
$ docker ps # информация только по запущенным контейнерам
$ docker ps --format "table {{.ID}}\t{{.Names}}\t{{.Status}}" # отображает определенные столбцы

$ docker stats

# Сортировка по использованию памяти по убыванию
$ docker stats --no-stream --format "table {{.Name}}\t{{.Container}}\t{{.CPUPerc}}\t{{.MemUsage}}" | sort -k 4 -hr
```
## Подключение к работающему контейнеру
```shell
docker attach <CONTAINER_ID | CONTAINER_NAME>
```
## Остановка контейнера
```shell
$ sudo docker rm -f <CONTAINER_ID | CONTAINER_NAME> # остановка и удаление контейнера
```
## Перезапуск контейнера
```shell
$ docker restart <CONTAINER_ID | CONTAINER_NAME>
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
> docker rmi $(docker ps -a -q)
```
