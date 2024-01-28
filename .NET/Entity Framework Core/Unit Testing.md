# NUnit
```csharp
[TestFixture]
public class SelectTests
{
    private AppDbContext _context;
    
    [SetUp]
    public void Setup()
    {
        var connectionString = "Server=(localdb)\\mssqllocaldb;Database=EfCore5App;Trusted_Connection=True;MultipleActiveResultSets=true";
        
        _context = new AppDbContext(
            new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options
        );
    }
    
    [Test]
    public void GetAllpersons()
    {
        var persons = _context.Persons.ToList();
        Assert.AreEqual(2, persons.Count());
    }
}
```
