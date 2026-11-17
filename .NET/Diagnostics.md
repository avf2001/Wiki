# Диагностика
- [Инструменты](#инструменты)
  - [dotnet-counters](#dotnet-counters)
- [Сценарии](#сценарии)
  - [Медленные HTTP соединения](#медленные-http-соединения)
  - [Entity Framework](#entity-framework)

## Инструменты

### dotnet-counters
```shell
dotnet-counters ps
```

## Сценарии

### Медленные HTTP соединения
```shell
dotnet-counters monitor --counters System.Net.Http --process-id <PID>
```

### Entity Framework
```shell
dotnet-counters monitor --counters Microsoft.EntityFrameworkCore --process-is <PID>
```
