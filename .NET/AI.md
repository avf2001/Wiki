# AI

## Foundry Local
Это инструмент для разработчиков, который позволяет быстро добавить в приложение локальный AI-инференс с приоритетом приватности, офлайн-работы и поддержки разного железа (NPU/GPU/CPU), не полагаясь на облачные API.

[Site](https://www.foundrylocal.ai/)

### Запуск
```shell
foundry server status     # получение статуса работы сервера
foundry server logs       # отображение логов работы сервера
```

### Работа с OpenWebUI
```shell
docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data -e WEBUI_SECRET_KEY=your-secret-key --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```
