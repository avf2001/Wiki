# Presentation Layer
## Folders Structure
* Web.Api\
  * [Controllers](#controllers)\
    * Feature1\
      * [Feature1ApiController.cs](#feature1apicontrollercs)
  * Extensions\
  * Infrastructure\
    * GlobalExceptionHandler.cs
  * Middleware\
  * [Program.cs](#programcs)

## Controllers
### Feature1ApiController.cs
```csharp
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/feature1")
public class Feature1ApiController : ControllerBase
{
    #region Поля

    private readonly ISender _sender;

    #endregion

    #region Конструктор

    public Feaure1ApiController(ISender sender)
    {
        _sender = sender;
    }

    #endregion

    #region Методы

    [HttpGet("search")]
    public async Task<IActionResult> Search(SearchRequest request, CancellationToken cancellationToken)
    {
        var query = new SearchQuery();

        var queryResult = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(GetDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
        ...
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateDto dto)
    {
        ...
        return CreatedAtAction(nameof(Get), new { id = ... }, ...); // требует уточнения
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateDto dto)
    {
        ...
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        ...
    }

    #endregion
}

public record SearchRequest(
    DateOnly beginDate
)
{ }
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
