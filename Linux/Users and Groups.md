# Содержание
* [Пользователи](#пользователи)
  * [Получение списка пользователей](#получение-списка-пользователей)
  * [Создание пользователя](#создание-пользователя)
    * [Сценарий: Создание пользователя с административными правами (sudo)](#сценарий-создание-пользователя-с-административными-правами-sudo)
  * [Change password for another user]()  
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
awk -F: '{ print $1}' /etc/passwd   # Option 1
sed 's/:.*//' /etc/passwd           # Option 2 
```

## Создание пользователя
```shell
$ sudo adduser <username>
```

### Сценарий: Создание пользователя с административными правами (sudo)
```shell
sudo adduser username              # 1. Создать пользователя
sudo passwd -S username            # 2. Check password status
getent group sudo                  # 3. Проверить что группа sudo существует
sudo usermod -aG sudo username     # 4. Добавить пользователя в группу sudo (или wheel)
id username                        # 5. Просмотреть группы пользователя: - вариант 1
groups username                                                          - вариант 2
```

## Change password for another user
```shell
$ sudo passwd <username> <password>
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
