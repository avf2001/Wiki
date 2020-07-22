# Реализация шаблона Repository с использованием Entity Framework Core
1. Интерфейс репозитория
```csharp
public interface IRepository
```
2. Реализация репозитория
```csharp
public class Repository : IRepository
{
  private readonly TestDbContext _context;
  
  public Repository(TestDbContext context)
  {
    _context = context ?? throw new ArgumentNullException(nameof(context));
  }
}
```
