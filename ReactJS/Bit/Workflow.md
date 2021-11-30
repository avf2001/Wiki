# 1. Создание рабочего пространства (workspace)
## 1.1. Вариант 1
Создание рабочего пространства
```cmd
> bit new react <my-workspace-name>
```
Справка по команде
```cmd
> bit new --help
```
## 1.2. Вариант 2 (предпочтительный)
```cmd
> mkdir <my-workspace-name>
> cd <my-workspace-name>
> bit init
```
Далее необходимо отредактировать файл `workspace.jsonc`.
```json
{
  "teambit.workspace/workspace": {    
    "name": "my-workspace-name", //
    "defaultScope": "my-scope" //
  }  
}
```
# 2.
# 3.
# 4.
