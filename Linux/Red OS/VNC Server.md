https://redos.red-soft.ru/base/server-configuring/remote-control/x11vnc/
```
$ sudo dnf install x11vnc
```
```
$ sudo x11vnc -storepasswd "123qweASD" /etc/vncpasswd
```
```
$ sudo nano /lib/systemd/system/x11vnc.service
```
```
[Unit]
Description=x11vnc server for GDM
After=display-manager.service

[Service]
ExecStart=/usr/bin/x11vnc -many -shared -display :0 -auth guess -noxdamage -rfbauth /etc/vncpasswd
Restart=on-failure
RestartSec=3

[Install]
WantedBy=graphical.target
```
```
$ sudo systemctl daemon-reload
```
```
$ sudo systemctl enable x11vnc.service
```
```
$ sudo systemctl start x11vnc.service
```
```
$ sudo systemctl status x11vnc.service
```
