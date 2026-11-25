# SSH

## Сценарий: Создание и копирование SSH ключа на удаленный сервер
1. Сгенерировать SSH ключ для сервера:
```shell
ssh-keygen -t ed25519 -f ~/.ssh/server.name.com_key -C "user@sserver.name.com"
```

2. Просмотреть созданный файл:
```shell
ls ~/.ssh/
```

3. Скопировать сгенерированный открытый ключ на удаленный сервер:
```shell
ssh-copy-id -i ~/.ssh/server.name.com_key.pub user@server.name.com
```

4. Test SSH connection
```shell
ssh username@server.name.com
```

6. Добавить в файл `~/.ssh/config` строки:
```shell
Host server
    HostName server.name.com
    User user
    IdentityFile ~/.ssh/server.name.com_key
```

6. Ensure correct permissions (optional but recommended):
```shell
chmod 600 ~/.ssh/config
chmod 600 ~/.ssh/server1_key
```

## Remove SSH key from remote server
1. Connect to remote server using SSH
```shell
ssh username@remote-server
```

2. Open `~/.ssh/authorized_keys` file for edit
```shell
nano ~/.ssh/authorized_keys
```

3. Locate the key you want to remove (each line represents a different public key).

4. Delete the line containing the unwanted key.

5. Save file and exit.

6. Ensure correct permissions (optional but recommended):
```shell
chmod 600 ~/.ssh/authorized_keys
chmod 700 ~/.ssh
```

7. Exit the SSH session:
```shell
exit
```

## How to Implement Multiple Keys (If You Choose That)
If you decide to use different keys, you can manage them via ~/.ssh/config:

```
# ~/.ssh/config
Host server1
    HostName 123.45.67.89
    User admin
    IdentityFile ~/.ssh/server1_key

Host server2
    HostName 98.76.54.32
    User deploy
    IdentityFile ~/.ssh/server2_key
```
Then, just run ssh server1 or ssh server2, and SSH will automatically use the correct key.

# SSH Advanced Techniques

## Configuration

## Jump Hosts (ProxyJump)

## Connection Multiplexing

## Local Port Forwarding (-L)

## Remote Port Forwarding (-R)

## Dynamic Port Forwarding (-D)

## Reverse Tunneling

## Agent Forwarding

## Remote Command Execution
Выполнение команд на удаленном сервере:
```shell
ssh some-server 'uptime; free -h; df -h'
```
Запуск локального скрипта на удаленном сервере:
```shell
ssh some-server 'bash -s' < ./some-script.sh
```
Запуск команды на нескольких серверах
```shell
for host in vcs monitoring webext web1; do echo "== $host"; ssh "$host" uptime; done
```

## SCP and SFTP

## RSync over SSH

## Unix Socket Forwarding

## ProxyCommand

## Troubleshooting
### На стороне клиента
Подробная информация о подключении
```shell
ssh -vv some-server true
```
Анализ конфигурации
```shell
ssh -G vcs | grep -E '^(hostname|user|port|identityfile|proxyjump) '
```
```shell
ssh -Q kex | tail -3
```
### На стороне сервера
```shell
journalctl -u ssh -f
```
```shell
sudo ss -tnp | grep ':22'
```

## Advanced Techniques
```shell
ssh -o ServerAliveInterval=30 -o ServerAliveCountMax=3 some-server
```
