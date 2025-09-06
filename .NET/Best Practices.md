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
