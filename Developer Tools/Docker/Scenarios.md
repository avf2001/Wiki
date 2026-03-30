# Просмотр пользователя, от имени которого работает контейнер
Вариант 1
```shell
$ docker exec my_container whoami
www-data
```
Вариант 2
```shell
$ docker exec my_container id
uid=33(www-data) gid=33(www-data) groups=33(www-data)
```
Вариант 3
```shell
$ docker top my_container
UID        PID    PPID   C   STIME   TTY   TIME       CMD
www-data   12345  12344  0   10:30   ?     00:00:01   nginx
```
Вариант 4
```shell
$ docker inspect -f '{{.State.Pid}}' <container_name> | xargs ps -o user,pid,cmd -p
```
Вариант 5
```shell
$ docker inspect <container_name> | grep -i user
```
Вариант 6
```shell
$ docker inspect -f '{{.Config.User}}' <container_name>
```

# Просмотр пользователя, от имени которого работает docker
```shell
# Check Docker socket ownership (who can run docker commands)
ls -la /var/run/docker.sock

# View process owner of Docker daemon
ps aux | grep dockerd
```
