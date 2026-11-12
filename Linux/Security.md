# Настройка безопасности

## Логи
```shell
journalctl -u ssh     # Debian, Ubuntu
journalctl -u ssh     # CentOS

journalctl -u ssh --since "24 hours ago" | grep Accepted # успешные входы
journalctl -u ssh -f # просмотр в реальном времени
w # кто подключен сейчас
```
Обратить внимание на `failed password`, `invalid user`, `accepted`.


## Ресурсы
- [Как защитить Linux (youtube)](https://www.youtube.com/watch?v=SF6e_aYOGRE)
