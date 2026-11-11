# Рекомендации по использования Claude Code:

- Количество строк в файле CLAUDE.md не более 200
- Дополнительны требования в папке .claude/rules/ в соответствующей папке
- Файл AGENTS.md - открытый формат, который понимается многоми агентами
Рекомендуется:
CLAUDE.md
```
@AGENTS.md

# Project: Payment Platform

## What this repo is

## Build and test commands
- Build: `dotnet build src/Solution.slnx`
- Test: `dotnet test src/Solution.slnx --no-build --logger trx`
- Lint: `dotnet format --verify-no-changes`
- Always run tests before considering a task complete

## Architecture

## Conventions

## Workflow
- Use plan mode for any change touching src/Domain
- Prefer record types for value objects

## Do Not

```

- Запускать /code-review перед git merge. Запускать /code-review utltra (или /ultrareview) для проверки безопасности

- Сжатие контекстного окна: `/compact focus on the payment retry bug`

- Желательно добавлять README.md файл в каждый проект. Это помогает агенту
