* [Поиск пакета в удаленном репозитории](#поиск-пакета-в-удаленном-репозитории)
* [Редактирование файла со списком репозиториев](#редактирование-файла-со-списком-репозиториев)

# Поиск пакета в удаленном репозитории
```bash
$ apt seacrh <package-name>
```

# Редактирование файла со списком репозиториев
**Вариант 1**
```shell
$ sudo nano /etc/apt/sources.list
```
**Вариант 2**
```bash
$ sudo apt edit-sources
```
Заменить `http://security.ubuntu.com/ubuntu` на `http://some.proxy.ru:8081/repository/ubuntu-security-proxy` (например, для Nexus)
