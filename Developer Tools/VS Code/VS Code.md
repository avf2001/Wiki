# Content
* [Useful Settings](#useful-settings)
* [Useful Extensions](#usefile-extensions)
  * [SQLite](#sqlite)
  * [ES7 React/Redux/React-Native/JS snippets](#es7-reactreduxreact-nativejs-snippets)
  * [Quokka.js](#quokkajs)
  * [Thunder Client](#thunder-client)
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
## Using Smooth Cursor
```
File > Preferences > Settings > Text Editor > Cursor > Cursor Smooth Caret Animation
```
## Multi-Cursor Editing
```
Alt + Click
Ctrl + Alt + Down, Ctrl + Alt + Up # add a cursor directly above or below the current line
```
