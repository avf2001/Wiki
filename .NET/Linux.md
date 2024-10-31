# 1. Create a directory for .NET:
```
sudo mkdir -p /usr/share/dotnet
```

# 2. Extract the tar.gz file:
```
sudo tar -xzf dotnet-sdk-7.0.100-linux-x64.tar.gz -C /usr/share/dotnet
```

# 3. Configure the System to Recognize .NET
## 3.1. Create a symbolic link:
```
sudo ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet
```

## 3.2. Update the PATH environment variable
If you want to ensure that the dotnet command is available for all users, you can add it to the system's PATH. Edit the /etc/profile file or create a new file in /etc/profile.d/ (e.g., dotnet.sh):

```
echo 'export PATH=$PATH:/usr/share/dotnet' | sudo tee /etc/profile.d/dotnet.sh
```
Make the script executable:
```
sudo chmod +x /etc/profile.d/dotnet.sh
```

## 3.3. Reload the profile:
```
source /etc/profile
```

# 4. Verify the Installation
Check the .NET version:
```
dotnet --version
```

If you want to install .NET for a specific user instead of system-wide, you can follow the same steps but install it in the user's home directory (e.g., ~/dotnet) and update the user's ~/.bashrc or ~/.bash_profile file instead of the system-wide profile.
