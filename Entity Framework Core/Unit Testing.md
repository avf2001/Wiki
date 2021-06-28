```csharp
[TestFixture]
public class SelectTests
{
    private AppDbContext _context;
    
    [SetUp]
    public void Setup()
    {
        _context = new AppDbContext(
            new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EfCore5App;Trusted_Connection=True;MultipleActiveResultSets=true")
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
