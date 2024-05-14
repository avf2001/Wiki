# Presentation Layer
## Folders Structure
* Web.Api\
  * Controllers\
    * Feature1\
      * [Feature1ApiController.cs](#feature1apicontrollercs)
  * Extensions\
  * Infrastructure\
    * GlobalExceptionHandler.cs
  * Middleware\
  * [Program.cs](#programcs)

## Controllers
### Feaure1ApiController.cs
```csharp
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/feature1")
public class Feaure1ApiController : ControllerBase
{
    private readonly ISender _sender;

    public Feaure1ApiController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> Search()
    {
    }
}
```

### Program.cs
```csharp
// Extension method from Application layer
builder.Services.AddApplication();
// Extension method from Infrastructure layer
builder.Services.AddInfrastructure(builder.Configuration);
```

## Resources
* [YouTube - Clean Architecture: Understand the Presentation Layer's Purpose (Milan Jovanović)](https://www.youtube.com/watch?v=trW-v4Gb0l0)
