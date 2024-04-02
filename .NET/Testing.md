# Testing
* [Libraries](#libraries)  
  * [Fluent Assertions](#fluent-assertions)
  * [FsCheck](#fscheck)
  * [NSubstitute](#nsubstitute)
  * [Pact](#pact)
  * [Playwright](#playwright)
  * [Shouldly](#shouldly)
* [Classes](#classes)
  * [TestServer](#testserver)
  * [WebApplicationFactory](#webapplicationfactory)

# Libraries
## Fluent Assertions
https://fluentassertions.com/introduction
### Collection
```csharp
items.Should().HaveCount(2);
```
### String
```sharp
stringValue.Should().Be("value to assert");
```
### Nullable
```csharp
short? theShort = null;
theShort.Should().NotHaveValue();
theShort.Should().BeNull();
theShort.Should().Match(x => !x.HasValue || x > 0);

int? theInt = 3;
theInt.Should().HaveValue();
theInt.Should().NotBeNull();
theInt.Should().Be(3);

DateTime? theDate = null;
theDate.Should().NotHaveValue();
theDate.Should().BeNull();
```

## FsCheck
FsCheck is a tool for testing .NET programs automatically. The programmer provides a specification of the program, in the form of properties which functions, methods or objects should satisfy, and FsCheck then tests that the properties hold in a large number of randomly generated cases. While writing the properties, you are actually writing a testable specification of your program. Specifications are expressed in F#, C# or VB, using combinators defined in the FsCheck library. FsCheck provides combinators to define properties, observe the distribution of test data, and define test data generators. When a property fails, FsCheck automatically displays a minimal counter example.

[Official Site](https://fscheck.github.io/FsCheck/)

## NSubstitute
[Сайт](https://nsubstitute.github.io/)  
### Примеры
1. Setup:
```csharp
var mockService = new Mock<IMyService>();

var subService = Substitute.For<IMyService>();
```
2. Returning Values:
```csharp
mockService.Setup(x => x.Method()).Returns("value");

subService.Method().Returns("value");
```
3. Argument Matchers:
```csharp
mockService.Setup(x => x.Method(It.IsAny<int>())).Returns("value");

subService.Method(Arg.Any<int>()).Returns("value");
```
4. Verifying Calls:
```csharp
mockService.Verify(x => x.Method(42), Times.Once);

subService.Received().Method(42);
```
5. Ignoring Specific Calls:
```csharp
mockService.Verify(x => x.Method(42), Times.Never);

subService.DidNotReceive().Method(42);
```
6. Argument Checking:
```csharp
mockService.Setup(x => x.Method(It.Is<int>(arg => arg > 10))).Returns("value");

subService.Method(Arg.Is<int>(arg => arg > 10)).Returns("value");
```
7. Exception Handling:
```csharp
mockService.Setup(x => x.Method()).Throws(new Exception("Error"));

subService.When(x => x.Method()).Do(x => { throw new Exception("Error"); });
```
Advanced Use Cases:
1. Recursive Mocks:
```csharp
var mock = new Mock<IMyService>();
mock.Setup(m => m.ObjectA.PropertyB.MethodC()).Returns("value");

var sub = Substitute.For<IMyService>();
sub.ObjectA.PropertyB.MethodC().Returns("value");
```
2. Property Behavior:
```csharp
mock.SetupGet(m => m.MyProperty).Returns("value");
mock.SetupSet(m => m.MyProperty = "value");

sub.MyProperty.Returns("value");
sub.MyProperty = "value";
```
3. Callbacks:
```csharp
string result = "";
mock.Setup(m => m.Method()).Callback(() => result = "Called!");

string result = "";
sub.Method().ReturnsForAnyArgs(x => { result = "Called!"; return true; });
```
4. Events:
```csharp
var mock = new Mock<IEvents>();
mock.Raise(m => m.MyEvent += null, EventArgs.Empty);

var sub = Substitute.For<IEvents>();
sub.MyEvent += Raise.EventWith(EventArgs.Empty);
```
5. Partial Mocks:
```csharp
var mock = new Mock<MyClass>() { CallBase = true };
mock.Setup(m => m.VirtualMethod()).Returns("mocked value");

var sub = Substitute.ForPartsOf<MyClass>();
sub.VirtualMethod().Returns("mocked value");
```
6. Ordered Calls Verification:
```csharp
sub.Received().FirstMethod();
sub.Received().SecondMethod();
```
8. Advanced Argument Matchers:
```csharp
mock.Setup(m => m.Method(It.IsRegex("[a-z]"))).Returns("matched");

sub.Method(Arg.Is<string>(arg => Regex.IsMatch(arg, "[a-z]"))).Returns("matched");
```

## Pact
Fast, easy and reliable testing for your APIs and microservices.

Pact is the de-facto API contract testing tool. Replace expensive and brittle end-to-end integration tests with fast, reliable and easy to debug unit tests.

[nuget.org](https://www.nuget.org/packages/PactNet), [github](https://github.com/pact-foundation/pact-net)

## FluentResults
FluentResults is a lightweight .NET library developed to solve a common problem. It returns an object indicating success or failure of an operation instead of throwing/using exceptions.

[Github](https://github.com/altmann/FluentResults)
```
> Install-Package FluentResults
```
## Playwright
Playwright enables reliable end-to-end testing for modern web apps.

[Site](https://playwright.dev/)

## Shouldly
https://github.com/shouldly/shouldly

# Classes
## TestServer
[Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.testhost.testserver?view=aspnetcore-8.0)
## WebApplicationFactory
[Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.testing.webapplicationfactory-1?view=aspnetcore-8.0)
