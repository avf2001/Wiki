# Content
* [Useful Settings](#useful-settings)
* [Useful Extensions](#usefile-extensions)
  * [SQLite](#sqlite)
  * [ES7 React/Redux/React-Native/JS snippets](#es7-reactreduxreact-nativejs-snippets)
  * [Quokka.js](#quokkajs)
  * [Thunder Client](#thunder-client)
* [Hot Keys](#hot-keys)
* [User Snippets](#hot-keys)
# Install Offline on Ubuntu
1. Download rpm package from Microsoft site
2. Convert rpm package to deb package
```
# 1. Add Universe repository
$ sudo add-apt-repository universe
$ sudo apt-get update

# 2. Install Alien package
$ sudo apt-get install alien

# 3. Convert rpm package to deb package
$ sudo alien code-<...>.rpm
```
3. Install deb package
```
$ sudo dpkg -i <name of package>.deb
```
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
* [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
* [IntelliCode for C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscodeintellicode-csharp)
* Material Icon Theme
* NeGet Package Manager
* Prettier - Code formatter
* ident-rainbow
* Better Comments
* Blockman
* Prettier
* ESlint
* ES7 React/Redux/GraphQL/React-Native snippets
* JS JSX Snippets
## SQLite
https://marketplace.visualstudio.com/items?itemName=alexcvzz.vscode-sqlite  
VSCode extension to explore and query SQLite databases.
## ES7 React/Redux/React-Native/JS snippets
https://marketplace.visualstudio.com/items?itemName=dsznajder.es7-react-js-snippets  
Набор сниппетов для React. Примеры:
```
rafc - создание компонента React
```
## Quokka.js
Quokka.js is a developer productivity tool for rapid JavaScript / TypeScript prototyping. Runtime values are updated and displayed in your IDE next to your code, as you type.
## Thunder Client
Thunder Client is a lightweight Rest API Client Extension for Visual Studio Code.
# Hot Keys
* Format Document (`Shift` + `Alt` + `F`) - Format the entire active file.
* `Alt` + Set cursor - Multiple cursors
* Select text + `F2` - Symbol rename
* `Alt` + `Arrow up`; `Alt` + `Arrow down` - Move lines up/down
* `Ctrl` + `W` - close tab
* `Ctrl` + `K` - comment line

## Navigation
| Hotkeys | Are |
|----------|:-------------:|
| `Ctrl` + `Shift` + `E` | Switch to Explorer |
## Tabs

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
# Tips and Tricks
## Using Timeline
## Using Auto Save
```
 File > Auto Save
```
## Using Command Palette
```
Ctrl + Shift + P
```
## Navigate Through Files
```
Ctrl + P                # search for and open a specific file in your project
Ctrl + Tab              # to cycle through the list of files currently open in an editor instance
Alt + Left, Alt + Right # to quickly navigate between these open files
```
## Go to Line Quickly
```
Ctrl + G
```
## Using Smooth Cursor
```
File > Preferences > Settings > Text Editor > Cursor > Cursor Smooth Caret Animation
```
## Multi-Cursor Editing
```
Alt + Click
Ctrl + Alt + Down, Ctrl + Alt + Up # add a cursor directly above or below the current line
```
