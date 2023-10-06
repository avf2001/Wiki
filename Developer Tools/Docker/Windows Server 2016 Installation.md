Run PowerShell console as administrator.

PS > Install-WindowsFeature containers
PS > Restart-Computer
PS > New-Item -Path 'C:\Program Files\Docker' -ItemType Directory
Download files:
- https://aka.ms/tp5/b/dockerd - dockerd.exe
- https://aka.ms/tp5/b/docker - docker.exe

Put the files into C:\Program Files\Docker folder.

Add C:\Program Files\Docker folder to PATH variable.

Reopen PowerShell console to reload PATH variable.
PS > dockerd --register-service

Error:
fatal: Error starting daemon: Error initializing network controller: Error creating default network: HNS failed with error : The object already exists.

Solution:
