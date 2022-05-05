# Сценарии
* Перенос локальных изменений (modified) в новый бранч
* Добавление измененных файлов в завершенный коммит
* Удаление файла из коммита
* Поиск коммита с ошибкой
* Просмотр имен измененных файлов между двумя бранчами
* Просмотр списка коммитов, в которых был измемен определенный файл
* Отмена локальных изменений
## Перенос локальных изменений (modified) в новый бранч
```cmd
> git stash                     # 1. Сохраняем локальные изменения в stash
> git reset --hard              # 2. Очищаем изменения в текущем бранче
> git checkout -b NewBranchName # 3. Создаем новый бранч и переключаемся на него
> git stash pop                 # 4. Восстанавливаем локальные изменения из stash
```
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
> git clean -f or git clean -fd
```
