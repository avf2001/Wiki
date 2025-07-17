# Create and copy SSH key file to remote server
1. Generate SSH key for server
```shell
ssh-keygen -t ed25519 -f ~/.ssh/server.name.com_key -C "user@sserver.name.com"
```

2. View created file:
```shell
ls ~/.ssh/
```

3. Copy public key to remote server
```shell
ssh-copy-id -i ~/.ssh/server.name.com_key.pub user@server.name.com
```

4. Test SSH connection

5. Edit `~/.ssh/config` file
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

# Remove SSH key from remote server
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

# How to Implement Multiple Keys (If You Choose That)
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
