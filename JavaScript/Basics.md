- [Primitive Types](#primitive-types)
  - [Number](#number)
  - [String](#string)
  - [Boolean](#boolean)
- [Variables](#variables)

# Primitive Types
- Number
- String
- Boolean
- Null
- Undefined

## Number
Возведение в степень: 2 ** 3 = 8

NaN - Not a Number
```javascript
0/0 //NaN
1/0 // Infinity
-1/0 // -Infinity
-0 // -0
1 + NaN // NaN
```
## String
```javascript
let string1 = "string1";
let string2 = 'string2';
let stringWithQuote = "This string contains \"quote\" inside";
```
Strings are zero-based indexed. 
```javascript
"hello".length // 5
"hello"[0] // "h"
"hello"[5] // undefined
```
String escapes
```
\n - new line
\' - single quote
\" - double quote
\\ - baclslash
```
Strings are immutable.
### String methods
```javascript
string.toUpperCase();
string.toLowrCase();
string.indexOf(substring);
```
### String template literals
```javascript
`I counted ${3 + 4} sheep`;
```
MDN link: https://developer.mozilla.org/ru/docs/Web/JavaScript/Reference/template_strings
## Boolean
Falsy values:
- false
- 0
- "" (empty string)
- null
- undefined
- NaN
Everything elese is truthy.
## Null
## Undefined
# Variables
```javascript
let someName = value;
const age = 17;
var tripDistance = 7.4; // Old way, obsolete
```
Variables can change type:
```javascript
let numDonuts = 12;
numDonuts = false;
numDonuts = 2736401238561;
```
