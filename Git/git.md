# Содержание
* [Репозиторий](#репозиторий)
  * [Создание репозитория](#создание-репозитория)
  * [Настройка репозитория](#настройка-репозитория)
  * Клонирование репозитория
  * [Статус репозитория](#статус-репозитория)
  * [История коммитов](#история-коммитов)
  * [Импорт из SVN (Subversion)](#импорт-из-svn-subversion)
* [Бранчи](#бранчи)
  * [Создание бранча](#создание-бранча)
  * Отображение списка бранчей
  * Переключение бранча
  * Просмотр разницы между двумя бранчами
  * [Удаление бранча](#удаление-бранча)
* [Файлы](#файлы)
  * [Добавление нового файла](#добавление-нового-файла)
  * Удаление файла
  * Восстановление последних удаленных файлов (откат репозитория)
  * Переименование файла
  * Слияние двух бранчей
* [Stash](#stash)
  * [Создание](#создание)
  * Получение списка
  * Получение содержимого
  * Возврат к изменениям
  * Очистка
  * Создание нового бранча из stash
* [Сценарии](#сценарии)
  * [Перенос локальных изменений (modified) в новый бранч](#перенос-локальных-изменений-modified-в-новый-бранч)
  * [Добавление измененных файлов в завершенный коммит](#добавление-измененных-файлов-в-завершенный-коммит)
* [Именование коммитов](#именование-коммитов)
  * [Описание ключевых слов](#описание-ключевых-слов)
  * [Дополнительные опции](#дополнительные-опции)
  * [Дополнительная информация](#дополнительная-информация)

# Репозиторий
## Создание репозитория
```cmd
> git init
```
## Настройка репозитория
Локальная настройка для одного репозитория
```cmd
> git config --list # получить значения всех локальных параметров
> git config user.name "UserName"
> git config user.email "User@mail.com"
```
Глобальная настройка для всех репозиториев
```cmd
> git config --global --list # получить значения всех глобальных параметров
> git config --global core.editor # получить значение параметра
> git config --global core.editor "'c:/program files/tortoisegit/bin/notepad2.exe'" # Установить Notepad2 как редактор по умолчанию
> git config --global core.editor "code --wait" # Установить VS Code как редактор по умолчанию
```
## Клонирование репозитория
```cmd
> git clone git@bitbucket.com:owner/opensource.git
```
working directory (modified) -> [git add] -> staging area (staged) -> [git commit] -> repository (commited)
## Статус репозитория
```cmd
> git status
```
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

# В одну строчку в формате "хеш, автор, дата, сообщение"
> git log --pretty=format:"%h  %an  %ad  %s" --date=short

> git log --graph # графическая визаулизация коммитов; q - выход, h - справка
> git log --graph --all
> git --no-pager log --oneline -n 10 # без постраничной разбивки, в одну строку, последние 10 записей
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
## Импорт из SVN (Subversion)
```cmd
> git.exe svn clone "svn://server/path/SvnRepo" "C:\Users\username\projects\Destination.git" -T trunk -b branches -t tags
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
## Получение содержимого
```
$ git stash show stash@{1}
```
## Возврат к изменениям
```
$ git stash apply stash@{3}
$ git checkout stash@{0} css/alternative.css # Возврат к изменениям выбранных файлов
```
## Очистка
Команда apply не удаляет stash из списка. Для удаления необходимо выполнить:
``` bash
$ git stash pop
$ git stash drop <name>
$ git stash clear # полное удаление
```
## Создание нового бранча из stash
```bash
$ git stash branch <name>
```
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