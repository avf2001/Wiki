# Domain Layer
Implementations of repositories are in an infrastructure layer.
## Folders Structure (example)
* Domain\
  * Abstractions\
    * [EntityBase.cs](#entitybasecs)
    * [IDomainEvent.cs](#idomaineventcs)
    * [IUnitOfWork.cs](#iunitofworkcs)
    * [ValueObjectBase.cs](#valueobjectBasecs)
  * Common\
    * PagedList.cs
  * Products\
    * Entities\
      * [Product.cs](#productcs)
    * Events\
      * [ProductCreatedDomainEvent.cs](#productcreateddomaineventcs)
    * Repositories\
      * [IProductRepository.cs](#iproductrepositorycs)
  * Feature2
    * Entities\
    * Events\
    * Repositories\

### EntityBase.cs
```csharp
public abstract class EntityBase
{
    private readonly List<IDomainEvent> _domainEvents = new();    

    public int Id { get; init; }

    protected readonly List<IDomainEvent> _domainEvents = [];

    protected EntityBase(int id) => Id = id;

    #region Domain Events

    public IReadonlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    #endregion

    // For EntityFramework
    protected EntityBase() {}
}
```

### IDomainEvent.cs
```csharp
using Mediatr;

public interface IDomainEvent : INotification
{
}
```

### IUnitOfWork.cs
```csharp
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
```

### ValueObjectBase.cs
```csharp
public abstract ValueObjectBase
{
}
```

### ProductCreatedDomainEvent.cs
```csharp
public sealed record ProductCreatedDomainEvent(int id) : IDomainEvent;
```

### Product.cs
```csharp
public class Product : EntityBase
{
    public Product(int id) : base(id)
    {
    }

    public void Delete()
    {
        ...
        _domainEvents.Add(new ProductDeletedDomainEvent(this.Id));
    }
}
```

### IProductRepository.cs
```csharp
// IProductRepository.cs
// Domain-specific repository
public interface IProductRepository
{
  Task<Product?> GetByIdAsync(ProductId id, CancellationToken cancellationToken = default);

  void Add(Product product);

  ...
}
```

## Resources
* [YouTube - Domain Validation With .NET | Clean Architecture, DDD, .NET 6 (Milan Jovanović)](https://www.youtube.com/watch?v=KgfzM0QWHrQ)
