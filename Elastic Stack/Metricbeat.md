# Содержание
* Установка (Windows)
* Установка (Linux)
# Установка (Windows)
1. Скачать архив
2. Распаковать архив в папку **C:\Program Files\Metricbeat**
3. Выполнить команду **PowerShell** с правами администратора:
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
5. Подключить необходимые модули.  
Например
```cmd
C:\Program Files\Metricbeat> .\metricbeat.exe modules enable windows
```
6.
```powershell
PS > .\metricbeat.exe setup --index-management -E output.logstash.enabled=false -E 'output.elasticsearch.hosts=["localhost:9200"]'
```
7. Запустить службу **metricbeat**.
# Установка (Linux)
1. Скачать файл (например, metricbeat-7.12.1-amd64.deb)
2. Выполнить команду
```bash
$ sudo dpkg -i metricbeat-7.12.1-amd64.deb
```
