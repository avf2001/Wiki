# List all users
```shell
$ awk -F: '{ print $1}' /etc/passwd
```
# Create new user
```shell
$ sudo useradd username
```
