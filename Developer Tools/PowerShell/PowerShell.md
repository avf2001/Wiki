# Windows PowerShell Integrated Scripting Environment (ISE)
https://learn.microsoft.com/en-us/powershell/scripting/windows-powershell/ise/introducing-the-windows-powershell-ise?view=powershell-7.4

# View Version
```powershell
PS> $PSVerionTable
```
# Prompt
## Change Prompt Format
```powershell
PS C:\Users\Username>

PS> function prompt { "$((Get-Date).ToShortString()) $(Get-Location)> " }

10:15 AM C:\Users\Username>
```
## Reset Prompt
```powershell
PS> Remove-Item Function:\prompt -ErrorAction SilentlyContinue
```
# Navigation
## Get-Location (like pwd)
## Set-Location (like cd)
## Push-Location
## Pop-Location
## Get-ChildItem (like ls or dir)
## New-Item (create directory or file)
## Remove-Item
## Test-Path
