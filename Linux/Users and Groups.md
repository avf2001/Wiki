# Content
* Users
  * [List all users](#list-all-users)
  * [Create new user]()
  * [Change password for another user]()
* [Groups](#groups)
  * [List all groups](#list-all-groups)
  * [Create new group]()
* [Users and Groups](#users-and-groups)
  * [List groups of specific user]()
# Users
## List all users
```shell
$ awk -F: '{ print $1}' /etc/passwd
```
## Create new user
```shell
$ sudo adduser <username>
```
## Change password for another user
```shell
$ sudo passwd <username> <password>
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
