# Content
* Users
  * [List all users]()
  * [Create new user]()
  * [Change password for another user]()
* Groups  
  * [List all groups]()
  * [Create new group]()
* Users and Gropus
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
# Gropus
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
