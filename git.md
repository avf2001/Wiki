# Содержание
* Репозиторий
  * Создание репозитория
  * Настройка репозитория
  * Клонирование репозитория
* Файлы
  * Добавление нового файла
  * Удаление файла
  * Восстановление последних удаленных файлов (откат репозитория)
  * Переименование файла
* Stash
  * Создание
  * Получение списка

# Репозиторий
## Создание репозитория
```cmd
> git init
```
## Настройка репозитория
```cmd
> git config user.name "UserName"
> git config user.email "User@mail.com"
> git config --list
> git config --global core.editor "'c:/program files/tortoisegit/bin/notepad2.exe'" # Установить Notepad2 как редактор по умолчанию
```
## Клонирование репозитория
```cmd
> git clone git@bitbucket.com:owner/opensource.git
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
## История коммитов
```cmd
> git log
> git log --pretty=oneline # одна строчка на коммит
> git log --graph # графическая визаулизация коммитов
```
Изменить текст коммита
```cmd
> git commit --amend
```
Откатить изменения на 1 коммит назад и сохранить измененнные файлы
```cmd
> git reset --soft HEAD`1
```
Откатить изменения на 1 коммит назад и удалить измененнные файлы
```cmd
> git reset --hard HEAD`1
```
# Бранчи
## Создание бранча
```cmd
> git branch branchname
```
## Отображение списка бранчей
```cmd
> git branch
```
## Переключение бранча
```cmd
> git checkout branchname
```
## Просмотр разницы между двумя бранчами
```cmd
> git diff branchname1 branchname2
```
## Удаление бранча
```cmd
> git branch -D branchname
```
## Слияние двух бранчей
```cmd
# Сначало необходимо переключиться на бранч, который будет принимать изменения.
> git checkout master
> git merge branchname
```
# Файлы
## Добавление нового файла
```cmd
> git add .
```
## Удаление файла
`git rm` удаляет файл из индекса и рабочего каталога (файл не отслеживатеся)
```cmd
> git rm filename.ext
> git commit -m "File filename.ext deleted"
```
## Восстановление последних удаленных файлов (откат репозитория)
```cmd
> git reset --hard HEAD~1
```
## Переименование файла
```cmd
> git mv filename.ext filename-new.ext
> git commit -m "File rename"
```
# Stash
## Создание
```
$ git stash                                           # добавление всех файлов
$ git stash push -m “Working on a new layout”         # добавление всех файлов и установка комментария
$ git stash push -m "modifies the CSS" css/agency.css # добавление обного файла и установка комментария
```
## Получение списка
```
$ git stash list
```
