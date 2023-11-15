# Содержание
* MSTest
* [NUnit](#nunit)
  * [Необходимые библиотеки](#необходимые-библиотеки)
  * [Атрибуты](#атрибуты)
  * [Командная строка](#командная-строка)
  * [Assertions](#assertions)
  * [Полезные ссылки](#полезные-ссылки)
* [Moq](#moq)
  * [IConfiguration](#iconfiguration)
  * [IHttpClientFactory](#ihttpclientfactory)

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
# NUnit
## Необходимые библиотеки
```
NUnit
NUnit3TestAdapter
Microsoft.Net.Test.Sdk
```
## Атрибуты
| Attribute | Meaning |
|-|-|
|TestFixture | test class attribute |
|Test | test method |
|Category||
|TestCase||
|Values||
|SetUp||
|OneTimeSetUp||
|Ignore||
|TearDown||
|OneTimeTearDown||
|TestCaseSource||
## Командная строка
```
> dotnet test # запустить выполнение тестов
> dotnet test --list-tests # отобразить список всех доступных тестов
> dotnet test /? # справка по команде
```
## Assertions
```csharp
Assert.That(sut.Years, Is.Equal(1)); // value equality
Assert.That(sut.Years, Is.Equal(1), "Error Message");
Assert.That(a, Is.SameAs(b)); // reference equality
Assert.That(a, Is.Not.SameAs(c)); // reference equality

/* Exception */
Assert.That(() => new ..., Throws.TypeOf<Exception>());
Assert.That(() => new ..., Throws.TypeOf<Exception>().With.Property("Message").EqualTo("Expected Message"));
Assert.That(() => new ..., Throws.TypeOf<Exception>().With.Message.EqualTo("Expected Message"));
Assert.That(() => new ..., Throws.TypeOf<Exception>().With.Matches<Exception>(ex => ex.Message == "Expected Message"));

Assert.That(name, Is.Null);
Assert.That(name, Is.Not.Null);
Assert.That(name, Is.Empty);
Assert.That(name, Is.Not.Empty);
Assert.That(name, Is.EqualTo("Some value"));
Assert.That(name, Is.EqualTo("Some value").IgnoreCase);
Assert.That(name, Does.StartWith("Aaa"));
Assert.That(name, Does.EndWith("Aaa"));
Assert.That(name, Does.Contain("Aaa"));
Assert.That(name, Does.Not.Contain("Aaa"));
Assert.That(name, Does.StartWith("Aaa").And.EndWith("Bbb"));
Assert.That(name, Does.StartWith("Aaa").Or.EndWith("Bbb"));

Assert.That(boolValue, Is.True);
Assert.That(boolValue, Is.False);
Assert.That(boolValue, Is.Not.True);

Assert.That(intValue, Is.GreaterThan(17));
Assert.That(intValue, Is.GreaterThanOrEqualTo(17));
Assert.That(intValue, Is.LessThan(17));
Assert.That(intValue, Is.InRange(10, 20));
```
## Полезные ссылки
[Introduction to .NET Testing with NUnit 3](https://www.pluralsight.com/courses/nunit-3-dotnet-testing-introduction)

# Moq
## IConfiguration
```csharp
/*
"Services": {
  "ServiceName": {
    "Url": "https://...",
    "UserId": "userid",
    "Password": "password"
  },
*/
var initialData = new Dictionary<string, string>
{
    { "Services:ServiceName", "" },
    { "Services:ServiceName:Url", "https://some.url" },
    { "Services:ServiceName:UserId", "UserId" },
    { "Services:ServiceName:Password", "Password" }
};

var configuration = new ConfigurationBuilder()
                            .AddInMemoryCollection(initialData)
                            .Build();
```
## IHttpClientFactory
```csharp
var httpClientFactoryMock = new Mock<IHttpClientFactory>();
httpClientFactoryMock
  .Setup(_ => _.CreateClient(It.IsAny<string>()))
  .Returns(new HttpClient())
  .Verifiable();
```
