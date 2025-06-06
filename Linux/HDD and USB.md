* [Посмотреть подключенные диски по USB](#посмотреть-подключенные-диски-по-usb)
* [Посмотреть информацию о жестких дисках](#посмотреть-информацию-о-жестких-дисках)
* [Посмотреть точки монтирования файловой системы](#посмотреть-точки-монтирования-файловой-системы)
* [Mount and Unmount USB Disk]()

# Посмотреть подключенные диски по USB
```bash
$ lsblk
```

# Посмотреть информацию о жестких дисках
```bash
$ sudo fdisk -l
```

# Посмотреть точки монтирования файловой системы
```bash
$ cat /etc/fstab
```
```bash
$ mount
```

# Графическая утилита управления дисками `gparted`
```bash
$ sudo gparted
```

# Mount and Unmount USB Disk
1. View disk list
```
$ lsblk
```
<details><summary>Result</summary>

```
NAME        MAJ:MIN RM   SIZE RO TYPE  MOUNTPOINT
sda           8:0    0   3.6T  0 disk  
├─sda1        8:1    0     2G  0 part  
│ └─md127     9:127  0     2G  0 raid1 
│   └─md127 253:1    0     2G  0 crypt [SWAP]
└─sda2        8:2    0   3.6T  0 part  
sdb           8:16   0   7.3T  0 disk  
├─sdb1        8:17   0     2G  0 part  
│ └─md126     9:126  0     2G  0 raid1 
│   └─md126 253:0    0     2G  0 crypt [SWAP]
└─sdb2        8:18   0   7.3T  0 part  
sdc           8:32   0   3.6T  0 disk  
├─sdc1        8:33   0     2G  0 part  
│ └─md127     9:127  0     2G  0 raid1 
│   └─md127 253:1    0     2G  0 crypt [SWAP]
└─sdc2        8:34   0   3.6T  0 part  
sdd           8:48   0   7.3T  0 disk  
├─sdd1        8:49   0     2G  0 part  
│ └─md126     9:126  0     2G  0 raid1 
│   └─md126 253:0    0     2G  0 crypt [SWAP]
└─sdd2        8:50   0   7.3T  0 part  
sde           8:64   0   3.6T  0 disk  
├─sde1        8:65   0   128M  0 part  
└─sde2        8:66   0   3.6T  0 part  
nvme0n1     259:0    0 931.5G  0 disk  
├─nvme0n1p1 259:1    0     1M  0 part  
├─nvme0n1p2 259:2    0   512M  0 part  
├─nvme0n1p3 259:3    0   915G  0 part  
└─nvme0n1p4 259:4    0    16G  0 part
```

</details>

2. Create mount point
```
$ sudo mkdir /mnt/mout-here
```

3. Mount USB disk
```
$ sudo mount /dev/sdb1 /mnt/mout-here
```

4. Unmount USB disk
```
$ sudo umount /mnt/mout-here
```

# Диагностика несмонтированного жесткого диска
1.
```bash
$ sudo lsblk -o NAME,SIZE,FSTYPE,LABEL,MOUNTPOINT,UUID
```
or
```bash
$ sudo fdisk -l
```
2. Filesystem Check (Unmounted)
```bash
$ sudo fsck -f /dev/sdX1            # ext2/ext3/ext4
$ sudo ntfsfix /dev/sdX1            # NTFS
$ sudo fsck.vfat -v /dev/sdX1       # FAT/VFAT
```
