# Создание
```
git worktree add ./path/to/worktree branch-name
```

# Удаление
```
git worktree list
git worktree remove ./path/to/worktree
```

# Создание бранча
Допустим есть структура:
```
/
  /development
  /master
```
Необходимо создать бранч-наследник от development. Переходим в папку `master` и пишем:
```shell
git worktree add ../dev-ticket123 -b ticket123 development
```
