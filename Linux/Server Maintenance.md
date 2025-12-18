# Обслуживание сервера
Настроить мониторинг (Zabbix, Nagios, Prometheus)

## Проверка места на дисках
```shell
df -h
```
Посмотреть по inode
```shell
df -i
```
Посмотреть размер, занимаемый папкой (включая все вложенные файлы и папки)
```shell
du -sh /tmp
```
Проверка состояния жесткого диска. Список дисков можно получить командой `lsblk`.
```shell
smartctl -a /dev/sda
```
Просмотр состояния RAID массива
```shell
cat /proc/mdstat
```
## Процессор и память
```shell
iostat
```
```shell
iotop
```
```shell
top
```
```shell
htop
```
```shell
vmstat
```
```shell
free -m
```
