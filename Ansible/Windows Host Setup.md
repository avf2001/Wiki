# Настройка Windows Managed Node
* Host Requirements
  * Windows Version
  * PowerShell Version
    * Option 1
    * Option 2
  * WinRM Listener
    * View WinRm settings
* Enable Basic Authentication
* Config Trusted Hosts
  * View Trusted Hosts
  * Add Trusted Host To List
* [3. Проверка подключения от Control Node]()
# Host Requirements
## Windows Version
``` cmd
> systeminfo | findstr /C:"OS Name"
```
## PowerShell Version
### Option 1
```powershell
PS > Get-Host | Select-Object Version

Version
-------
5.1.14409.1018
```
### Option 2
```powershell
PS > $PSVersionTable

Name                           Value
----                           -----
PSVersion                      5.1.14409.1018
PSEdition                      Desktop
PSCompatibleVersions           {1.0, 2.0, 3.0, 4.0...}
BuildVersion                   10.0.14409.1018
CLRVersion                     4.0.30319.42000
WSManStackVersion              3.0
PSRemotingProtocolVersion      2.3
SerializationVersion           1.1.0.1
```
## WinRM Listener
### View WinRm settings
```cmd
> winrm e winrm/config/listener

Listener [Source="GPO"]
    Address = *
    Transport = HTTP
    Port = 5985
    Hostname
    Enabled = true
    URLPrefix = wsman
    CertificateThumbprint
    ListeningOn = 10.83.248.99, 127.0.0.1, ::1, fe80::5efe:10.83.248.99%14
```
# Enable Basic Authentication
```cmd
> winrm set winrm/config/service/auth '@{Basic="true"}'
```
# Config Trusted Hosts
## View Trusted Hosts
```powershell
PS > Get-Item WSMan:\localhost\Client\TrustedHosts
```
## Add Trusted Host To List
```powershell
PS > Set-Item WSMan:\localhost\Client\TrustedHosts -Value 'machineC' -Concatenate
```
# 3. Проверка подключения от Control Node
## 3.1 Проверка открытия порта
```shell
$ telnet somehost.somedomain.com 5985
```
