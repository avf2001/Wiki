1. `appsettings.json`
```json
{
    "ConnectionStrings": {
        "connection": "Server=(localdb);..."
    }
}
```
2. `Startup.cs`
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<AppDbContext>(Options => options.UseSqlServer(Configuration.GetConnectionString("connection")));
}
```
