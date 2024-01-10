# Резервное копирование и восстановление
* Резервное копирование в контейнере Docker

## Резервное копирование в контейнере Docker
Выполнить команду:
```shell
$ docker exec -it <container_name> gitlab-rake gitlab:backup:create
```
В папке **`/opt/gitlab/data/backups`** появится файл:
```shell
$ sudo ls -l /opt/gitlab/data/backups
total 1200
-rw------- 1 998 docker 1228800 Oct  5 16:43 1696513388_2023_10_05_15.0.0_gitlab_backup.tar
```
Также необходимо создать резервную копию папки **`/opt/gitlab/config`**.
