# Content
* [List all users]()
* [Create new user]()
* [Change password for another user]()
# List all users
```shell
$ awk -F: '{ print $1}' /etc/passwd
```
# Create new user
```shell
$ sudo adduser <username>
```
# Change password for another user
```shell
$ sudo passwd <username> <password>
```
# List groups of specific user
```shell
$ groups <username>
```
