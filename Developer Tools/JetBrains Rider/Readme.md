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
