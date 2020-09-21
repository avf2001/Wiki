# Создание приложения
1. Создать приложение
```cmd
> npx create-react-app client-app --template typescript
```
2. Перейти в папку приложения
```cmd
> cd client-app
```
3. Добавить библиотеки
```cmd
> yarn add typescript @types/react @types/react-dom
```
## Internet Explorer 11
1. Установить пакет **react-app-polyfill**
```cmd
> yarn add react-app-polyfill
```
2. В самое начало файла **index.js** добавить строчки:
```javascript
import 'react-app-polyfill/ie11';
import 'react-app-polyfill/stable';
```
3. В файле **package.json** в разделе **browserslist** добавить следующие строки:
```json
"browserslist": {
  "production": [
    "ie 11",
    ...
  ],
  "development": [
    "ie 11",
    ...
  ]
}
```
4. Удалить папку **node_modules/.cache**.
5. Запустить приложение.
```cmd
> yarn start
```
