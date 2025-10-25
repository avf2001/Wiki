# SSH Server (OpenSSH)
1. Install Termux from F-Droid (recommended for newer versions) or the Play Store (may be outdated).

2. Open Termux:
```shell
pkg update && pkg upgrade    # update packages

pkg install openssh          # Install the OpenSSH package

whoami                       # View current user

passwd                       # Set a password for your Termux user

sshd                         # Start the SSH server on port 8022 (the default for Termux)
```

3. Connect to SSH server
```shell
ssh <phone-ip-address> -p 8022
```

# Docker
```shell
pkg update && pkg upgrade

pkg install root-repo

pkg install proot-distro

proot-distro install debian
```
```shell
proot-distro login debian
```
