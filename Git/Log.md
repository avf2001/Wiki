# Работа с историей коммитов
```cmd
> git log
> git log --pretty=oneline # одна строчка на коммит

# В одну строчку в формате "хеш, автор, дата, сообщение"
> git log --pretty=format:"%h  %an  %ad  %s" --date=short

> git log --graph # графическая визаулизация коммитов; q - выход, h - справка
> git log --graph --all
> git --no-pager log --oneline -n 10 # без постраничной разбивки, в одну строку, последние 10 записей
```
