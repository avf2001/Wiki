```
sudo ubuntu-drivers autoinstall
```
Для начала вам нужно установить несколько пакетов, которые позволят вам управлять расширениями GNOME. Вызовите терминал и выполните следующую команду:
```
sudo apt install chrome-gnome-shell gnome-tweaks
```
# Docker
```bash
# Remove existing packages
sudo apt-get purge docker.io docker-ce docker-compose docker-compose-v2 podman-docker containerd runc

# Update system
sudo apt-get update
sudo apt-get install ca-certificates curl

# Add Docker repository
sudo mkdir -m 0755 -p /etc/apt/keyrings
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /etc/apt/keyrings/docker.gpg
echo \
  "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.gpg] https://download.docker.com/linux/ubuntu \
  $(lsb_release -cs) stable" | sudo tee /etc/apt/sources.list.d/docker.list > /dev/null

# Install Docker
sudo apt-get update
sudo apt-get install docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin
```
