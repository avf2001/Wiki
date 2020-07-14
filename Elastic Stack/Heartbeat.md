# Установка
1. Скачать архив
2. Распаковать архив в папку **C:\Program Files\Heartbeat**
3. Запустить **PowerShell** с правами администратора.
4. Перейти в папку **C:\Program Files\Heartbeat**. Выполнить команду:
```powershell
PS C:\Program Files\Heartbeat> .\install-service-heartbeat.ps1
```
5. Настроить необходимые параметры в файле **heartbeat.yml**:
```yml
output.elasticsearch:
  hosts: ["10.10.10.10:9200"]
  
setup.kibana:
  host: "10.10.10.10:9200"
```
6. Настроить ...
7. Запустить службу **heartbeat**:
```powershell
PS > Start-Service heartbeat
```
# Создание индекса вручную
1. Запустить **PowerShell** с правами администратора.
2. Перейти в папку **C:\Program Files\Heartbeat**. Выполнить команду:
```powershell
PS > .\heartbeat.exe setup --index-management -E output.logstash.enabled=false -E 'output.elasticsearch.hosts=["localhost:9200"]'
```
