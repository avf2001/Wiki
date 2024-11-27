* [Network Utils](#network-utils)
  * [ifconfig](#ifconfig)
  * [ip](#ip)
  * [tc](#tc)
* [Settings](#settings)
* [Check Remote Open Port](#check-remote-open-port)
* [Show Open Ports](#show-open-ports)
* [Show Port is Used](#show-port-is-used)

# Network Utils
## `ifconfig`

`ifconfig` is used to configure network interfaces.

Display information about all network interfaces:

```bash
ifconfig
```

## `ip`

`ip` is a more modern and powerful tool for managing network interfaces and routing tables.

### Example

Display information about all network interfaces:

```bash
ip addr show
```

## `tc`

The `tc` command in Linux is used to configure Traffic Control (TC) settings, which allow you to manage and shape network traffic. Traffic Control enables you to prioritize, throttle, and schedule network packets, which is useful for optimizing network performance, simulating network conditions, and implementing Quality of Service (QoS) policies.

### 3. `ping`

`ping` is used to test the reachability of a host on an IP network.

#### Example

Ping a remote host:

```bash
ping google.com
```

### 4. `traceroute`

`traceroute` is used to trace the route packets take to reach a network host.

#### Example

Trace the route to a remote host:

```bash
traceroute google.com
```

### 5. `netstat`

`netstat` displays network connections, routing tables, interface statistics, masquerade connections, and multicast memberships.

#### Example

Display all active network connections:

```bash
netstat -a
```

### 6. `ss`

`ss` is a modern alternative to `netstat` and provides more detailed information about network connections.

#### Example

Display all active network connections:

```bash
ss -a
```

### 7. `nslookup`

`nslookup` is used to query DNS name servers for information about hostnames and IP addresses.

#### Example

Lookup the IP address of a hostname:

```bash
nslookup google.com
```

### 8. `dig`

`dig` is a more powerful DNS lookup tool than `nslookup`.

#### Example

Lookup the IP address of a hostname:

```bash
dig google.com
```

### 9. `host`

`host` is a simple DNS lookup tool.

#### Example

Lookup the IP address of a hostname:

```bash
host google.com
```

### 10. `route`

`route` is used to display or modify the IP routing table.

#### Example

Display the routing table:

```bash
route -n
```

### 11. `iptables`

`iptables` is used to set up, maintain, and inspect the tables of IP packet filter rules in the Linux kernel.

#### Example

Display the current firewall rules:

```bash
sudo iptables -L
```

### 12. `nmap`

`nmap` is a network scanning tool used to discover hosts and services on a network.

#### Example

Scan a range of IP addresses:

```bash
nmap 192.168.1.0/24
```

### 13. `tcpdump`

`tcpdump` is a powerful packet analyzer that captures and analyzes network traffic.

#### Example

Capture packets on a specific interface:

```bash
sudo tcpdump -i eth0
```

### 14. `nc` (Netcat)

`nc` (Netcat) is a versatile networking tool that can read and write data across network connections.

#### Example

Listen on a specific port:

```bash
nc -l 1234
```

### 15. `curl`

`curl` is a command-line tool for transferring data with URLs.

#### Example

Download a file from a URL:

```bash
curl -O http://example.com/file.txt
```

### 16. `wget`

`wget` is another command-line tool for downloading files from the web.

#### Example

Download a file from a URL:

```bash
wget http://example.com/file.txt
```

### 17. `ssh`

`ssh` is used to connect to remote servers securely.

#### Example

Connect to a remote server:

```bash
ssh user@remote_host
```

### 18. `scp`

`scp` is used to securely copy files between hosts on a network.

#### Example

Copy a file from a local machine to a remote server:

```bash
scp localfile.txt user@remote_host:/path/to/destination/
```

### 19. `rsync`

`rsync` is a fast and versatile file copying tool that can copy files locally or over a network.

#### Example

Synchronize files between two directories:

```bash
rsync -av /source/directory/ /destination/directory/
```

### 20. `mtr`

`mtr` combines the functionality of `ping` and `traceroute` into a single tool.

#### Example

Trace the route to a remote host:

```bash
mtr google.com
```

### Conclusion

Linux provides a comprehensive set of network utilities that allow you to manage, monitor, and troubleshoot network connections. The examples provided should help you get started with using these tools in your Linux environment.

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
$ sudo netstat -tuln | grep -w <PORT_NUMBER>

# Method 2
$ sudo ss -tuln | grep -w <PORT_NUMBER>

# Method 3
$ sudo lsof -i:<PORT_NUMBER>

# Method 4
$ sudo fuser <PORT_NUMBER>/tcp
```
