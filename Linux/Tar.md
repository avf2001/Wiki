# Создание архива tar
```shell
$ tar -czf destination-archive-name.tar.gz source-file-name.ext
```

# Установка приложения из архива (на примере Double Commander)
1. Скачать архив в папку Downloads
2. Распаковать архив
```bash
tar -xJf имя-программы.tar.xz
```
3. Переместить архив в папку /opt
```bash
sudo mv ~/doublecmd /opt/
```
