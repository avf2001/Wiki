# RedOS
```bash
$ sudo dnf install -y docker-ce docker-ce-cli
$ sudo systemctl enable docker
$ sudo systemctl start docker
$ systemctl status docker
$ sudo docker info
```
## Добавление текущего пользователя в группу docker
```bash
$ getent group docker              # Проверка существования группы
$ sudo usermod -aG docker $USER    # Добавление текущего пользователя в группу docker
$ logout                           # Необходимо выйти из системы
```
# Bluefin (Fedora)
1.
```bash
rpm-ostree install docker-ce docker-ce-cli containerd.io
```
