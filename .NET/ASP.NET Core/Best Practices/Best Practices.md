https://medium.com/neogrid/8-quick-tips-to-improve-your-net-api-6c44faf258e0  
https://nilebits.medium.com/net-core-best-practices-6a2a4f25de8e

# Response Compression
```csharp
/// Startup.cs file
public class Startup
{
  public void ConfigureServices(IServiceCollection services)
  {
    ...
    services.AddResponseCompression();
    services.Configure<GzipCompressionProviderOptions>(options => { options.Level = CompressionLevel.Fastest; });
    ...
  }
}
```
