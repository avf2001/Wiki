# Project Structure
1. Use feature folders

# Project Settings
3. Treat warnings as errors

**`.csproj`** file
```xml
<PropertyGroup>
  <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
</PropertyGroup>
```
# Logging
3. Use Serilog as logging framework
  - Use `ILogger` everywhere, not Serilog directly
  - Use structured logging

# ASP.NET

A Fallback Policy is the policy that gets evaluated if no policy is specified.

```csharp
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});
```
## Remove the Server Header
By default ASP.NET Core adds a Server Header "Kestrel".
```csharp
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
```

# Libraries
- FluentValidation

# Other
## Don't use IOptions
Solution:
```csharp
services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
services.AddSingleton(registeredServices => registeredServices.GetRequiredService<IOptions<AppSettings>>().Value);

// To use IOptionSnapshot register as scoped

public class WeatherForecastController(AppSettings appSettings)
{
    ...
}
```
## ValidateOnBuild
```csharp
builder.Host.UseDefaultServiceProvider(config =>
{
    config.ValidateOnBuild = true;
});
```

# Structuring Method
* Happy Path always at the Bottom of the Method
* Use returns instead of nested if-else

# Testing
Use xUnit

# Use Central Package management
Create Directory.Packages.props at the root and define packages and versions here.
