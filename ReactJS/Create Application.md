# Создание приложения
**Содержание**
* [С помощью npx](#с-помощью-npx)
* [С помощью Vite](#с-помощью-vite)
* Internet Explorer 11  

# С помощью CRA (устаревший способ)
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

# С помощью Vite
```cmd
> yarn create vite # создаем приложение
> cd vite-app-name # переходим в папку приложения
> yarn             # устанавливаем зависимости
> yarn dev         # запускаем приложение в режиме разработки
```

# Internet Explorer 11
1. Установить пакет **react-app-polyfill**
```cmd
> yarn add react-app-polyfill
```
2. В самое начало файла `src\index.js` или `src\index.tsx` добавить строчки:
```javascript
import 'react-app-polyfill/ie11';
import 'react-app-polyfill/stable';
```
3. В файле `package.json` в разделе **browserslist** добавить следующие строки:
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
