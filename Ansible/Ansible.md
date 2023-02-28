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
