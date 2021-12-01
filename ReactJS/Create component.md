# 1. Create library project
```cmd
> npx tsdx create <library-name>
```
Choose a template ... = react
```cmd
> cd <library-name>
> npm install
```
Edit package.json file. Change name setting:
```json
"name: "@scope-name/library-name"
```
# 2. Add Storybook
```cmd
> npx sb init
```
# 3. Publish library
View npm setting and check scope settings.
```cmd
> npm view
```
or get registry for the scope.
```cmd
> npm config get @scope-name:registry
```
If scope does not exist set it.
```cmd
> npm config set @scope-name:registry http://reg.example.com
```
Login into the scope.
```cmd
> npm login @scope-name
```
Publish project
