- [Dockly](#dockly)
- [Lazydocker](#lazydocker)
- [Dive](#dive)
- [Watchtower](#watchtower)
- [Portainer](#portainer)
- [Hadolint](#hadolint)
- [Ctop](#ctop)
- [Dozzle](#dozzle)
- [Dockge](#dockge)

# Dockly
[Github](https://github.com/lirantal/dockly)

# Lazydocker
[Github](https://github.com/jesseduffield/lazydocker)

A simple terminal UI for both docker and docker-compose, written in Go with the gocui library.

## Installation
1. Download tar.gz file from https://github.com/jesseduffield/lazydocker/releases
2. Extract archive to current directory:
```bash
tar -xzf lazydocker_0.24.1_Linux_x86_64.tar.gz
```
4. Copy `lazydocker` file to `/usr/local/bin directory`:
```bash
$ sudo cp lazydocker /usr/local/bin
```

# Dive
[Github](https://github.com/wagoodman/dive)

A tool for exploring a Docker image, layer contents, and discovering ways to shrink the size of your Docker/OCI image.

## Installation
1. Download `rpm` file from `https://github.com/wagoodman/dive/releases`.
2. Install `rpm` file:
```bash
$ sudo dnf install dive_0.13.1_linux_amd64.rpm # RedOS
```

## Usage
```bash
$ dive image_name:tag_name
```

# Watchtower
[Github](https://github.com/containrrr/watchtower) [Site](https://containrrr.dev/watchtower/)

With watchtower you can update the running version of your containerized app simply by pushing a new image to the Docker Hub or your own image registry.

# Portainer
[Site](https://www.portainer.io/)

# Hadolint
[Github](https://github.com/hadolint/hadolint)

# Ctop
[Github](https://github.com/bcicen/ctop)

# Dozzle
[Github](https://github.com/amir20/dozzle)

# Dockge
[Site](https://dockge.kuma.pet/) [Github](https://github.com/louislam/dockge)

A fancy, easy-to-use and reactive self-hosted docker compose.yaml stack-oriented manager.
