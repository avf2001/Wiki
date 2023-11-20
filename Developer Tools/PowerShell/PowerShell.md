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
