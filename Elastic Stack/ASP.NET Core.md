# 1. Install nuget packages
```cmd
> install-package Serilog.AspNetCore
> install-package Serilog.Enrichers.Environment
> install-package Serilog.Sinks.Elasticsearch
```
# 2. appsettings.config
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
# 3. Program.cs
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
