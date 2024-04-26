# Infrastructure Layer
## Folders Structure (example)
```
├── Infrastructure\
    ├── Authentication\
    ├── Repositories\
        └── ProductRepository.cs
    ├── CqrsHandlers\
    ├── ApplicationDbContext.cs
    └── DependencyInjection.cs
```
### ProductRepository.cs
```csharp
public sealed class ProductRepository : IProductRepository
{
  private readonly ApplicationDbContext _context;

  public ProductRepository(ApplicationDbContext context)
  {
    _context = context;
  }

  public Task<Product?> GetByIdAsync(ProductId id)
  {
    return _context.Products.Include(x => x.Items).SingleOrDefaultAsync(x => x.Id = id);
  }

  ...
}
```
## Resources
* [YouTube - Clean Architecture: How to Build The Infrastructure Layer (Milan Jovanović)](https://www.youtube.com/watch?v=RsOq-Pkwy1U)
* [YouTube - Don't Break the Clean Architecture Rules with EF Core (Milan Jovanović)](https://www.youtube.com/watch?v=Bi8oRSu-QgU)
