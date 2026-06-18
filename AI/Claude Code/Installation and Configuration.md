- [Установка]()
- [Обновление]()
  - [npm](#npm)
- [Конфигурация]()
  - [Управления несколькими конфигурациями]()
- [Удаление]()
  - [npm]()

# Установка

# Обновление
## npm
```shell
sudo npm update -g @anthropic-ai/claude-code
```

# Конфигурация
## Управления несколькими конфигурациями
Claude Code не поддерживает несколько конфигураций моделей в одном файле. Для реализации этой возможности можно воспользоваться утилитой `claude-provider-switch`.

```shell
npm install -g claude-provider-switch

cps serve
```
Откроется браузер по адресу `http://localhost:8787`. С помощью веб-интерфейса можно создавать и редактировать конфигурации провайдеров, а также переключаться между ними.

# Удаление
## npm
```shell
npm uninstall -g @anthropic-ai/claude-code
rm -rf ~/.claude
sudo rm -f /usr/local/bin/claude
```
