- [Установка]()
- [Обновление]()
  - [npm](#npm)
- [Конфигурация]()
  - [Расположение файла конфигурации](#расположение-файла-конфигурации)
  - [LLama.cpp]()
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

## Расположение файла конфигурации
Windows:
```
%USERPROFILE%\.claude\settings.json
```

## LLama.cpp
```json
{
  "autoUpdatesChannel": "latest",
  "theme": "light",
  "autoCompactEnabled": false,
  "env": {
    "ANTHROPIC_BASE_URL": "http://127.0.0.1:9931",
    "ANTHROPIC_AUTH_TOKEN": "local-llama",
    "ANTHROPIC_API_KEY": ""
  },
  "model": "Qwen/Qwen2.5-Coder-7B-Instruct-GGUF:Q4_K_M"
}
```

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
