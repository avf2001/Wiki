store.tsx
```javascript
import { configureStore } from "@reduxjs/toolkit";

export default configureStore({
    reducer: {},
});
```
index.tsx
```javascript
import { Provider } from 'react-redux';
import store from './app/store';


// ...
  <Provider store={store}>
    <App />
  </Provider>
// ...
```
