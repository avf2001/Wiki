# Установка
## Сервер
1. Скачать архив.
2. Распаковать архив в папку **C:\Program Files\APM-Server**.
3. Выполнить команду **PowerShell** с правами администратора:
```powershell
PS C:\Program Files\APM-Server> .\install-service-apm-server.ps1
```
4. Настроить необходимые параметры в файле **apm-server.yml**:
```yml
apm-server:
  host: "10.10.10.10:8200"
  
output.elasticsearch:
  hosts: ["10.10.10.10:9200"]

kibana:
  host: "10.10.10.10:9200"
```
