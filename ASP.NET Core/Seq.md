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
