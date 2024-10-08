# Сценарии
* [Добавление измененных файлов в завершенный коммит](#добавление-измененных-файлов-в-завершенный-коммит)
* [Удаление файла из коммита]()
* [Переименование коммита]()
* [Поиск коммита с ошибкой]()
* [Просмотр имен измененных файлов между двумя бранчами]()
* [Просмотр списка коммитов, в которых был измемен определенный файл]()
* [Отмена локальных изменений](#отмена-локальных-изменений)
* [Слияние бранча]()
* [Объединение нескольких последовательных коммитов в один]()
* [Отмена коммита в бранче и перенос изменений в другой бранч]()
## Добавление измененных файлов в завершенный коммит
```cmd
> git commit --amend --no-edit
```
## Удаление файла из коммита
Выполнить команду:
```cmd
> git reset --soft HEAD^
```
Это откатит закоммиченные файлы в staging area. Далее можно удалить необходимый файл:
```cmd
> git reset HEAD <filename>
```
## Переименование коммита
```cmd
> git commit --amend -m "Новый текст коммита"
```
## Поиск коммита с ошибкой
Have you been in a situation when a bug was introduced and you had to search when and what exactly was changed for this bug to appear? If you knew this command then, this process would be faster and easier. Using git bisect we can search for a commit which creates the bug, by first telling it a “bad” commit which has the bug and a “good” commit where it wasn’t there.
```cmd
> git bisect start
> git bisect bad
> git bisect good v.11.0.1-rc2
```
When we are done we should use git bisect reset to clean up the state and return to the original HEAD.
```cmd
> git bisect reset
```
## Просмотр имен измененных файлов между двумя бранчами
```cmd
> git diff <branch1> <branch2> --name-only
> git diff master --name-only
```
## Просмотр списка коммитов, в которых был измемен определенный файл
```cmd
> git log --follow -- build/build.ps1
```
## Отмена локальных изменений
There are different ways to remove local changes depending the scenario you have.  
If you want to revert the changes to your working copy use:
```cmd
> git restore .
```
If you want to remove all unpushed commits to master use:
```cmd
> git reset
```
If you want to revert a change by a commit use:
```cmd
> git revert <commit>
```
If you want to remove untracked files or directories or use:
```cmd
> git clean -f
> git clean -fd
```
## Слияние бранча
```cmd
> git checkout master     # 1. Переключаемся на ветку master
> git fetch               # 2. Синхронизируем с удаленным сервером
> git pull
> git merge BRANCH_NAME   # 3. Производим слияние
> git push                # 4. Отправляем изменения на сервер
```

## Объединение нескольких последовательных коммитов в один
```cmd
> git rebase -i HEAD~3

pick f392171 Added new feature X
squash ba9dd9a Added new elements to page design
squash df71a27 Updated CSS for new elements
```

## Отмена коммита в бранче и перенос изменений в другой бранч
```
# current branch main
> git reset HEAD~1                 # reset commit
> git checkout -b required-branch  # create and checkout new branch
> git add -A                       # stage all changes
> git commit -m "Commit message"   # commit all changes
```
