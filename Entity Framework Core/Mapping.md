* Set Default Schema
* Primary Key
  * Composite Primary Key
* [Default Value](#default-value)
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
