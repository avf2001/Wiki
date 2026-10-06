# Установка из архива tar.gz на Linux
1. Создать папку
```shell
sudo mkdir /opt/jetbrains/rider-2026.2.3.1
```

3. Распаковать архив в папку
```
sudo tar -xzf ./JetBrains.Rider-2026.2.3.1.tar.gz -C /opt/jetbrains/rider-2026.2.3.1 --strip-components=1
```
4. 
```shell
sudo chown -R flinalev /opt/jetbrains/rider-2026.2.3.1
```

5. В файл /opt/jetbrains/rider-2026.2.3.1/bin/rider64.vmoptions
```shell
-javaagent:/opt/jetbrains/rider-crack/2026.1.1/sniarbtej.jar=id=sniarbtej,user=Downloadly.ir,exp=2048-10-24,force=true
```

7. Создать файл /usr/share/applications/rider2026.2.3.1.desktop
```ini
[Desktop Entry]
Version=1.0
Type=Application
Name=JetBrains Rider 2026.2.3.1
Exec=/opt/jetbrains/rider-2026.2.3.1/bin/rider
Icon=/opt/jetbrains/rider-2026.2.3.1/bin/rider.png
Terminal=false
Categories=Development;IDE;
```

# Создание базового образа для отладки
1. Создать **`Dockerfile`**
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

USER root

# Install the required tools: procps (for ps command), net-tools (for netstat), and the .NET debugger (vsdbg)
RUN apt-get update \
    && apt-get install -y --no-install-recommends \
        procps \
        net-tools \
        wget \
        unzip \
    && rm -rf /var/lib/apt/lists/*

RUN wget -qO- https://aka.ms/getvsdbgsh | sh /dev/stdin -v latest -l /vsdbg

USER $APP_UID
```
2. Создать образ на основе этого **`Dockerfile`**:
```shell
 docker build -t mycompany/dotnet/aspnet-rider-debug:9.0 -f .\Dockerfile .
```
3. Экспортировать созданный образ:
```shell
docker save -o mycompany_dotnet_aspnet-rider-debug_9.0.tar mycompany/dotnet/aspnet-rider-debug:9.0
```
4. Загрузить созданный файл на целевой машине:
```shell
docker load -i mycompany_dotnet_aspnet-rider-debug_9.0.tar
```
5. Указать в качестве базового образа загруженный образ:
```dockerfile
FROM mycompany/dotnet/aspnet-rider-debug:9.0 AS base
```
