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
3. Настроить необходимые параметры в файле **/etc/metricbeat/metricbeat.yml**:
```yml
output.elasticsearch:
  hosts: ["10.10.10.10:9200"]
  
setup.kibana:
  host: "10.10.10.10:9200"
```
4. Подключить необходимые модули.
Например
```yml
metricbeat.modules:
- module: system
  metricsets:
    - cpu             # CPU usage
    #- load            # CPU load averages
    - memory          # Memory usage
    - network         # Network IO
    - process         # Per process metrics
    - process_summary # Process summary
    - uptime          # System Uptime
    - socket_summary  # Socket summary
    #- core           # Per CPU core usage
    #- diskio         # Disk IO
    #- filesystem     # File system usage for each mountpoint
    #- fsstat         # File system summary metrics
    #- raid           # Raid
    #- socket         # Sockets and connection info (linux only)
    #- service        # systemd service information
  enabled: true
  period: 10s
  processes: ['.*']

  # Configure the metric types that are included by these metricsets.
  cpu.metrics:  ["percentages","normalized_percentages"]  # The other available option is ticks.
  core.metrics: ["percentages"]  # The other available option is ticks.
```
