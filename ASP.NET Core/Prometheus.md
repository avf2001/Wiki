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
# 4. Run web application and navigate to metrics endpoint
```
http://localhost:1234/metrics
```
Example response
```
# HELP process_private_memory_bytes Process private memory size
# TYPE process_private_memory_bytes gauge
process_private_memory_bytes 74604544
# HELP process_virtual_memory_bytes Virtual memory size in bytes.
# TYPE process_virtual_memory_bytes gauge
process_virtual_memory_bytes 2223070081024
# HELP process_start_time_seconds Start time of the process since unix epoch in seconds.
# TYPE process_start_time_seconds gauge
process_start_time_seconds 1576244939.1073897
# HELP dotnet_total_memory_bytes Total known allocated memory
# TYPE dotnet_total_memory_bytes gauge
dotnet_total_memory_bytes 3013928
# HELP process_cpu_seconds_total Total user and system CPU time spent in seconds.
# TYPE process_cpu_seconds_total counter
process_cpu_seconds_total 0.796875
# HELP dotnet_collection_count_total GC collection count
# TYPE dotnet_collection_count_total counter
dotnet_collection_count_total{generation="1"} 0
dotnet_collection_count_total{generation="2"} 0
dotnet_collection_count_total{generation="0"} 0
# HELP process_working_set_bytes Process working set
# TYPE process_working_set_bytes gauge
process_working_set_bytes 56242176
# HELP process_num_threads Total number of threads
# TYPE process_num_threads gauge
process_num_threads 35
# HELP process_open_handles Number of open handles
# TYPE process_open_handles gauge
process_open_handles 566
```
