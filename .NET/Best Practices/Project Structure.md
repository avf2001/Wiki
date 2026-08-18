# Project Structure

## Use feature folders
## Global Usings
### Option 1
[Source](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/using-directive#the-global-modifier)

### Option 2
*.csproj file
```xml
<ItemGroup>
    <Using Include="XUnit" />
</ItemGroup>
```

### Option 3
**`Directory.Build.props`** file
