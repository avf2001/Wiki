1. Install packages
* Serilog.Enrichers.Environment
* Serilog.Enrichers.Thread
* Serilog.Enrichers.Process
3. **`Program.cs`** file
```caharp
```
3. **`appsettings.json`** file  
Remove **`Logging`** section.  
Add **`Serilog`** section.
```json
```
# Using Seq
1. Install package
```
Serilog.Sinks.Seq
```
2. appsettings.json
```json
"Serilog": {
  "Using": [ ..., "Serilog.Sinks.Seq" ],
  "WriteTo": [
    ...
    {
      "Name": "Seq",
      "Args": { "serverUrl": "http://localhost:5341" }
    },
    ...
  ]
},
```
