# Solution Layout
* src\
  * [Application](#application-project)\
    * [DependencyInjection.cs](#dependencyinjectioncs)
  * Domain\
  * [Infrastructure](#infrastructure)\
  * [Presentation](#presentation)\
* tests\

## Application Project
Include packages: MediatR, FluentValidation, FluentValidation.DependencyInjectionExtensions

### DependencyInjection.cs
```csharp
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

### Infrastructure
```csharp
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;       

        return services;
    }
}
```

### Presentation
