# Именование коммитов
## Описание ключевых слов 
* `fix` - исправление бага
* `feat` - новая фича
* `build` - изменения в процессе сборки
* `chore` - другие изменения, которые не качаются исходных файлов или тестов
* `ci` - изменения в Continuous Integration
* `docs` - изменения в документации
* `perf` - изменения, касающиеся производительности
* `refactor` - рефакторинг
* `revert` - откат к предыдущему коммиту
* `style` - изменения в форматировании кода
* `test` - изменения в тестах
## Дополнительные опции
* добавление дополнительной информации:
```
feat(SBPTLWB-418): New feature
// or
SBPTLWB-418(feat): New feature
```
```
fix(parser): fixed parser error
```
* указание важности
```
refactor!: drop support for Node 6
```
## Дополнительная информация
* [How to Write a Git Commit Message](https://chris.beams.io/posts/git-commit/)
* [Conventional Commits](https://www.conventionalcommits.org)
