# Установка
```cmd
npm install react-router-dom
```
# Использование в приложении
```javascript
// index.js

import { BrowserRouter } from 'react-router-dom';

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter>  
      <App />
    </BrowserRouter>
  </React.StrictMode>,
  document.getElementById('root')
);
```
```javascript
// App.js

function App() {
  return (
    <div>
      <Navbar />
      <Home />
      <AboutView />
    </div>
  );
}
```
