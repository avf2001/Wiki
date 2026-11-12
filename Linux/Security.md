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

```shell
sudo -l -U username # просмотр списка привилегий sudo для пользователя username
userdel -r username # удаление пользователя
```

## Настройка ssh
1. Сгенерировать SSH ключ и скопировать его на сервер
2. Настроить SSH на срвере
```
/etc/ssh/sshd_config

PasswordAuthentication no # Вход только по SSH ключам
PermitRootLogin no # запрещает заходить root
AllowUsers deploy username # задает список разрешенных пользователей

sudo systemctl restart sshd

sudo sshd -t # проверка файла конфигурации
```
Держать сессию по паролю пока не проверили новой сессией.

Желательно сменить порт по умолчанию (22).

## Файрвол
```shell
sudo ss -tulpn # посмотреть открытые порты
```

## Ресурсы
- [Как защитить Linux (youtube)](https://www.youtube.com/watch?v=SF6e_aYOGRE)
