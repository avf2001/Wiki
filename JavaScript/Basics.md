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
Strings are immutable.
### String methods
```javascript
string.toUpperCase();
string.toLowrCase();
```
## Boolean
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
