# Caller Information
* CallerFilePathAttribute - Full path of the source file that contains the caller. The full path is the path at compile time.
* CallerLineNumberAttribute - Line number in the source file from which the method is called.
* CallerMemberNameAttribute - Method name or property name of the caller.
* CallerArgumentExpressionAttribute - String representation of the argument expression.

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/caller-information

# Memory Management
## Weak References
Weak references are a useful memory management technique, especially when implementing caching systems. A weak reference allows the garbage collector to collect an object while still providing a way to access it if it hasn’t been collected.
```csharp
MyClass myObject = new MyClass();  
WeakReference<MyClass> weakReference = new WeakReference<MyClass>(myObject);
```
```csharp
MyClass target;  
if (weakReference.TryGetTarget(out target))  
{  
    // The object is still alive.  
    Console.WriteLine("Object has not been collected.");  
}  
else  
{  
    // The object has been collected.  
    Console.WriteLine("Object has been collected.");  
}
```
