# Чтение из MemoryStream
```csharp
byte[] _fileBytes = ... ;

// Обязательно указываем использование лицензии
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

using (var memStream = new MemoryStream(_fileBytes))
{
    var package = new ExcelPackage(memStream);
    package.Load(memStream);

    ExcelWorkBook workbook = package.Workbook;
}
```
