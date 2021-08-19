# Выполнение асинхронного запроса
```javascript
const loadData = async () => {
	try {
		const url = 'http://website.com';
	
		const result = await fetch(url);	
		
		console.log(result.ok); // check result 
		// or
		// console.log(result.status);
	
		const data = await result.json();
		
		return data;
	} catch (err) {
		console.error(err);
	}	
}

const data = await loadData();

console.log(data);

// or
loadData().then(data => console.log(data));

// or
(
async () => {
	const data = await loadData();
	console.log(data);
}
)();
```
## Параллельное выполнение нескольких асинхронных запросов
```javascript
const loadData = async () => {
	try {
		const url1 = 'http://website.com/item/1';
		const url2 = 'http://website.com/item/2';
		const url3 = 'http://website.com/item/3';
	
		const results = await Promise.all([fetch(url1), fetch(url2), fetch(url3)]);
		
		const dataPromises = results.map(result => result.json());
		const finalData = await Promise.all(dataPromises);		
		return finalData;
	} catch (err) {
		console.error(err);
  }	
}

const data = await loadData();
```
