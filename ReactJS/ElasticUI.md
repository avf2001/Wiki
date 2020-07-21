1. Создать приложение React
2. Установить дополнительные пакеты:
```cmd
yarn add @elastic/eui @elastic/datemath moment
```
3. Файл **index.js**:
```javascript
index.js:
import 'react-app-polyfill/ie11';
import 'react-app-polyfill/stable'
import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import {
  EuiFlexGroup,
  EuiFlexItem,
  EuiFormRow,
  EuiButton,
  EuiFieldText,
} from '@elastic/eui';
import '@elastic/eui/dist/eui_theme_light.css';

ReactDOM.render(<Form />, document.getElementById('root'));

function Form () {
  return (
      <EuiFlexGroup style={{ maxWidth: 600 }}>
          <EuiFlexItem>
          <EuiFormRow label="First name" helpText="I am helpful help text!">
              <EuiFieldText />
          </EuiFormRow>
          </EuiFlexItem>
          <EuiFlexItem>
          <EuiFormRow label="Last name">
              <EuiFieldText />
          </EuiFormRow>
          </EuiFlexItem>
          <EuiFlexItem grow={false}>
          <EuiFormRow hasEmptyLabelSpace>
              <EuiButton>Save</EuiButton>
          </EuiFormRow>
          </EuiFlexItem>
      </EuiFlexGroup>
  );
}
```
4. Запустить приложение:
```cmd
yarn start
```
