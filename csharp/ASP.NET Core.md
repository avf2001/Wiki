# Building a RESTful API with ASP.NET Core 3
https://github.com/KevinDockx/BuildingRESTfulAPIAspNetCore3
## Tools
Postman - https://www.getpostman.com

Project properties - Debug - Launch: = Project

Launch browser: = unchecked

Set AppURL: = http://localhost:{portnumber}

microsoft.entityframeworkcore
microsoft.entityframeworkcore.sqlserver
microsoft.entityframeworkcore.tools

REST is defined by 6 constraints (one is optional)

## The Richardson Maturity Model
Level 0
Level 1 - Resources
Level 2 - Verbs, correct status codes
Level 3 - hypermedia

api/authores/{authorIs}/totalamountofpages

app.UseRouting()
or
app.UseEndpoints()

```csharp
public void ConfigureServices(IServiceCollection services)
{
  services.AddControllers(setupAction => {
    setupAction.ReturnHttpNotAcceptable = true; // reurns 406 code if Accept header is not supported
  })
  .AddXmlDataContractSerializerFormatters(); // Adds XML output serializer
}
```
## Getting resources
install-package AutoMapper.Extensions.Microsoft.DependencyInjection
```csharp
public void ConfigureServices(IServiceCollection services)
{
  ...
  services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());   
  ...
}
```
## Handling exceptions
```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler(appBuilder => {
            appBuilder.Run(async context => {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("An unexpected fault happened. Try again later.");
            });
        });
    }

}
```
## Supporting HEAD
```csharp
[HttpHead]
```
## Filtering and searching
[FromBody]
[FromForm]
[FromHeader]
[FromQuery]
[FromRoute]
[FromService]

Filter and search options are not part of the resource.
Only allow filtering on fields that are part of the resource.
## Creating resources
## Creating a child resource
## Creating a collection
## Validatig data and reporting validation errors
IValidatebleObject
```
.ConfigureApiBehaviourOptions(setupAction => 
{
  setupAction.InvalidModelStateResponseFactory = context =>
  {
    var problemDetailsFactory = context.HttpContext.RequestServices.GetRequiredService<ProblemDateildfactory>();
    
    var problemDetails = problemDetailsFactory.CreateValidationProblemDetails(context.HttpContext, context.ModelState);
    
    problemDetails.Detail = "See the errors field for details";
    problemdetails.Instance = context.HttpContext.Request.Path;
    
    var actionExecutingContext = context as Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext;
    
    if ((context.ModelState.ErrorCount > 0) && (actionExecutingContext?.ActionArguments.Count == context.ActionDescriptor.Parameters.Count)) {
      problemDetails.Type = "https://...";
      problemDetails.Status = StstusCode.Status422...
      problemDetails.Title = "One or more validation errors occured.";
      
      return new UnprocessableEntityObjectResult(problemDetails)
      {
        ContentTypes = { "application/problem+json" }
      }
    };
  }
});
```
## Updating resources
PUT - update all resorce fields
PATCH - update using JsonPatchDocument

PATCH should be preferred over PUT

Microsoft.AspNetCore.JsonPatch
## Deleting resources
```csharp
return NoContent();
```
