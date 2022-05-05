# Сценарии
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
