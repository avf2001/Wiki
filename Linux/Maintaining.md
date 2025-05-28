Truncate the File (Clear Contents). This removes all content from the file but keeps the file itself intact.
```bash
sudo truncate -s 0 /var/log/messages
```
-s 0 sets the file size to 0 bytes.
