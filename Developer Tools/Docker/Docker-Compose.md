* Offline installation (Linux)
# Offline installation (Linux)
1. Download `docker-compose-Linux-x86_64` file from https://github.com/docker/compose/releases.
2. Rename `docker-compose-Linux-x86_64` file to `docker-compose`.
```shell
$ mv docker-compose-Linux-x86_64 docker-compose
```
3. Move `docker-compose` file to `/usr/local/bin/` directory
```shell
$ mv docker-compose /usr/local/bin/
```
4. Set permissions to `/usr/local/bin/` directory
```
$ chmod +x /usr/local/bin/docker-compose
```
# Stop Running Containers
```shell
$ docker-compose stop
```
# Remove Containers
```shell
$ docker-compose rm -f
```
# Stop and Remove Containers
Option 1 - preffered
```shell
$ docker-compose down
```
Option 2
```shell
$ docker-compose stop && docker-compose rm -f
```
# Status of Containers
```shell
$ docker-compose ps
```
