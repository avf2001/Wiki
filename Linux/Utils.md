* [bpytop](#bpytop)
* [Terminals](#terminals)
* Менеджеры паролей
* Git клиенты

# bpytop
## Описание
Bpytop is an advanced, terminal-based control center for Linux. With it, users can view and manage their CPU usage, RAM/SWAP usage, network download/upload, and even terminate running programs! https://www.addictivetips.com/ubuntu-linux-tips/manage-linux-system-resources
## Установка (Ubuntu)
```shell
$ sudo apt update
$ sudo apt install snapd
```
```shell
$ sudo snap install bpytop
```
## Предварительная настройка
```shell
$ sudo snap connect bpytop:mount-observe
$ sudo snap connect bpytop:network-control
$ sudo snap connect bpytop:hardware-observe
$ sudo snap connect bpytop:system-observe
$ sudo snap connect bpytop:process-control
$ sudo snap connect bpytop:physical-memory-observe
```
## Запуск
```shell
$ bpytop
```
# Terminals
* [Warp](https://www.warp.dev/)

# Менеджеры паролей

## KeePassXC
```bash
# sudo dnf install keepassxc
```

# Git клиенты

## SourceGit
https://github.com/sourcegit-scm/sourcegit/releases
