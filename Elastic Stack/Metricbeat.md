# Установка
1. Скачать архив
2. Распаковать архив в папку **C:\Program Files\Metricbeat**
3. Выполнить команду **PowerShell**:
```powershell
PS C:\Program Files\Metricbeat> .\install-service-metricbeat.ps1
```
4. Настроить необходимые параметры в файле **metricbeat.yml**:
```yml
output.elasticsearch:
  hosts: ["10.10.10.10:9200"]
  
setup.kibana:
  host: "10.10.10.10:9200"
```
