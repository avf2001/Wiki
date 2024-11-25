* [Systemctl](#systemctl)
* [Journalctl](#journalctl)
  * [Занимаемое дисковое пространство](#занимаемое-дисковое-пространство)
  * [Сжатие до определенного объема](#сжатие-до-определенного-объема)
  * [Просмотр лога](#просмотр-лога)

# Systemctl
```
# Получить список имен всех сервисов
$ systemctl list-units --type=service --all --no-legend --no-pager | awk '{print $1}'
```
```
$ systemctl list-units --type=service --state=running
```

# Journalctl
journalctl — это команда в Linux, используемая для запроса и просмотра журналов системы, которые хранятся в журнале systemd. 

* -f - выводить логи в реальном режиме времени
* --since
* --until
* -e <SERVICE_NAME>
* -b - логи загрузки
* --list-boots - ??????????
* -o - формат вывода (short, verbose, json, json-pretty, cat)

## Просмотр лога
```
$ journalctl -u SERVICE_NAME         # фильтр по имени сервиса
$ journalctl -u SERVICE_NAME -n 10   # показать последние 10 записей
```

## Занимаемое дисковое пространство
sudo journalctl --disk-usage

## Сжатие до определенного объема
sudo journalctl --vacuum-size=2G

##
$ sudo journalctl --vacuum-time=1years
