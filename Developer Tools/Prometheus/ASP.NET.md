# ASP.NET

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
