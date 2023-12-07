# Настройка Windows Managed Node
* Host Requirements
  * Windows Version
  * PowerShell Version
    * Option 1
    * Option 2
  * WinRM Listener
    * View WinRm settings
    * Delete Listener
    * Create HTTP Listener
    * Create HTTPS Listener
    * Create Self-Signed Certificate
    * Create Configured HTTPS Listener
    * Script to Connect from Remote Client
* Enable Basic Authentication
* [Config Trusted Hosts](config-trusted-hosts)
* [3. Проверка подключения от Control Node](#3-проверка-подключения-от-control-node)
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

### Delete Listener
```cmd
> winrm delete winrm/config/Listener?Address=*+Transport=HTTP
```

### Create HTTP Listener
```cmd
> winrm quickconfig
```

### Create HTTPS Listener
```cmd
> winrm quickconfig -transport:https
```

### Create Self-Signed Certificate
```powershell
PS > New-SelfSignedCertificate -DnsName "<YOUR_DNS_NAME>" -CertStoreLocation Cert:\LocalMachine\My
```

### Create Configured HTTPS Listener
```cmd
> winrm create winrm/config/Listener?Address=*+Transport=HTTPS '@{Hostname="<YOUR_DNS_NAME>"; CertificateThumbprint="<COPIED_CERTIFICATE_THUMBPRINT>"}'
```

### Script to Connect from Remote Client
```powershell
$hostName="some.host.name.com"
$winrmPort = "5986"

$remoteUsername = "username"
$remotePassword = "password"

$securePassword = ConvertTo-SecureString -String $remotePassword -AsPlainText -Force

# Get the credentials of the machine
$cred = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $remoteUsername, $securePassword

# Connect to the machine
$soptions = New-PSSessionOption -SkipCACheck # skip SSL check for self-signed certificate
Enter-PSSession -ComputerName $hostName -Port $winrmPort -Credential $cred -SessionOption $soptions -UseSSL
```

# Enable Basic Authentication
## Get Authentication Settings
Run PowerShell as Administrator.
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
```powershell
PS > Get-Item WSMan:\localhost\Client\TrustedHosts                                     # View Trusted Hosts
PS > Set-Item WSMan:\localhost\Client\TrustedHosts -Value 'machineC'                   # Add Trusted Host To List
PS > Set-Item WSMan:\localhost\Client\TrustedHosts -Value 'machineC' -Concatenate      # Add Trusted Host To List
```
# 3. Проверка подключения от Control Node
## 3.1 Проверка открытия порта
```shell
$ telnet somehost.somedomain.com 5985
```
## 3.2 Проверка доступности ноды
```
$ ansible all -m ping # проверка всех нод
$ ansible all -m win_ping # проверка нод с OS Windows
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
https://gist.github.com/mapbutcher/6016861
```powershell
PS > set-executionpolicy -executionpolicy remotesigned
PS > winrm quickconfig -q
PS > winrm set winrm/config/winrs '@{MaxMemoryPerShellMB="512"}'
PS > winrm set winrm/config '@{MaxTimeoutms="1800000"}'
PS > winrm set winrm/config/service '@{AllowUnencrypted="true"}'
PS > winrm set winrm/config/service/auth '@{Basic="true"}'
```
## kinit: KDC reply did not match expectations while getting initial credentials
```
https://michlstechblog.info/blog/linux-kerberos-authentification-against-windows-active-directory/
```
## /usr/lib/python3/dist-packages/winrm/transport.py:308: UserWarning: Function <function HTTPKerberosAuth.__init__ at 0x7f8462482bf8> does not contain optional arg send_cbt, check installed version with pip list % (str(function), name))
```bash
$ sudo pip install --upgrade requests-kerberos
```
## kerberos: Bad HTTP response returned from server. Code 500
On Windows host side
```powershell
PS > Set-Item -Path WSMan:\localhost\Service\AllowUnencrypted -Value true
```
