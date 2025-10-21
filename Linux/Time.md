# Debian
Check current status:
```
timedatectl status
```

Configure NTP servers:
```
sudo nano /etc/systemd/timesyncd.conf
```

Add or modify these lines:
```
[Time]
NTP=pool.ntp.org time.google.com
FallbackNTP=0.debian.pool.ntp.org 1.debian.pool.ntp.org 2.debian.pool.ntp.org 3.debian.pool.ntp.org
RootDistanceMaxSec=5
PollIntervalMinSec=32
PollIntervalMaxSec=2048
```

Apply changes:
```
sudo systemctl restart systemd-timesyncd
sudo systemctl enable systemd-timesyncd
timedatectl timesync-status
```
