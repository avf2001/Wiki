async void - избегать, использовать async Task
можно использовать только в Event Handlers

// UI code
```csharp
await Task.Run(() => { 
	// call synchronous code	
	
	Dispatcher.Invoke(() => {
		// Call UI thread
		tbxText.Text = "Soem text";
	});
});
```
# Resources
## Articles
* [AsyncGuidance by David Fowler (github)](https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/master/AsyncGuidance.md)
