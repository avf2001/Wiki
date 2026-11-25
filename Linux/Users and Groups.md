# Содержание
* [Пользователи](#пользователи)
  * [Получение списка пользователей](#получение-списка-пользователей)
  * [Создание пользователя](#создание-пользователя)
  * [Change password for another user]()
  * [Scenario: Create User with Administrative Rights](#scenario-create-user-with-administrative-rights)
  * [Кто залогинен на машине]()
  * [Редактирование /etc/passwd]()
* [Groups](#groups)
  * [List all groups](#list-all-groups)
  * [Create new group]()  
* [Users and Groups](#users-and-groups)
  * [List groups of specific user]()

# Пользователи

## Получение списка пользователей
Полная информация
```shell
cat /etc/passwd   # Option 1
getent passwd     # Option 2
```
Только имена пользователей
```shell
$ awk -F: '{ print $1}' /etc/passwd   # Option 1
$ sed 's/:.*//' /etc/passwd           # Option 2 
```

## Создание пользователя
```shell
$ sudo adduser <username>
```
## Change password for another user
```shell
$ sudo passwd <username> <password>
```

## Сценарий: Создание пользователя с административными правами
```bash
sudo adduser username       # 1. Создать пользователя
sudo passwd -S username     # 2. Check password status
getent group sudo           # 3. Проверить что группа sudo существует
```

5. Add user to sudo (or wheel) group
```bash
$ sudo usermod -aG wheel username
```

6. View user groups
```bash
$ id username
# or
$ groups username
```

## Кто залогинен на машине
```shell
w     # Option 1
who   # Option 2
```

## Редактирование /etc/passwd
```shell
sudo vipw
```

# Groups
## List all groups
```shell
$ less /etc/group
```
## Create new group
```shell
$ sudo groupadd <groupuname>
```
# Users and Groups
## List groups of specific user
```shell
$ groups <username>
```
## Add user to group
```shell
$ sudo usermod -a -G <groupname> <username>
```
