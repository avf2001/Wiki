# Установка Docker Engine (на примере Debian)
```shell
$ sudo dpkg -i /path/to/docker-ce-cli_19.03.9~3-0~debian-buster_amd64.deb
$ sudo dpkg -i /path/to/containerd.io_1.3.7-1_amd64.deb
$ sudo dpkg -i /path/to/docker-ce_19.03.9~3-0~debian-buster_amd64.deb
```
```shell
$ docker pull httpd
$ docker save -o httpd-image.docker httpd
$ docker load -i httpd-image.docker
```
