# RedOS
```bash
$ sudo dnf install -y docker-ce docker-ce-cli
$ sudo systemctl enable docker
$ sudo systemctl start docker
$ systemctl status docker
$ sudo docker info
```
```bash
# Проверка существования группы
$ getent group docker
# Добавление текущего пользователя в группу docker
$ sudo usermod -aG docker $USER
# Необходимо выйти из системы
$ logout
```
