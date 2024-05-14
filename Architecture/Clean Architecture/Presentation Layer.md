# Presentation Layer
## Folders Structure
* Web.Api\
  * Endpoints\
    * Feature1\
  * Extensions\
  * Infrastructure\
    * GlobalExceptionHandler.cs
  * Middleware\
  * [Program.cs](#programcs)

### Program.cs
```csharp
// Extension method from Application layer
builder.Services.AddApplication();
// Extension method from Infrastructure layer
builder.Services.AddInfrastructure(builder.Configuration);
```

## Resources
* [YouTube - Clean Architecture: Understand the Presentation Layer's Purpose (Milan Jovanović)](https://www.youtube.com/watch?v=trW-v4Gb0l0)
