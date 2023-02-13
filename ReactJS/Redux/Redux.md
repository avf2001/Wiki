store.tsx
import { configureStore } from "@reduxjs/toolkit";

export default configureStore({
    reducer: {},
});

indexed.tsx
import { Provider } from 'react-redux';
import store from './app/store';


// ...
  <Provider store={store}>
    <App />
  </Provider>
// ...
