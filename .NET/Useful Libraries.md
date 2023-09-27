# Content
* Excel
  * EPPlus
* Word
  * Xceed DocX 
* Testing
  * Shouldly
  * Fluent Assertions
  * [Pact](#pact)
# Excel
## EPPlus
[Official Website](https://www.epplussoftware.com/),
[nuget](https://www.nuget.org/packages/EPPlus/)
# Word (DOCX)
## Xceed DocX
[nuget](https://www.nuget.org/packages/DocX)
# Testing
## Shouldly
https://github.com/shouldly/shouldly
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
## Pact
Fast, easy and reliable testing for your APIs and microservices.

Pact is the de-facto API contract testing tool. Replace expensive and brittle end-to-end integration tests with fast, reliable and easy to debug unit tests.

[nuget.org](https://www.nuget.org/packages/PactNet), [github](https://github.com/pact-foundation/pact-net)
