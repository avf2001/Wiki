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

# Libraries
- FluentValidation
