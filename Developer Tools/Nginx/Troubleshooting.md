# Просмотр логов
```shell
tail -f /var/log/nginx/error.log
```

## Сценарий: сервер возвращает ошибку 502
Условия: nginx является reverse proxy для ASP.NET приложения в контейнере docker.

Скорее всего ASP.NET приложение выбрасывает исключение и возвращает ошибку 500.

1. Посмотреть логи контейнер ASP.NET приложения:
```shell
docker logs <CONTAINER_NAME>
```
