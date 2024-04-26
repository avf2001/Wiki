# Domain Layer
Implementations of repositories are in an infrastructure layer.
## Folders Structure (example)
```
Domain\
  Products\
    IProductRepository.cs
```
```csharp
// IProductRepository.cs
// Domain-specific repository
public interface IProductRepository
{
  Task<Product?> GetByIdAsync(ProductId id);

  void Add(Product product);

  ...
}
```
