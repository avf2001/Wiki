# Content
* [Useful Settings](#useful-settings)
* [Useful Extensions](#usefile-extensions)
  * [SQLite](#sqlite)
  * [ES7 React/Redux/React-Native/JS snippets](#es7-reactreduxreact-nativejs-snippets)
* [Hot Keys](#hot-keys)
* [User Snippets](#hot-keys)
# Useful Settings
```
File > Preferences > Settings
```
or
```
Ctrl + ,
```
* Editor: Format On Save = checked
* JavaScript > Fromat: Place Open Brace On New Line For Control Blocks = checked
* JavaScript > Fromat: Place Open Brace On New Line For Functions = checked
* TypeScript > Fromat: Place Open Brace On New Line For Control Blocks = checked
* TypeScript > Fromat: Place Open Brace On New Line For Functions = checked
# Usefile Extensions
* Live Server
* Auto Close Tag
* Auto Rename Tag
* Bracket Pair Colorizer 2
* C#
* C# Extensions
* Material Icon Theme
* NeGet Package Manager
* Prettier - Code formatter
* ident-rainbow
* Better Comments
* Blockman
## SQLite
https://marketplace.visualstudio.com/items?itemName=alexcvzz.vscode-sqlite  
VSCode extension to explore and query SQLite databases.
## ES7 React/Redux/React-Native/JS snippets
https://marketplace.visualstudio.com/items?itemName=dsznajder.es7-react-js-snippets  
Набор сниппетов для React. Примеры:
```
rafc - создание компонента React
```
# Hot Keys
* Format Document (Shift+Alt+F) - Format the entire active file.
* Alt + Set cursor - Multiple cursors
* Select text + F2 - Symbol rename
* Alt + Arrow up; Alt + Arrow down - Move lines up/down

# User Snippets
1. Generate configuration file
```
File > Preferences > User snippets
```
Select one of existing files or create new one

2. Write snippet
```json
"html5 autocomplete": {
  "prefix": "html5",
  "body": [
    "<!DOCTYPE html>",
    "<html lang=\"en\">",
    "<head>",
    "  <title></title>",
    "</head>",
    "<body>",
    "</body>",
    "</html>"
  ]
}
```
