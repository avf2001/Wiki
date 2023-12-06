* [FQDN](#fqdn)
* [Ping](#ping)
* [Resolve IP Address](#resolve-ip-address)
* [Verify Open Port](verify-open-port)
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
# Verify Open Port
```powershell
PS > tnc "some.server.name.com" -Port 1234
```
