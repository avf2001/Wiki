# Настройка безопасности

## Логи
```shell
journalctl -u ssh     # Debian, Ubuntu
journalctl -u ssh     # CentOS

journalctl -u ssh --since "24 hours ago" | grep Accepted     # успешные входы
journalctl -u ssh -f                                         # просмотр в реальном времени
w                                                            # кто подключен сейчас
journalctl --list-boots                                      # отображает список загрузок
```
```shell
/etc/systemd/journald.conf
Storage=persistant # сохранение журнала после перезагрузок
SystemMaxUse=500M
```
```shell
journalctl --disk-usage
```

Обратить внимание на `failed password`, `invalid user`, `accepted`.

## Автоматическое обновление безопасности
unattended-upgrades
```shell
sudo apt install unattended-upgrades
```
```shell
ls /var/log/unattended-upgrades/
unattended-upgrades.log
```

## Ресурсы
- [Как защитить Linux (youtube)](https://www.youtube.com/watch?v=SF6e_aYOGRE)
