# Copy SSH key file to remote server
```shell
ssh-copy-id username@server.name.com
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
