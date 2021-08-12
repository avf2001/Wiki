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
