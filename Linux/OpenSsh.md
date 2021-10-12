```bash
$ sudo apt update && sudo apt upgrade -y && sudo apt full-upgrade -y
$ sudo apt autoremove
```

# 1. Install open ssh server
check if open ssh server installed:
~~~bash
$ man sshd_config
# or
$ ssh -V
~~~
To install open ssh
~~~bash
$ sudo apt update
$ sudo apt install openssh-server -y
~~~
# 2. Setup network rules
Check firewall status
~~~bash
$ sudo ufw status
~~~
Setup rules:
~~~bash
$ sudo ufw allow ssh
$ sudo ufw default deny incoming
$ sudo ufw default allow outgoing
~~~
Enable firewall
~~~bash
$ sudo ufw enable
~~~
Check status
~~~bash
$ sudo ufw status
~~~
or more detailed
~~~bash
$ sudo ufw status verbose
~~~
# 3. Start SSH Server
~~~bash
$ sudo service ssh start
~~~
Check status
~~~bash
$ sudo service ssh status
~~~
or check status
~~~bash
$ sudo netstat -tanup | grep ssh
~~~
