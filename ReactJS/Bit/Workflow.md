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
  },
  "teambit.workspace/variants": {    
    "*": {      
      "teambit.react/react": { } //
    }
  }
}
```
# 2. Установка необходимых пакетов
```cmd
> bit install react --type peer
> bit install react-dom --type peer
```
Пример других пакетов
```cmd
> bit install @elastic/eui --type peer
```
# 3. Создание компонента (TypeScript)
```cmd
> bit create react-component ui/button             # вариант 1
> bit create react-component button --namespace ui # вариант 2
```
Установить библиотеку для тестирования (если еще не установлена)
```cmd
> bit install @testing-library/react
```
Откомпилировать компоненты
```cmd
> bit compile
```
# 4.
