# Реализация шаблона Repository с использованием Entity Framework Core
1. Интерфейс репозитория
```csharp
public interface IRepository
```
2. Реализация репозитория
```csharp
public class Repository<TEntity> : IRepository where TEntity: Entity
{
  private readonly TestDbContext _context;

  #region Конструктор

  public Repository(TestDbContext context)
  {
    _context = context ?? throw new ArgumentNullException(nameof(context));
  }

  #endregion

  public Task<TEntity?> GetByIdAsync(int id)
  {
  }
}
```
