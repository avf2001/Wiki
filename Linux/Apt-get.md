* Поиск пакета в удаленном репозитории
```shell
$ sudo nano /etc/apt/sources.list
```
Заменить `http://security.ubuntu.com/ubuntu` на `http://some.proxy.ru:8081/repository/ubuntu-security-proxy` (например, для Nexus)
# Поиск пакета в удаленном репозитории
```bash
$ apt seacrh <package-name>
```
