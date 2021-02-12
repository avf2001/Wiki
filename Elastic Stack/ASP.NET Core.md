# Content
* Using with ASP.NET Core (3.1 example)
* Adding UserName to log
* Logging unhandled exceptions
# Using with ASP.NET Core (3.1 example)
## 1. Install nuget packages
```cmd
> install-package Serilog.AspNetCore
> install-package Serilog.Enrichers.Environment
> install-package Serilog.Sinks.Elasticsearch
```
## 2. appsettings.config
```json
{
    "Serilog": {
        "MinimumLevel": {
            "Default": "Information",
            "Override": {
                "Microsoft": "Information",
                "System": "Warning"
            }
        }
    },
    "ElasticConfiguration": {
        "Uri": "http://elastic1.server.name.com:9200/"
    },
    "AllowedHosts": "*"
}
```
## 3. Program.cs
```csharp
// Добавить
using Serilog;
using Serilog.Sinks.Elasticsearch;

...

public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .UseSerilog((context, configuration) =>
        {
            var elasticsearchSinkOptions = new ElasticsearchSinkOptions(new Uri(context.Configuration["ElasticConfiguration:Uri"]))
            {
                IndexFormat =
                    $"{context.Configuration["ApplicationName"].ToLower()}-logs-{context.HostingEnvironment.EnvironmentName?.ToLower().Replace(".", "-")}-{DateTime.UtcNow:yyyy-MM}",
                AutoRegisterTemplate = true,
                NumberOfShards = 2,
                NumberOfReplicas = 1
            };

            configuration.Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .WriteTo.Console()
                .WriteTo.Elasticsearch(elasticsearchSinkOptions)
                .Enrich.WithProperty("Environment", context.HostingEnvironment.EnvironmentName)
                .ReadFrom.Configuration(context.Configuration);
        }).ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
```
# Adding UserName to log

```csharp
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Serilog.Context;

namespace Skz.ReportForms.Internal.WebApiCore.Middleware
{
    public class LogUserNameMiddleware
    {
        private readonly RequestDelegate _next;

        public LogUserNameMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public Task Invoke(HttpContext context)
        {
            LogContext.PushProperty("UserName", context.User.Identity.Name);

            return _next(context);
        }
    }
}
```
```csharp
/* Program.cs */
.UseSerilog((context, configuration) =>
{
    configuration
        ...
        .Enrich.FromLogContext()
        ...
})
```
```csharp
/* Startup.cs */
app.UseAuthentication();     

// After UseAuthentication or Authorization
app.UseMiddleware<LogUserNameMiddleware>();
```
# Logging unhandled exceptions
```csharp
/* UnhandledExceptionMiddleware */
public class UnhandledExceptionMiddleware
{
    private readonly ILogger _logger;
    private readonly RequestDelegate _next;

    public UnhandledExceptionMiddleware(ILogger<UnhandledExceptionMiddleware> logger, RequestDelegate next)
    {
        this._logger = logger;
        this._next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, $"Request {context.Request?.Method}: {context.Request?.Path.Value} failed");
        }
    }
}
```
```csharp
/* Startup.cs */
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    // After app.UseDeveloperExceptionPage();
    app.UseMiddleware<UnhandledExceptionMiddleware>();
    
    ...    
}
```
