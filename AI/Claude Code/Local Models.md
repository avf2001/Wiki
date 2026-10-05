# Использование локальных моделей
## Ollama
### Посмотреть список доступных моделей
```http
http://localhost:11434/api/tags
```
```shell
ollama list
```
```shell
ollama launch claude --model qwen3-coder
```

**`.claude\settings.json`** file for ollama
```json
{  
  "env": {
    "ANTHROPIC_BASE_URL": "http://localhost:11434",
    "ANTHROPIC_AUTH_TOKEN": "ollama",
    "ANTHROPIC_API_KEY": ""
  },
  "model": "qwen2.5:7b"
}
```
