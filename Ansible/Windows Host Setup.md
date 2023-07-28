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
* [4. Troubleshooting]()
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
## Get Authentication Settings
```powershell
PS > winrm get winrm/config/service/auth
Auth
    Basic = false # should be true
    Kerberos = true
    Negotiate = true
    Certificate = false
    CredSSP = false
    CbtHardeningLevel = Relaxed
```
## Set Basic Authentication
```powershell
PS > winrm set winrm/config/service/auth '@{Basic="true"}'
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
# 4. Troubleshooting
## Winrs error:Access is denied
```
This error happens even if the account is a Local Administrator and the command line is run with administrator privileges.
To solve the problem, UAC filtering for local accounts must be disabled by creating the following DWORD registry entry and setting its value to 1:
[HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System] LocalAccountTokenFilterPolic

https://knowledge.broadcom.com/external/article/157383/access-denied-configuring-winrm-using-a.html
```
## Winrs error:WinRM не удается обработать запрос. При использовании проверки подлинности Kerberos возникла следующая ошибка с кодом ошибки 0x80090311: Отсутствуют серверы, которые могли бы обработать запрос на вход в сеть.
```
> setspn -q http/somehost.somedomain.com
Проверка домена DC=somehost,DC=somedomain,DC=com

Такое SPN не найдено.
```
