# 1. Install nuget package
```cmd
> Install-Package prometheus-net.AspNetCore
```
# 2. Add `PrometheusMiddleware.cs` file
```csharp
public static class PrometheusMiddlewareExtension
{
    public static IApplicationBuilder UsePrometheus(this IApplicationBuilder app)
    {
        var counter = Metrics.CreateCounter("api_path_counter", "Counts requests to the API endpoints",
            new CounterConfiguration { LabelNames = new[] { "method", "endpoint" } });

        app.Use((context, next) =>
        {
            counter.WithLabels(context.Request.Method, context.Request.Path).Inc(); return next();
        });

        // Use the Prometheus middleware
        // Should be placed before app.UseEndPoints
        app.UseMetricServer();
        app.UseHttpMetrics();

        return app;
    }
}
```
# 3. `Setup.cs`
```csharp
using Prometheus;

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
  ...
	// Before app.UseEndPoints
	app.UsePrometheus();
	...
}
```
