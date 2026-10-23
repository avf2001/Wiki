* [Диск](#диск)
* [Процессы](#процессы)
* [Сеть](#сеть)
* [bpytop](#bpytop)
* [Терминалы](#терминалы)
* [Менеджеры паролей](#менеджеры-паролей)
* [Git клиенты](#git-клиенты)
  * [SourceGit](#sourcegit)
* [sysbench](#sysbench)
* [File Managers](#file-managers)  
* [Офис](#офис)
  * [Распознавание документов](#распознавание-документов)
  * [PDF](#pdf)
* [Процессор](#процессор)
* [Процессы](#процессы)
* [Screen](screen)
* [Web](#web)



# Диск
- [baobab](#baobab)
- [iotop](#iotop)
- [ncdu](#ncdu)

## baobab
Графическое приложение для GNOME, которое сканирует указанные каталоги или файловые системы и представляет размеры и процентное соотношение занятого пространства в виде диаграммы-дерева.

### Установка
```bash
sudo apt install -y baobab    # Ubuntu
sudo dnf install -y baobab    # RedOS
```

## iotop
Утилита, которая в реальном времени показывает, какие процессы или потоки в Linux создают нагрузку на дисковый ввод-вывод, в формате, аналогичном top.

### Установка
```bash
rpm-ostree install iotop    # Fedora (Bluefin)
sudo dnf install iotop      # RedOS
sudo apt install iotop      # Ubuntu
```

### Запуск
```bash
sudo iotop
```

## ncdu
Интерактивная консольная программа для быстрого анализа использования дискового пространства, позволяющая в удобном интерфейсе просматривать и сортировать каталоги по их размеру.





# Процессы
- [atop](#atop)
- [bpytop](#bpytop)
- [htop](#htop)

## atop
Полноэкранный монитор производительности, который в реальном времени отслеживает загрузку ЦП, памяти, дисков и сети, показывая активность только тех процессов, чьё состояние изменилось с момента предыдущего замера.

### Установка
```bash
rpm-ostree install atop     # Fedora (Bluefin)
```

## bpytop
Ресурсный монитор, который в реальном времени отображает использование процессора, памяти, дисков, сети и статистику процессов в удобном интерфейсе с поддержкой мыши .

### Установка (Ubuntu)
```shell
sudo snap install bpytop     # Fedora (Bluefin)
```

### Предварительная настройка
```shell
$ sudo snap connect bpytop:mount-observe
$ sudo snap connect bpytop:network-control
$ sudo snap connect bpytop:hardware-observe
$ sudo snap connect bpytop:system-observe
$ sudo snap connect bpytop:process-control
$ sudo snap connect bpytop:physical-memory-observe
```

### Запуск
```shell
$ bpytop
```

## htop
Интерактивный просмотрщик процессов на основе ncurses, похожий на top, но позволяющий прокручивать список по вертикали и горизонтали, а также выполнять управление процессами (например, завершение или изменение приоритета) без ручного ввода их PID.





# Сеть
- [iftop](#iftop)
- [nethogs](#nethogs)

## iftop
консольный инструмент, который в реальном времени отображает таблицу использования пропускной способности сети между парами хостов на заданном интерфейсе.

### Установка
```bash
rpm-ostree install iftop     # Fedora (Bluefin)
```

## nethogs
Консольный аналог `top`, который показывает сетевой трафик в реальном времени с группировкой по процессам (PID).

### Установка
```bash
sudo apt install -y nethogs
```










# Терминалы
* [Warp](https://www.warp.dev/)

# Менеджеры паролей
* [KeePassXC](#keepassxc)

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
* [Double Commander](#double-commander)
* [Krusader](#krusader)
* [GNOME Commander](#gnome-commander)
* [Dolphin](#dolphin)
* [Nemo](#nemo)
* [Fman](#fman)

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



# Офис
* [Распознавание документов](#распознавание%20документов)
* [PDF](#pdf)

## Распознавание документов
* [Tesseract OCR](#tesseract-ocr)

### Tesseract OCR

#### Installation
```bash
$ sudo apt install -y tesseract-ocr     # Debian/Ubuntu
$ sudo apt install -y tesseract-ocr-rus # Plugin for Russian
$ sudo apt install -y tesseract-ocr-eng # Plugin for English
$ sudo apt install -y tesseract-ocr-fra # Plugin for French etc.
$ sudo apt install -y gimagereader      # GUI
```

## PDF
* [Okular](#okular)
* [Evince](#evince)
* [qpdfview](#qpdfview)

### Okular

#### Installation
```bash
sudo apt install -y okular
```

### Evince

#### Installation
```bash
sudo apt install -y evince
```

### qpdfview

#### Installation
```bash
sudo apt install -y qpdfview
```

# Процессор

## s-tui
```bash
# Fedora (Bluefin)
rpm-ostree install s-tui
```



















# Screen

## cmatrix
```shell
sudo dnf install cmatrix
```



# Web
## curl
```shell
curl -I http://localhost:8080 # отображает только HTTP заголовки без HTML 
```
