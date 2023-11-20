Для работы с IIS необходимо установить модуль WebAdministration. Для этого нужно запустить PowerShell с правами администратора.
```powershell
PS > Import-Module WebAdministration
```
Для просмотра доступных комманд модуля WebAdministration необходимо выполнить команду:
```powershell
PS > Get-Command -module WebAdministration
```
# Application Pool
## Остановить
```powershell
PS > Stop-WebAppPool -Name "DefaultAppPool"
```
