```bash
wmctrl -m
```
```bash
echo $XDG_CURRENT_DESKTOP   # Tells you what desktop environment you are using
echo $GDMSESSION            # Tells you what option you selected from the lightdm greeter to login
```

# GNOME
View GNOME version
```bash
gnome-shell --version         # Option 1
dpkg -l | grep gnome-shell    # Option 2 - for Debian based OS
rpm -qa | grep gnome-shell    # Option 3 - for RHEL based
```
