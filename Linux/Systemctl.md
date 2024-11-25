* [Systemctl](#systemctl)
* [Journalctl](#journalctl)
  * [Занимаемое дисковое пространство](#занимаемое-дисковое-пространство)
  * [Очистка](#очистка)
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

* -b - логи загрузки
* --list-boots - ??????????

## Просмотр лога
```
$ journalctl -u SERVICE_NAME                                                               # фильтр по имени сервиса
$ journalctl -u SERVICE_NAME -n 10                                                         # показать последние 10 записей
$ journalctl -u SERVICE_NAME -f                                                            # просмотр лога в реальном режиме времени
$ journalctl -u SERVICE_NAME -r                                                            # отображение лога в обратном порядке
$ journalctl -u SERVICE_NAME -o short-full                                                 # формат вывода (short, verbose, json, json-pretty, cat)
$ journalctl -u sshd.service --since "2023-10-01 00:00:00" --until "2023-10-02 00:00:00"   # указание временного диапазона
```

## Занимаемое дисковое пространство
sudo journalctl --disk-usage

## Очистка
```
$ sudo journalctl --vacuum-size=2G     # удалить логи более 2 Гб
$ sudo journalctl --vacuum-time=1years # удалить логи старше одного года
```
