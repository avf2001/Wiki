# Установка
## Сервер (7.8)
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
5. Насторить индексы:
```powershell
PS C:\Program Files\APM-Server> .\apm-server.exe setup --index-management
```
6. Запустить службу **APM Server**:
```powershell
PS > Start-Service apm-server
```
## Клиент (1.x)
1. Подключить Nuget-пакет.
* Для **.NET Framework**:
  * Elastic.Apm
  * Elastic.Apm.AspNetFullFramework
  * Elastic.Apm.EntityFramework6
  * Elastic.Apm.SqlClient
* Для **.NET Core**:
  * Elastic.Apm.NetCoreAll
  * Elastic.Apm.AspNetCore
  * Elastic.Apm.EntityFrameworkCore
2. Настроить приложение.
ASP.NET Core:  
Файл **startup.cs**
```csharp
using Elastic.Apm.NetCoreAll;

public class Startup
{
  public void Configure(IApplicationBuilder app, IHostingEnvironment env)
  {
    // Must be the first line in the method to properly measure statistics
    app.UseAllElasticApm(Configuration);
    //…rest of the method
  }
  //…rest of the class
}
```
Файл **appsettings.json**
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "Elastic.Apm": "Debug"                      //This
    }
  },
  "AllowedHosts": "*",
  "ElasticApm":
    {
      "ServerUrls":  "http://myapmserver:8200",   //This
      "SecretToken":  "apm-server-secret-token",  //This
      "TransactionSampleRate": 1.0                //This
    }
}
```
# Использование
