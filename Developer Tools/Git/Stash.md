**stash** - сохранение локальных изменений.
## Сохранение локальных изменений
```cmd
> git stash # простое сохранение изменений
> git stash --include-untracked #
> git stash -u # аналогично --include-untracked
> git stash --all
> git stash push # аналогично git stash
> git stash push --message "Какое-нибудь сообщение"
> git stash save # deprecated
```
```cmd
> git stash list # получить список локальных изменений
```
# Сценарии
## Перенос локальных изменений (modified) в новый бранч
```cmd
> git stash -u                  # 1. Сохраняем локальные изменения в stash
> git reset --hard              # 2. Очищаем изменения в текущем бранче
> git checkout -b NewBranchName # 3. Создаем новый бранч и переключаемся на него
> git stash pop                 # 4. Восстанавливаем локальные изменения из stash
```
