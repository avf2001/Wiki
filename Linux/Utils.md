* [bpytop](#bpytop)
* [Terminals](#terminals)
* [Менеджеры паролей](#менеджеры-паролей)
  * [KeePassXC](#keepassxc) 
* [Git клиенты](#git-клиенты)
  * [SourceGit](#sourcegit)
* [sysbench](#sysbench)
* [File Managers](#file-managers)
  * [Double Commander](#double-commander)
  * [Krusader](#krusader)
  * [GNOME Commander](#gnome-commander)
  * [Dolphin](#dolphin)
  * [Nemo](#nemo)
  * [Fman](#fman)
* [Optical Character Recognition (OCR)](#optical-character-recognition-ocr)

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

# sysbench
[RedOS](https://redos.red-soft.ru/base/redos-7_3/7_3-equipment/7_3-test-soft/7_3-sysbench/) [Wikipedia](https://en.wikipedia.org/wiki/Sysbench) [Github](https://github.com/akopytov/sysbench)

Sysbench is a powerful, open-source benchmarking tool designed specifically for Linux systems en.wikipedia.org. Created by Peter Zaitsev in 2004 and currently maintained by Alexy Kopytov en.wikipedia.org, it provides a flexible way to evaluate system performance across various aspects including CPU, memory, file I/O, and database operations.

## Usage
### Testing PostgreSQL performance
```bash
$ sysbench 
--db-driver=pgsql 
--report-interval=2 
--oltp-table-size=100000 
--oltp-tables-count=24 
--threads=64 
--time=60 
--pgsql-host=localhost 
--pgsql-port=5432 
--pgsql-user=sbtest 
--pgsql-password=password 
--pgsql-db=sbtest 
/usr/share/sysbench/tests/include/oltp_legacy/oltp.lua 
run
```
Links:
- [How to Benchmark PostgreSQL Performance Using Sysbench](https://severalnines.com/blog/how-benchmark-postgresql-performance-using-sysbench/)
- [Use sysbench to test the OLTP performance](https://www.alibabacloud.com/help/en/polardb/polardb-for-postgresql/performance-test-method-oltp)

# File Managers

## Double Commander
[Github](https://github.com/doublecmd/doublecmd) [Wikipedia](https://en.wikipedia.org/wiki/Double_Commander) [Site](https://doublecmd.sourceforge.io)

### Installation
```bash
$ sudo apt install -y doublecmd-gtk
```

## Krusader

### Installation
```bash
$ sudo apt install -y krusader  # Debian/Ubuntu
$ sudo dnf install -y krusader  # Fedora
```

## GNOME Commander

### Installation
```bash
$ sudo apt install gnome-commander  # Debian/Ubuntu
$ sudo dnf install gnome-commander  # Fedora
```

## Dolphin

### Installation
```bash
$ sudo apt install dolphin  # Debian/Ubuntu
$ sudo dnf install dolphin  # Fedora
```

## Nemo

### Installation
```bash
$ sudo apt install -y nemo  # Debian/Ubuntu
```

## Fman

### Installation
https://fman.io/download/thank-you?os=Linux&distribution=Ubuntu
```bash
Here's how to install fman on Ubuntu:

Install fman's GPG key:

wget -q -O - https://download.fman.io/rpm/public.gpg | sudo gpg --dearmor -o /usr/share/keyrings/fman-keyring.gpg
Add fman's repository:

echo "deb [signed-by=/usr/share/keyrings/fman-keyring.gpg] https://fman.io/updates/ubuntu/ stable main" | sudo tee /etc/apt/sources.list.d/fman.list
Update apt sources:

sudo apt update
Finally, you can install fman via:

sudo apt install fman
```

# Optical Character Recognition (OCR)
