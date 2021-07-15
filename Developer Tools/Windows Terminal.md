# Содержание
* Установка
* Настройка
  * Поддержка Git
# Установка
Из Microsoft Store (предпочтительно) или GitHub (https://github.com/Microsoft/Terminal)
# Настройка
## Установка шрифта Cascadia Code
Скачать zip архив https://github.com/microsoft/cascadia-code/releases. В папке `otf\static` архива содержатся файлы `CascadiaCodePL-*` и `CascadiaMonoPL-*`. Скопировать эти файлы в папку `C:\Windows\Fonts`. Далее запустить Windows Terminal, открыть окно Settings > Windows Power Shell > Appearence > Font face.
## Поддержка Git
1. Установить Git for Windows (https://git-scm.com/downloads)
2. Выполнить команды Powershell:
```powershell
> Install-Module posh-git -Scope CurrentUser
> Install-Module oh-my-posh -Scope CurrentUser
```
3. Запустить Powershell с правами администратора и выполнить команду
```powershell
> Set-Executionpolicy Unrestricted
```

