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
```shell
cat /proc/meminfo
```

## Процессы
```shell
ps aux
```
```shell
strace -p <PID>
```

## Сеть
Получить список процессов, которые слушают сетевые порты
```shell
netstat -tulpn
```
Тот же результат
```shell
ss -lntu
```
Отобразить список сетевых интерфейсов
```shell
ip a
```
То же самое (устаревший вариант)
```shell
ifconfig
```
