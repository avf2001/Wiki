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

## Занимаемое дисковое пространство
sudo journalctl --disk-usage

## Сжатие до определенного объема
sudo journalctl --vacuum-size=2G

##
$ sudo journalctl --vacuum-time=1years
