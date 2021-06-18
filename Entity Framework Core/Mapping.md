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
modelBuilder.Entity<Person>().HasKey(c => c.Id).HasName("PK_Custom_Name");
```
## Composite Primary Key
```csharp
modelBuilder.Entity<Person>().HasKey(c => new { c.FirstName, c.LastName});
```
