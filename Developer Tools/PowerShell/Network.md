* [Ping](#ping)
* [Resolve IP Address](#resolve-ip-address)
# Ping
```
Test-Connection
```
# Resolve IP Address
```powershell
$ips = [System.Net.Dns]::GetHostAddresses("yourhosthere")

[System.Net.Dns]::GetHostAddresses("yourhosthere") | foreach {echo $_.IPAddressToString }
```
