- [Set Default Schema](#set-default-schema)
- Primary Key
  - Composite Primary Key
- [Default Value](#default-value)
- [One-to-many Value Objects](#one-to-many-value-objects)
- [Entity]()
  - [Identity]()

# Set Default Schema
```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.HasDefaultSchema("Custom");
}
```

# Primary Key
```csharp
modelBuilder.Entity<Person>().HasKey(c => c.Id);
modelBuilder.Entity<Person>().HasKey(c => c.Id).HasName("PK_Custom_Name");
```

## Composite Primary Key
```csharp
modelBuilder.Entity<Person>().HasKey(c => new { c.FirstName, c.LastName});
```

# Default Value
```csharp
modelBuilder.Entity<Person>().Property(b => b.Country).HasDefaultValue("Russia");
modelBuilder.Entity<Person>().Property(b => b.CreateDate).HasDefaultValueSql("getdate()");
```

# One-to-many Value Objects
```csharp
public class Customer
{
    public Guid Id { get; private set; }
    
    // Expose as read-only for DDD purity
    private readonly List<ContactInfo> _contacts = new();
    public IReadOnlyList<ContactInfo> Contacts => _contacts.AsReadOnly();
    
    // Parameterless constructor for EF
    private Customer() { }
    public Customer(Guid id) => Id = id;
}

// Value Object (C# record recommended)
public record ContactInfo(string Type, string Value);
```
```csharp
// DbContext OnModelCreating
modelBuilder.Entity<Customer>()
    .OwnsMany(c => c.Contacts, contactBuilder =>
    {
        contactBuilder.Property(c => c.Type).IsRequired().HasMaxLength(50);
        contactBuilder.Property(c => c.Value).IsRequired().HasMaxLength(200);
        
        // Optional: customize table name or add indexes
        contactBuilder.ToTable("CustomerContacts");
        contactBuilder.HasIndex(c => c.Type);
    });
```

# Entity
## Identity
```csharp
public class Entity
{
    public int Id { get; private set; } // EF sets via property after ctor
    public DateTime OrderDate { get; }
    public string CustomerId { get; }
    
    public Entity(DateTime orderDate, string customerId)
    {
        OrderDate = orderDate;
        CustomerId = customerId;
    }
}
```
