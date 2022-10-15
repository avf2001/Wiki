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
> git checkout - # переключение между двумя бранчами попеременно
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
> git add . # добавление всех файлов из текущей директории, не включенных в .gitignore
> git add --all # добавление всех измененный файлов из текущей директории и поддерикторий, не включенных в .gitignore
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
