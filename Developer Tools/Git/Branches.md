* Бранчи
  * Создание бранча
  * [Отображение списка бранчей](#отображение-списка-бранчей)
  * Переключение бранча
  * Просмотр разницы между двумя бранчами
  * [Удаление бранча](#удаление-бранча)
    * Удаление локального бранча
    * Удаление удаленного бранча 
  * Слияние двух бранчей  
# Бранчи
## Создание локального бранча
```cmd
> git branch branchname
> git checkout -b branchname # создание бранча и переключение на него
```
## Отображение списка бранчей
```cmd
> git branch    # локальные бранчи
> git branch -r # удаленные бранчи
> git branch -a # все бранчи
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
### Удаление локального бранча
```cmd
> git branch -D branchname                                # удаление бранча по имени
> git branch -- merged | grep -v \* | xargs git branch -D # удаление всех слитых бранчей
> git branch | grep -v \* | xargs git branch -D           # удаление всех бранчей
```
### Удаление удаленного бранча
```cmd
> git push origin -d branch-name
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
