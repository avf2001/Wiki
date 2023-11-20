# Clear folder
```powershell
$folder = "C:\Some\Folder"

Get-ChildItem -Path $folder | ForEach-Object -Process { 
  If($_.attributes -eq "Directory") {
    Remove-Item -Path $_.FullName -Recurse -Force;
  } Else {
    Remove-Item -Path $_.FullName -Force;
  }
}
```
