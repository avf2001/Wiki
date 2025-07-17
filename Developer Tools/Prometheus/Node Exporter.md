# Установка
1. Создать пользователя
```shell
useradd -rs /bin/false nodeusr
```
2.
```shell
sudo dnf install prometheus-node_exporter
```
3. 
```shell
sudo touch /etc/systemd/system/node_exporter.service
sudo nano /etc/systemd/system/node_exporter.service
```
```
[Unit]
Description=Node Exporter
After=network.target
[Service]
User=nodeusr
Group=nodeusr
Type=simple
ExecStart=/usr/bin/node_exporter
[Install]
WantedBy=multi-user.target
```

4. 
```shell
sudo systemctl enable node_exporter --now
```

5. 
```shell
systemctl status node_exporter
```

6.
```shell
curl http://localhost:9100/metrics
```
