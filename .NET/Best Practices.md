1. Use feature folders
2. Treat warnings as errors

**`.csproj`** file
```xml
<PropertyGroup>
  <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
</PropertyGroup>
```
3. Use Serilog as logging framework
  - Use `ILogger` everywhere, not Serilog directly
  - Use structured logging

# ASP.NET
4. Use FallbackPolicy
```csharp
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});
```
