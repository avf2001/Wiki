# ASP.NET
## Option 1
1. Добавить библиотеку **prometheus-net.AspNet** ([github](https://github.com/rocklan/prometheus-net.AspNet))

2. Файл **Global.asax.cs**:
```csharp
public static class WebApiConfig
{
    public static void Register(HttpConfiguration config)
    {
        ...

        PrometheusConfig.UseMetricsServer(config, "metrics");
    }
}
```

3. Файл **Global.asax.cs**:
```csharp
public class MvcApplication : System.Web.HttpApplication
{
    public static IHttpModule Module = new Prometheus.AspNet.PrometheusHttpRequestModule();

    public override void Init()
    {
        base.Init();
        Module.Init(this);
    }
}
```

## Option 2. ASP.NET 4.8
1. Добавить библиотеку **prometheus-net.AspNet** ([github](https://github.com/rocklan/prometheus-net.AspNet))

2.
```csharp
public class Global : System.Web.HttpApplication
{
    protected void Application_Start(object sender, EventArgs e)
    {
        var configuration = GlobalConfiguration.Configuration;

        Prometheus.AspNet.PrometheusConfig.UseMetricsServer(configuration);
    }
}
```

| Metric                                      | TYPE      | HELP                                                                                    |
| ------------------------------------------- | --------- | --------------------------------------------------------------------------------------- |
| **dotnet_collection_count_total**           | counter   | GC collection count                                                                     |
| **dotnet_total_memory_bytes**               | gauge     | Total known allocated memory                                                            |
| **global_exceptions**                       | counter   | Number of global exceptions                                                             |
| **http_requests_in_progress**               | gauge     | The number of HTTP requests currently in progress                                       |
| **http_requests_received_total**            | gauge     | Provides the count of HTTP requests that have been processed by this app                |
| **http_request_duration_seconds**           | histogram | The duration of HTTP requests processed by this app                                     |
| **process_start_time_seconds**              | gauge     | Start time of the process since unix epoch in seconds                                   |
| **process_cpu_seconds_total**               | counter   | Total user and system CPU time spent in seconds                                         |
| **process_virtual_memory_bytes**            | gauge     | Virtual memory size in bytes                                                            |
| **process_working_set_bytes**               | gauge     | Process working set                                                                     |
| **process_private_memory_bytes**            | gauge     | Process private memory size                                                             |
| **process_open_handles**                    | gauge     | Number of open handles                                                                  |
| **process_num_threads**                     | gauge     | Total number of threads                                                                 |
| **prometheus_net_metric_families**          | gauge     | Number of metric families currently registered                                          |
| **prometheus_net_metric_instances**         | gauge     | Number of metric instances currently registered across all metric families              |
| **prometheus_net_metric_timeseries**        | gauge     | Number of metric timeseries currently generated from all metric instances               |
| **prometheus_net_exemplars_recorded_total** | counter   | Number of exemplars that were accepted into in-memory storage in the prometheus-net SDK |
