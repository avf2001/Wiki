# ASP.NET Core health checks
* Initial setup
* Configuring database dependency health checks

Based on https://app.pluralsight.com/library/courses/asp-dot-net-core-health-checks/table-of-contents

Links:  
https://docs.microsoft.com/ru-ru/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-3.1
## Initial setup
File **`Startup.cs`**
```csharp
public void ConfigureServices(IServiceCollection services)
{  
  ...
  // Place does not matter, at the end of the method, for example
  services.AddHealthChecks();
  ...
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
  app.UseEndpoints(endpoints => {
    endpoints.MapHealthChecks("/health"); //.RequireHost("www.test.com:5000");
  });
}
```
## Configuring database dependency health checks
Option 1
```csharp
// ConfigureServices method
services.AddHealthChecks()
  .AddCheck("SQL Check", () => {
    using (var connection = new SqlConnection(connectionString))
    {
      try
      {
        connection.Open();
        return HealthCheckResult.Healthy();
      }
      catch(SqlException)
      {
        return HealthCheckResult.Unhealthy();
      }
    }
  });
```
Option 2  
Install nuget packages:  
AspNetCore.HealthChecks.SqlServer - for SQL Server
```csharp
// ConfigureServices method
services
  .AddHealthChecks()
  .AddSqlServer(connectionString, failureStatus: HealthStatus.Unhealthy, name: "SQL Server");
```
AspNetCore.HealthChecks.Oracle - for Oracle
```csharp
// ConfigureServices method
services
  .AddHealthChecks()
  .AddOracle(connectionString, failureStatus: HealthStatus.Unhealthy, name: "Oracle");
```
## Configuring API dependency health checks
Using nuget package **AspNetCore.HealthChecks.Uris**.
```csharp
// ConfigureServices method
services.AddHealthChecks()
  .AddUrlGroup(
    new Uri($"{stockIndexServicesUrl}/api/StockIndexes"), 
    "Stock Index Api Health Check",
    HealthStatus.Degraded,
    timeout: new TimeSpan(0,0,5)
  );
```
## Customizing the HTTP status codes and response
```csharp
// Configure method
{
  app.UseEndpoints(endpoints => {
    endpoints.MapHealthChecks("/health", new HealthCheckOptions() {
      ResultStatusCodes = {
        [HealthStatus.Healthy] = StatusCodes.Status200OK,
        [HealthStatus.Degraded] = StatusCodes.Status500InternalServerError,
        [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable
      },
      ResponseWriter = WriteHealthCheckResponse
    });
  });
}

private static Task WriteHealthCheckReadyResponse(HttpContext httpContext, HealthReport result)
{
    httpContext.Response.ContentType = "application/json";

    var json = new JObject(
        new JProperty("OverallStatus", result.Status.ToString()),
        new JProperty("TotalChecksDuration", result.TotalDuration.ToString("c")),
        new JProperty("DependencyHealthChecks", new JObject(result.Entries.Select(dicItem =>
            new JProperty(dicItem.Key, new JObject(
                new JProperty("Status", dicItem.Value.Status.ToString()),
                new JProperty("Description", dicItem.Value.Description),
                new JProperty("Data", new JObject(dicItem.Value.Data.Select(
                    p => new JProperty(p.Key, p.Value))))))))));
    return httpContext.Response.WriteAsync(
        json.ToString(Formatting.Indented));
}
```
## Writing your own custom health checks
**IHealthCheck** interface
## Adding a health check UI
Nuget package **AspNetCore.Healthchecks.UI**.
```csharp
// Startup.cs file
// ConfigureServices method
services.AddHealthChecksUI();

// Configure method
endpoints.MapHealthChecks("/healthui", newHealthCheckOptions(){
  Predicate = _ => true,
  ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

...

app.UseHealthChecksUI();
```
```js
// appsettings.json file
{
  "HealthChecksUI": {
    "HealthChecks": [
      {
        "Name": "Investment Manager App",
        "Uri": "http://localhost:51500/healthui"
      }
    ],
    "EvaluationTimeOnSeconds": 10,
    "MinimumSecondsBetweenFailureNotifications": 60
  }
}
```
## Securing the health check endpoint
```csharp
endpoints.MapHealthChecks(...)
  .RequireAuthorization("HealthCheckPolicy");
```
## Publishing health check information
**IHealthCheckPublisher** interface
```csharp
// Startup.cs file
// ConfigureServices method
services.Configure<HealthCheckPublisherOptions>(options => {
  options.Delay = TimeSpan.FromSeconds(5);
  options.Perdiod = TimeSpan.FromSeconds(10);
  options.Predicate = (check) => check.Tags.Contains("ready");
  options.Timeout = TimeSpan.FromSeconds(20);
});

services.AddSingleton<IHealthCheckPublisher, ...>();
```
