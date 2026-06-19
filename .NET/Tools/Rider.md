# Установка и настройка JetBrains Rider
## Linux
1. Создать папку
```
sudo mkdir -p /opt/jetbrains/rider-2026.1.1
```

3. Распаковать содержимое архива в папку
sudo tar -xzf ./JetBrains.Rider-2026.1.1.tar.gz -C /opt/jetbrains/rider-2026.1.1/ --strip-components=1

4. Создать ссылку
sudo ln -s /opt/jetbrains/rider-2026.1.1 /opt/jetbrains/rider

3. Отредактировать переменную PATH
```
code ~/.bashrc

```
```
# JetBrains Rider
export JETBRAINS_RIDER_ROOT=/opt/jetbrains/rider
export PATH=$PATH:$JETBRAINS_RIDER_ROOT/bin
```
```
source ~/.bashrc
```

4. 
```
sudo mkdir -p /opt/jetbrains/rider-crack/2026.1.1
```

5. Распаковать взломщик
```
sudo unrar e -pwww.downloadly.ir ./JetBrains_enc-sniarbtej-2026.01.01.rar /opt/jetbrains/rider-crack/2026.1.1
```

6. Запустить 
```
sudo nano /opt/jetbrains/rider/bin/rider64.vmoptions
```

7.
```
-javaagent:/opt/jetbrains/rider-crack/2026.1.1/sniarbtej.jar=id=sniarbtej,user=Downloadly.ir,exp=2048-10-24,force=true
```

### Добавление иконки в меню

1. Создать файл
```shell
touch /usr/share/applications/rider2026.1.1.desktop
```

2. Отредактировать файл
```
[Desktop Entry]
Version=1.0
Type=Application
Name=JetBrains Rider 2026.1.1
Exec=/opt/jetbrains/rider/bin/rider
Icon=/opt/jetbrains/rider/bin/rider.png
Terminal=false
Categories=Development;IDE;
```
