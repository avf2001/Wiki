# Установка
```cmd
npm install react-router-dom
```
# Использование в приложении
```javascript
// index.js

import { BrowserRouter } from 'react-router-dom';
import React from 'react';

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
import './App.css';
import Navbar from './components/Navbar';
import { Switch, Route } from 'react-router-dom';

function App() {
  return (  
    <div>
      <Navbar />
      <Switch>
        <Route path="/" exact>
          <Home />
        </Route>
        <Route path="/about" component={AboutView} />        
      <Switch>
    </div>
  );
}
```
```javascript
// Navbar.js
import { Link } from 'react-router-dom';

...
<Link to="/" />
...
<Link to="/about">About</Link>
...
```
