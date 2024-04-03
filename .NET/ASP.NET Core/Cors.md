# Configuring CORS in ASP.NET and ASP.NET Core
## ASP.NET Core
CORS = Cross Origin Resource Sharing

## Same-origin Policy
Origin:
https://www.mysite.com:80
- Protocol - https
- Domain - mysite
- Port - 80

Access-Control-Allow-Origin: *

Startup.cs
```csharp
public void ConfigureServices(IServiceCollection services)
{
  services.AddCors(
    options =>
      options
        .AddPolicy(
          "AllowEverything",
          builder => builder
                      .AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader()
        )
  );
  // AllowCredentials()
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
  // Should be placed before other middleware, ma by after routing
  app.UseCOrs("AllowEverything");
}
```
```csharp
[EnableCors("PolicyName")]
```
javascript
{
  credentials: "include" // or withCredentials = true
}
