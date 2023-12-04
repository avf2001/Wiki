* [Resolve IP Address](#resolve-ip-address)
# Resolve IP Address
```powershell
$ips = [System.Net.Dns]::GetHostAddresses("yourhosthere")

[System.Net.Dns]::GetHostAddresses("yourhosthere") | foreach {echo $_.IPAddressToString }
```
