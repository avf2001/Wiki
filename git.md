Создание репозитория
```cmd
> git init
```
Конфигураций репозитория
```cmd
> git config user.name "UserName"
> git config user.email "User@mail.com"
> git config --list
```
working directory (modified) -> [git add] -> staging area (staged) -> [git commit] -> repository (commited)

git status

Отменить изменения в staging area для filename.txt
```cmd
> git reset filename.ext
```
Разница между working directory и staging area
```cmd
> git diff
```
History of commits
```cmd
> git log
> git log --pretty=oneline одна строчка на коммит
```
