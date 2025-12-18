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
Информация о сетевых маршрутах
```shell
netstat -rn
```
То же самое
```shell
ip r
```
```shell
ping 8.8.8.8       # проверка доступости удаленного сервера
ping google.com    # проверка работы DNS
```
```shell
traceroute 8.8.8.8
```
```shell
mtr
```
```shell
dig google.com             # Запросить информацию у локального DNS сервера
dig @8.8.8.8 google.com    # Запросить информацию у определенного DNS сервера
```
```shell
nslookup
```
```shell
curl -Lv <URL>
curl -v telnet://127.0.0.1:22                                # Проверка доступности порта
curl --unix-socket /var/run/docker.sock http:/images/json    # Обращение к UNIX сокету
```
```shell
tcpdump -i any port 9100 -nn
```

## Логи
```shell
tail -f -n50 /var/log/syslog
```
```shell
tail -lah /var/log/auth.log
```
