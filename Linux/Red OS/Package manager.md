* [Dnf](#dnf)
* [Yum](#yum)

# Dnf
## Resources
https://geekflare.com/dnf-intro/
## Install VS Code
Source: https://code.visualstudio.com/docs/setup/linux?msclkid=142188ccd05811ecac686bf70f48803d
```bash
$ dnf check-update
$ sudo dnf install code

## Локальная установка
$ sudo dnf localinstall code-1.89.1-1715060595.el8.x86_64.rpm
```
## Search a package
```bash
$ sudo dnf search <package_name>
```
## Download RPM packages locally
```bash
$ sudo dnf download ruby

$ sudo dnf download --resolve ruby # pulls dependent packages as well
```

# Yum
## Repository Config Files
/etc/yum.repos.d/  
RedOS-Base.repo  
RedOS-kernels.repo  
RedOS-update.repo  
