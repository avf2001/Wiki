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
```csharp
private readonly SqliteConnection _connection;


// Setup
_connection = new SqliteConnection("Filename=:memory:");
_connection.Open();

var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(_connection).Options;

var dbContext = new ApplicationDbContext(contextOptions);

dbContext.Database.EnsureCreated();

// Fill with data
dbContext.Books.AddRange(new Book() {...});

// Other data

dbContext.SaveChanges();

...

// Teardown
_connection.Dispose();
```
# Fake DbSets
```csharp
// when query data
await dbContext.DidNotReceive().SaveChangesAsync();

// Use package MockQueryable.NSubstitute

var books = new List<Book> { ... };

var dbContext = Substitute.For<ApplicationDbContext>();

var dbSet = ... .AsQueryable().BuildMockDbSet();

dbSet.FindAsync(2)!.Returns(new ValueTask<Book>(books[2]));

dbContext.Books.Returns(dbSet);

// Source: Dometrain - From Zero to Hero - Entity Framework Core in .NET - 06. Testing with EF Core
```
