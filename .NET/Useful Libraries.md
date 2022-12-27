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
