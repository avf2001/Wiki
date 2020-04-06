DbContextOptionsBuilder

.UseLoggerFactory

.EnableSensitiveDataLogging

## DbContext encapsulation
Initialize DbContext with connection string instead of DbContextOptions

## Model
Make setters private
Use contructor to set properties
Class need to have private parameterless constructor

## Many-to-one relationship
Prefer navigation properties over IDs
```csharp
modelBuilder.Entity<Student>(x => {
x.HasOne(p => p.FavouriteCourse).WithMany();
});

modelBuilder.Entity<Course>(x => {
x.ToTable("Course").HasKey(k => k.Id);
});
```
Prefer lazy loading to eager loading:
- helps to avoid partitially initialized entities;
- more performant in some scenarious.

To use lazy loading:
1. install package Microsoft.EntityFrameworkCore.Proxies
2. optionsBuilder.UseLazyLoadingProxies()
3. set model properties as virtual, class should not be sealed, class have to have protected default constructor
```csharp
public abstract class Entity
{
  public long Id { get; }
  
  public override bool Equals(object obj)
  {
    if (!(obj is Entity other)) return false;
    
    if (ReferenceEquals(this, other)) return true;
    
    if (GetRealType() != other.GetRealType()) return false;
    
    if (Id == 0 || othre.Id == 0) return false;
    
    return Id == other.Id;
  }
  
  public statuc bool operator ==(Entity a, Entity b)
  {
    if (a is null && b is null) return false;
    
    if (a is null || b is null) return false;
    
    return a.Equals(b);
  }
  
  public static bool operator !=(Entity a, Entity)
  {
    return !(a == b);
  }
  
  public override int GetHashCode()
  {
    return (GetType().ToString() + Id).GetHashCode();
  }
  
  private Type GetRealType()
  {
    Type type = GetType();
    
    if (type.ToString().Contains("Castle.Proxies.")) return type.BaseType;
    
    return type;
  }
}
```
Use Find(), not Single() or First()
