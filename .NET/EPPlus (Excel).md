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
# Чтение ячеек
```csharp
var package = new ExcelPackage(new FileInfo("sample.xlsx"));

ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
var start = workSheet.Dimension.Start;
var end = workSheet.Dimension.End;
for (int row = start.Row; row <= end.Row; row++)
{ // Row by row...
    for (int col = start.Column; col <= end.Column; col++)
    { // ... Cell by cell...
        object cellValue = workSheet.Cells[row, col].Text; // This got me the actual value I needed.
    }
}
```
