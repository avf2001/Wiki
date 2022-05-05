# Работа с историей коммитов
```cmd
> git log
> git log --pretty=oneline # одна строчка на коммит

# В одну строчку в формате "хеш, автор, дата, сообщение"
> git log --pretty=format:"%h  %an  %ad  %s" --date=short

> git --no-pager log --oneline -n 10 # без постраничной разбивки, в одну строку, последние 10 записей
```
## Просмотр истории коммитов в виде графа
q - выход, h - справка
```cmd
> git log --graph
> git log --graph --all
> git log --graph --all --decorate --oneline
```
