# JavaScript Promises and Async Programming
```javascript
let xhr = new XMLHttpRequest();
let statuses = [];
xhr.open("http://...");
xhr.onload = () => {
  statuses = JSON.parse(xhr.responseText);
}

xhr.send();
```
Axios - Promise based HTTP client for the browser and node.js.  
https://github.com/axios/axios

States of promise:
- pending
- fullfield
- rejected
## Chaining promises
Promises return promises  
```javascript
axios.get("...").then(({data})) => {  // get 1
  return axious.get("...");           // get2
})
.then(({data}) => {
  // process get 2 result
});
```
Showing loading indicator.
```javascript
{
  showWaiting();

  axious
    .get("")
    .then()
    .then()
    .catch()
    .finally(() => {
      setTimeout(() => {
        hideWaitnig();
      }, 1500);      
    });
}
```
## Creating and queueing promises
```javascript
{
  const wait = new Promise((resolve) => {
    setTimeout(() => {
      resolve("Timeout!");
    }, 1500);
  });

  wait.then(text => setText(text));
}
```
```javascript
{
  let request = new Promise((resolve) => {
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "http://...");
    xhr.onload = () => resolve(xhr.responseText);
    xhr.send();
  });
}
```

```javascript
const promise1 = new Promise((resolve, reject) => {
    console.log('begin' + '\r');

    setTimeout(() => {
      resolve('promise1');
    }, 1000);
  });

let promise = (text) => {
  return new Promise((resolve, reject) => {
    setTimeout(() => resolve(text), 1000);
  });
}
  
promise1
  .then((value) => {
    console.log(value + '\r');    

    return new Promise((resolve, reject) => {
      setTimeout(() => resolve('promise2'), 1000);
    });
  })
  .then((value) => {
    console.log(value + '\r');

    return new Promise((resolve, reject) => {
      setTimeout(() => resolve('promise3'), 1000);
    });
  })
  .then((value) => {
    console.log(value + '\r');

    return new Promise((resolve, reject) => {
      setTimeout(() => resolve('promise4'), 1000);
    });    
  })
  .then((value) => {
    console.log(value + '\r');

    return new Promise((resolve, reject) => {
      setTimeout(() => resolve('promise5'), 1000);
    });    
  })
  .then((value) => {
    console.log(value + '\r');

    console.log('end');
  })
;
```
