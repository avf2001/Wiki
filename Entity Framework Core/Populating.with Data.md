```csharp
modelBinder.Entity<LuukUp>().HasData(new List<LookUp>() {
    new LookUp() { Code = "AL", Description = "Alabama", LookUpType = LookUpType.State }
});
```
