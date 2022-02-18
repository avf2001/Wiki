1. Download and install Seq https://datalust.co/download
2. Add package Seq.Extensions.Logging
3. Startup.cs (.NET 3.1)
```csharp
// Startup.cs file

using Microsoft.Extensions.Logging;

public void ConfigureServices(IServiceCollection services)
{
  ...  
  services.AddLogging(loggingBuilder => {
    loggingBuilder.AddSeq();
  });
  ...
}
```
4. Add package Serilog.AspNetCore
5. Modify Program.cs file
```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using Serilog;
using Serilog.Events;

namespace WebApplication3
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();

            try
            {
                Log.Information("Starting web host");
                CreateHostBuilder(args).Build().Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

```
