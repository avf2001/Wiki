# Solution Layout
* src\
  * [Application](#application-project)\
    * DependencyInjection.cs
  * Domain\
  * [Infrastructure](#infrastructure)\
    * DependencyInjection.cs
  * [Presentation](#presentation)\
    * DependencyInjection.cs
  * WebAPI\
* tests\

## Application Project
Include packages: MediatR, FluentValidation, FluentValidation.DependencyInjectionExtensions
```csharp
// DependencyInjection.cs

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.AddMediatR(
            configuration => configuration.RegisterServicesFromAssembly(assembly)
        );

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
```

## Infrastructure
```csharp
// DependencyInjection.cs

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;       

        return services;
    }
}
```

## Presentation
```csharp
// DependencyInjection.cs

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;       

        return services;
    }
}
```
