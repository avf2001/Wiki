# Infrastructure Layer
## Folders Structure (example)

* Infrastructure\
  * Authentication\
  * Repositories\
    * [ProductRepository.cs](#productrepositorycs)
  * CqrsHandlers\
    * [CreateProductCommandHandler.cs](#createproductcommandhandlercs)
  * ApplicationDbContext.cs
  * DependencyInjection.cs

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
### CreateProductCommandHandler.cs
```csharp
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
  private readonly IProductRepository _repository;
  private readonly IUnitOfWork _unitOfWork;

  public CreateProductCommandHandler(
    IProductRepository repository,
    IUnitOfWork unitOfWork
  )
  {
    _repository = repository;
    _unitOdWork = unitOfWork;
  }

  public async Task<Guid> Handle(CreateProductCommand request, CancellationToken, cancellationToken)
  {
    var product = new Product(
      new ProductId(Guid.NewGuid()),
      request.Name,
      new Money(request.Currency, request.Amount),
      Sku.Create(request.Sku)!
    );
    
    _productRepository.Add(product);

    await _unitOfWork.SaveChangesAsync(cancellationToken);

    return product.Id.Value;
  }
}
```
## Resources
* [YouTube - Clean Architecture: How to Build The Infrastructure Layer (Milan Jovanović)](https://www.youtube.com/watch?v=RsOq-Pkwy1U)
* [YouTube - Don't Break the Clean Architecture Rules with EF Core (Milan Jovanović)](https://www.youtube.com/watch?v=Bi8oRSu-QgU)