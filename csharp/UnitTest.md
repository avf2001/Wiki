https://docs.microsoft.com/ru-ru/visualstudio/test/unit-test-your-code?view=vs-2019

https://github.com/AutoFixture/AutoFixture

https://github.com/moq/moq4

# MSTest
- TestClass
- TestMethod
- ReflectedTestCategory
- TestInitialize
- TestCleanup
- ExpectedException

Тестовый проект

1. Подключить к проекту библиотеки Microsoft.EntityFrameworkCore и Microsoft.EntityFrameworkCore.InMemory
```csharp
install-package Microsoft.EntityFrameworkCore
```

2. Подключить внешний проект, который необходимо протестировать
*Пример класса контекста БД*
```csharp
public class TestDbContext : DbContext
{
  public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }        

  public DbSet<TableItem> TableItems { get; set; }
}

public class TableItem
{
        public int Id { get; set; }
}
```

3. Пример теста
```csharp
[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void TestMethod1()
  {
// Имя тестовой БД должно быть уникальным для изоляции тестов между собой
    var options = new DbContextOptionsBuilder<TestDbContext>().UseInMemoryDatabase($"TestDbInMemory{Guid.NewGuid()}").Options;

    using (var context = new TestDbContext(options))
    {
      #region Arrange

      context.TableItems.AddRange(new[] { 
          new TableItem() { Id = 1 },
          new TableItem() { Id = 2 },
          new TableItem() { Id = 3 },
          new TableItem() { Id = 4 },
          new TableItem() { Id = 5 },
          new TableItem() { Id = 6 },
          new TableItem() { Id = 7 },
          new TableItem() { Id = 8 },
          new TableItem() { Id = 9 },
          new TableItem() { Id = 10 }
      });

      context.SaveChanges();
}

      #endregion

      #region Act
// Для каждой части используем свой контекст БД
 using (var context = new TestDbContext(options))
    {
      var items = context.TableItems;

      #endregion

      #region Assert

      Assert.IsTrue(items.Count() == 10);

      #endregion
    }
  }
}
```
