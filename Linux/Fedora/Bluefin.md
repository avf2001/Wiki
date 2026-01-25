- [Browsers]()
- [File Managers]()

# Browsers

## Google Chrome Installation

### Method 1 - Using Flatpack (recommended)
```bash
flatpak install flathub com.google.Chrome
```

### Method 2 - Using Distrobox
```bash
# Create a container (Fedora-based)
distrobox-create --name chrome-box --image fedora:latest

# Enter the container
distrobox-enter chrome-box

# Inside the container, install Chrome
sudo dnf config-manager --set-enabled google-chrome
sudo dnf install google-chrome-stable
```



# File Managers

## Nautilus
```bash
flatpak install flathub org.gnome.Nautilus
```
