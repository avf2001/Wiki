Получить список служб
```shell
$ systemctl
```
Получение статуса службы
```shell
$ sudo service transmission-daemon status
```
Запуск службы
```shell
$ sudo service transmission-daemon start
```
Удаление службы
```shell
$ sudo systemctl stop [servicename]
$ sudo systemctl disable [servicename]
$ sudo rm /etc/systemd/system/[servicename]
$ sudo rm /etc/systemd/system/[servicename] # and symlinks that might be related
$ sudo rm /usr/lib/systemd/system/[servicename] 
$ sudo rm /usr/lib/systemd/system/[servicename] # and symlinks that might be related
$ sudo systemctl daemon-reload
$ sudo systemctl reset-failed
```
