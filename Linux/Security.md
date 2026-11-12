# Настройка безопасности
Порядок настройки безопасности:
1. Конфигурация логирования
2. Настройка автоматических обновлений безопасности
3. Настройка SSH
4. Настройка файрвола
5. fail2ban
6. Мониторинг и алерты
7. Что проверять при взломе

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

Настроить копирование логов с сервера (Grafana Loki, Grafana Alloy)

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
### ufw (Ubuntu)
Порядок имеет большое значение
```shell
sudo ufw default deny incoming  # 1
sudo ufw allow OpenSSH          # 2
sudo ufw allow 443/tcp          # 3
sudo ufw enable                 # 4
```
Правила docker обходят правила ufw. Как исправить: 1. Публиковать порт только на 127.0.0.1 2. sudo iptables -I DOCKER-USER -i eth0 ! -s 192.0.2.10 -j DROP

## fail2ban

## Мониторинг и метрики
Подозрительные метрики:
- CPU 100%
- Высокий входящий/исходящий трафик

Подозрительные логи:
- Вход по SSH
- Создание нового пользователя
- Логи с сервера перестали приходить

## Что проверять при взломе
1. Вход
2. Скачивание в /tmp
3. Запуск
4. crontab
5. authorized_keys

## Ресурсы
- [Как защитить Linux (youtube)](https://www.youtube.com/watch?v=SF6e_aYOGRE)
