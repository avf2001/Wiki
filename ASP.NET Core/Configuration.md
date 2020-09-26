**applicationsettings.json**
```json
"ConnectionStrings": {
  "DefaultConnection": ""
},
"Logging": {
  "IncludeScopes": false,
  "LogLevel": {
    "Default": "Warning"
  }
},
"Email": {
  "Username": "",
  "Password": ""
}
```
```csharp
public class EmailConfig {
  public string Username { get; set;}  
  public string Password { get; set;}
}
```
```csharp
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.Configure<EmailConfig>(Configuration.GetSection("Email"));
    }
  	....
    ....
    ....
}
```
```csharp
using Microsoft.Extensions.Options;

public class UserController : BaseController
{
    private readonly EmailConfig _emailConfig;

    public UserController(IOptionsMonitor<EmailConfig> optionsMonitor)
    {
    	_emailConfig = optionsMonitor.CurrentValue;
        
        //_emailConfig.Username
        //_emailConfig.Password
    }
}
```
