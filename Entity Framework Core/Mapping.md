* Set Default Schema
* Primary Key
  * Composite Primary Key
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
```
## Composite Primary Key
```csharp
modelBuilder.Entity<Person>().HasKey(c => new { c.FirstName, c.LastName});
```
