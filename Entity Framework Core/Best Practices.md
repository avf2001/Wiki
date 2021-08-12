# Don’t use RemoveRange, ever
Don't
```csharp
// 20 delete queries
db.Table.RemoveRange(db.Table.Where(a => a.Price <= 0).ToList())
```
Do
```csharp
// use Z.EntityFramework.Extensions.EFCore nuget package
db.Table.Where(a => a.Price <= 0).DeleteFromQuery()
```
# Never loop inside DbContext instance!
Don't
```csharp
using (AppDbContext db = new AppDbContext())
{
   // your code here
}
```
Do
```csharp
foreach(var x in items)
{
   using (AppDbContext db = new AppDbContext())
   {
       // your code here
   }
}
```
# Use ExecuteSqlCommand only when necessary
# Avoid defining Foreign Keys on Model classes
