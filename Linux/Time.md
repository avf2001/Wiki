# Настройка сервера дат
- [Проверка статуса сервиса](#проверка-статуса-сервиса)
- [Настройка сервиса](#настройка-сервиса)
  - [Debian](#debian)

## Проверка статуса сервиса
```shell
timedatectl status
timedatectl timesync-status
```

## Настройка сервиса
### Debian

1. Отредактировать файл конфигурации
```shell
sudo nano /etc/systemd/timesyncd.conf
```

2. Настроить адреса серверов
```ini
[Time]
NTP=pool.ntp.org time.google.com
```

3. Применить изменения
```shell
sudo systemctl restart systemd-timesyncd
sudo systemctl enable systemd-timesyncd

timedatectl status
timedatectl timesync-status
```
