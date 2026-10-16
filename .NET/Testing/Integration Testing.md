# Интеграционное тестирование

Тестовый проект должен:
- Использовать библиотеку `Microsoft.AspNetCore.Mvc.Testing`
- Использовать `<Project Sdk="Microsoft.NET.Sdk.Web">` в файле проекта

В файле `Program.cs` тестируемого проекта необходимо добавить строку:
```csharp
public partial class Program { }
```

Пример класса тестирования:
```csharp
public class SampleTests : WebApplicationFactory<Program>, IAsyncLifetime
{
    public SampleTests()
    {
    }

    public async Task InitializeAsync()
    {
    }
}
```
