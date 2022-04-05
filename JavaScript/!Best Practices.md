1. Use object destructuring instead of parameters
```javascript
// https://blog.bitsrc.io/stop-using-function-parameters-now-d320cf0932df
// Typescript
interface GreetingParams {
  name: string;
}

function greet({ name }: GreetingParams) {
  return `Hello, ${name}`;
}

// Javascript
function greet({ name }) {
  return `Hello, ${name}`;
}

// Invocation
greet({ name: 'John' });
```
