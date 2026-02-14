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
4. Создать символическую ссылку
```bash
sudo ln -s /opt/doublecmd/doublecmd /usr/local/bin/doublecmd
```
5. Создать ярлык в меню приложений
```bash
sudo nano ~/.local/share/applications/doublecmd.desktop
```
```ini
[Desktop Entry]
Name=Double Commander
Comment=Double Commander
Exec=/opt/doublecmd/doublecmd
Icon=/opt/doublecmd/doublecmd.png
Terminal=false
Type=Application
Categories=Utility;
```
