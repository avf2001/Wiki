- [Project Structure]()
- [Project Settings]()
- [Logging]()
- [ASP.NET]()
  - [FallbackPolicy]()
  - [Remove the Server Header]()
- [Libraries]()
- [Other]()
- [Structuring Method]()
- [Testing]()
- [Use Central Package management]()
- [Configuration]()

# Project Structure
1. Use feature folders

# Project Settings
3. Treat warnings as errors

**`.csproj`** file
```xml
<PropertyGroup>
  <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
</PropertyGroup>
```

# Logging
## Use Serilog as logging framework
  - Use `ILogger` everywhere, not Serilog directly
  - Use structured logging
## View Entity Framework Queries
Switch log level of Microsoft.EntityFrameworkCore.Database.Command to information. Do this only for local development.
```json
{
    "Logging": {
        "LogLevel": {
            "Microsoft.EntityFrameworkCore.Database.Command": "Information"
        }
    }
}
```

# ASP.NET
## FallbackPolicy
AuthorizationOptions.FallbackPolicy в ASP.NET Core представляет собой глобальную политику авторизации, применяемую ко всем запросам, для которых не указана явная политика. Эта настройка определяет поведение по умолчанию для случаев, когда никакой конкретной политики авторизации не задано.

По сути, это резервная стратегия защиты ресурсов, обеспечивающая дополнительную безопасность, если разработчик забыл добавить явную политику авторизации. Когда система встречает запрос, не защищённый никакими правилами (AllowAnonymous, [Authorize(Policy="some-policy")]), именно эта политика вступает в силу.

Основная задача этой политики заключается в обеспечении базовой защиты ресурса, предотвращающей случайное раскрытие конфиденциальных данных. Даже если разработчик забудет установить явную защиту на какой-то endpoint, этот ресурс всё равно будет закрыт благодаря наличию FallbackPolicy.

Например, представьте ситуацию, когда случайно забыта защита маршрута в приложении. Без использования FallbackPolicy доступ к этому маршруту могли бы получить посторонние лица. Но если FallbackPolicy установлен правильно, незащищённые маршруты автоматически будут защищены минимальной политикой авторизации.
```csharp
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});
```
Эта конфигурация означает, что все запросы, не защищенные специально установленными политиками, будут требовать аутентифицированного пользователя. То есть любые незакрытые явными настройками endpoints будут закрыты защитой по умолчанию.

Помимо резервной политики, существуют стандартные механизмы авторизации, включая AllowAnonymous, конкретные политики и роли. Однако наличие FallbackPolicy добавляет дополнительный уровень контроля над правами доступа.

## Remove the Server Header
By default ASP.NET Core adds a Server Header "Kestrel".
```csharp
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
```

# Libraries
- FluentValidation

# Other
## Don't use IOptions
Solution:
```csharp
services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
services.AddSingleton(registeredServices => registeredServices.GetRequiredService<IOptions<AppSettings>>().Value);

// To use IOptionSnapshot register as scoped

public class WeatherForecastController(AppSettings appSettings)
{
    ...
}
```
## ValidateOnBuild
```csharp
builder.Host.UseDefaultServiceProvider(config =>
{
    config.ValidateOnBuild = true;
});
```

# Structuring Method
* Happy Path always at the Bottom of the Method
* Use returns instead of nested if-else

# Testing
Use xUnit

# Use Central Package management
Create Directory.Packages.props at the root and define packages and versions here.

# Configuration
- Use `GetRequiredSection` instead of `GetSection`.
- Validate options configuration with attributes
- Use:
```csharp
services
  .AddOptions<ApiSettings>()
  .BindConfiguration(nameof(ApiSettings))
  .ValidateDataAnnotations()
  .ValidateOnStart();
```
- Different kinds of Options:
  - IOptions - Simgleton, read once
  - IOptionsSnapshot - Scoped, read every scope, useful with web requests, keep performance in mind
  - IOptionsMonitor - singleton, read in real-time, uses change notifications, useful with background services

## In development
```csharp
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:Database" "Data Source=..."
dotnet user-secrets set "AdminPassword" "hunter2"
```
```
# Windows
%APPDATA%/Microsoft/UserSecrets/SECRETS_ID/secrets.json

# Linux
~/.microsoft/usersecrets/SECRETS_ID/secrets.json
```
## In production
Use parameters (connection string) as environment variables (for docker)
```yaml
services:
  dotnetapi:
    image:...
    environment:
      - ConnectionStrings__Database="SomeValue"
      - ApiKey="SomeValue"
```
