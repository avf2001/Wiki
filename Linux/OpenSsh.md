sudo apt update && sudo apt upgrade -y && sudo apt full-upgrade -y
sudo apt autoremove

# 1. Install open ssh server
-----------------------
check if open ssh server installed:
$ man sshd_config

To install open 
$ sudo apt update
$ sudo apt install openssh-server -y

# 2. Setup network rules
--------
Check firewall status
$ sudo ufw status

Setup rules:
$ sudo ufw allow ssh
$ sudo ufw default deny incoming
$ sudo ufw default allow outgoing

Enable firewall
$ sudo ufw enable

Check status
$ sudo ufw status

or more detailed
$ sudo ufw status verbose

# 3. Start SSH Server
-------------------
$ sudo service ssh start

Check status
$ sudo service ssh status

or check status
$ sudo netstat -tanup | grep ssh
