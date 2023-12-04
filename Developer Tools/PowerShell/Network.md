* [FQDN](#fqdn)
* [Ping](#ping)
* [Resolve IP Address](#resolve-ip-address)
# FQDN
```powershell
> [System.Net.Dns]::GetHostByName($hostname).HostName # For local computer
```
# Ping
```
Test-Connection
```
# Resolve IP Address
```powershell
$ips = [System.Net.Dns]::GetHostAddresses("yourhosthere")

[System.Net.Dns]::GetHostAddresses("yourhosthere") | foreach {echo $_.IPAddressToString }
```
