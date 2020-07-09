1. Распаковать архив в папку C:\Program Files\Winlogbeat
2. Перейти в папку C:\Program Files\Winlogbeat
3. Из этой папки запустить PowerShell с правами администратора
4. Выполнить скрипт .\install-service-winlogbeat.ps1. Результат:
```cmd
Status   Name               DisplayName
------   ----               -----------
Stopped  winlogbeat         winlogbeat
```
5. Внести изменения в файл настроек winlogbeat.yml.
```yaml
output.elasticsearch:
  hosts: ["10.10.10.10:9200"]

setup.kibana:
  host: "10.10.10.10:5601"
```
