Получить список служб
```shell
$ systemctl
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
