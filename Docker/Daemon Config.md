# COnfig File Location
```
/etc/docker/daemon.json
```
As user root, make or edit the following file: `/etc/docker/daemon.json`
```json
{
    "insecure-registries": ["10.0.2.2:8181"],
    "registry-mirrors": ["http://10.0.2.2:8181"]
}
```
Затем перезапустить docker
```shell
$ service docker restart
```
