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

Inside the Debian session:
```
# Update Debian packages
apt update && apt upgrade -y

# Install dependencies
apt install -y curl gnupg apt-transport-https ca-certificates software-properties-common

# Add Docker's official GPG key
install -m 0755 -d /etc/apt/keyrings
curl -fsSL https://download.docker.com/linux/debian/gpg | gpg --dearmor -o /etc/apt/keyrings/docker.gpg
chmod a+r /etc/apt/keyrings/docker.gpg

# Add Docker repository
echo "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.gpg] https://download.docker.com/linux/debian $(. /etc/os-release && echo "$VERSION_CODENAME") stable" | tee /etc/apt/sources.list.d/docker.list > /dev/null

# Install Docker
apt update
apt install -y docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin

# Start Docker daemon
dockerd &
```
