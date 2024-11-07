* [Settings](#settings)
* [Check Remote Open Port](#check-remote-open-port)
* [Show Open Ports](#show-open-ports)
* [Show Port is Used](#show-port-is-used)
# Settings
## Debian
```bash
$ sudo nano /etc/network/interfaces
```
```
# The loopback network interface
auto lo
iface lo inet loopback
 
# The primary network interface
auto enp0s5
iface enp0s5  inet static
 address 192.168.2.236
 netmask 255.255.255.0
 gateway 192.168.2.254
 dns-domain sweet.home
 dns-nameservers 192.168.2.254
```
# Check Remote Open Port
## NC
```shell
$ nc -zvw10 <IP Address or Host Name> <Port Number>
$ nc -zvw10 192.168.0.100 1234
```
## Nmap
```shell
$ sudo apt-get install nmap
```
```shell
$ nmap localhost -p 22
```
## Telnet
```shell
$ telnet localhost 22
```
# Show Open Ports
Source: https://www.cyberciti.biz/faq/unix-linux-check-if-port-is-in-use-command/
```shell
$ sudo lsof -i -P -n | grep LISTEN
$ sudo netstat -tulpn | grep LISTEN
$ sudo ss -tulpn | grep LISTEN
$ sudo lsof -i:22 ## see a specific port such as 22 ##
$ sudo nmap -sTU -O IP-address-Here
```

# Show Port is Used
```
# Method 1
$ sudo netstat -tuln | grep <PORT_NUMBER>
```
