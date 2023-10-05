# kerberos: the specified credentials were rejected by the server
При вызове команды **`ansible all -m win_ping`** получаем сообщение:
```
kerberos: the specified credentials were rejected by the server
```
Решение:

Файл `/etc/ansible/hosts`
```
ansible_winrm_transport=ntlm
```
