* [systemd-analyze](#systemd-analyze)
* [Systemctl](#systemctl)
  * [Получить список имен всех сервисов]()
  * [Узнать расположение файла конфигурации]()
  * [Удаление сервиса (примере kubelet)]()
* [Journalctl](#journalctl)
  * [Занимаемое дисковое пространство](#занимаемое-дисковое-пространство)
  * [Очистка](#очистка)
  * [Просмотр лога](#просмотр-лога)
* [Resources](#resources)

# systemd-analyze

# Systemctl
## Получить список имен всех сервисов
```shell
$ systemctl list-units --type=service --all --no-legend --no-pager | awk '{print $1}'
```
```
$ systemctl list-units --type=service --state=running
```

## Узнать расположение файла конфигурации
```shell
$ systemctl show --property=FragmentPath sshd.service
FragmentPath=/usr/lib/systemd/system/sshd.service
```

## Удаление сервиса (примере kubelet)
1. Проверить службу в списке
```bash
sudo systemctl list-unit-files --type=service | grep -i kubelet
```
2. Остановить и отключить службу
```bash
sudo systemctl stop kubelet          # Stop the running service
sudo systemctl disable kubelet       # Prevent it from starting at boot
```
3. Проверить папку `/etc/systemd/system` и удалить необходимые файлы/папки
```bash
sudo ls -al /etc/systemd/system/
sudo rm -r /etc/systemd/system/kubelet.service.d/
```
4. Проверить папку `/usr/lib/systemd/system` и удалить необходимые файлы/папки
```bash
sudo ls -al /usr/lib/systemd/system/kube*
sudo rm /usr/lib/systemd/system/kubelet.service
```
5. Опять проверить службу в списке
```bash
sudo systemctl list-unit-files --type=service | grep -i kubelet
```
### Дополнительно для kubelet
```bash
sudo rm /usr/bin/kubelet
sudo rm -rf /var/lib/kubelet    # Removes pod manifests and data
sudo rm -rf /etc/kubernetes     # Removes kubelet configs (if any)
```

# Journalctl
journalctl — это команда в Linux, используемая для запроса и просмотра журналов системы, которые хранятся в журнале systemd. 

* -b - логи загрузки
* --list-boots - ??????????

Расположение файла настройки
```
/etc/systemd/journald.conf
```

После внесения изменений в настройки необходимо выполнить команду:
```
$ sudo systemctl restart systemd-journald
```

Экспорт логов:
```
$ journalctl --output=export > /path/to/outputfile
```

Сброс логов:
```
$ sudo journalctl --flush
$ sudo journalctl --vacuum-time=1s
```

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
```
$ sudo journalctl --disk-usage
```

## Очистка
```
$ sudo journalctl --vacuum-size=2G     # удалить логи более 2 Гб
$ sudo journalctl --vacuum-time=1years # удалить логи старше одного года
```

# Resources
https://systemd.io/
