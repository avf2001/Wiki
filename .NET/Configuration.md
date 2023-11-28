# Configuration
* Options Pattern
* Resources
  * Articles
## Options Pattern
```csharp
public class ExternalApiSettings
{
    [Required]
    public string ApiUrl { get; set; }
    public string ApiKey { get; set; }
    public int TimeoutInMilliseconds { get; set; }
}
```
```csharp
services
    .AddOptions<ExternalApiSettings>()
    .BindConfiguration("ExternalApiSettings")
    .ValidateDataAnnotations() // Throws an OptionsValidationException if the configuration is invalid
    .ValidateOnStart();

```
```csharp
public class ExternalApiClient
{
    private readonly ExternalApiSettings _externalApiSettings;

    public ExternalApiClient(IOptions<ExternalApiSettings> options)
    {
        // Important: The Options pattern is 'lazy'. This means that the options are
        // only mapped when you request them by calling .Value!
        // This is only done once, so you don't have to worry about performance.
        _externalApiSettings = options.Value;
    }

    public void CallExternalApi()
    {
        // Do something with these settings here..
    }
}
```
## Resources
### Articles
* [Everything you need to know about configuration and secret management in .NET](https://stenbrinke.nl/blog/configuration-and-secret-management-in-dotnet/)
