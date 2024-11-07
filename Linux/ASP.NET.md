1. Create service file
```
sudo nano /etc/systemd/system/yourapp.service
```
2. `yourapp.service` file
```
[Unit]
Description=Your ASP.NET Core Web App

[Service]
WorkingDirectory=/path/to/your/application/publish
ExecStart=/usr/bin/dotnet /path/to/your/application/publish/YourApp.dll
Restart=always
RestartSec=10
SyslogIdentifier=yourapp
User=www-data
Environment=ASPNETCORE_ENVIRONMENT=Production

[Install]
WantedBy=multi-user.target
```
