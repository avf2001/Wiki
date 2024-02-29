# Content
* Excel
  * EPPlus
* [FluentResults](#fluentresults)
* Logging
  * [SigNoz](#signoz)
* Testing
  * Shouldly
  * [Fluent Assertions](#fluent-assertions)
  * [Pact](#pact)
* [Word](#word)
  * [Xceed DocX](#xceed-docx)
* dotnet-outdated

# Excel
## EPPlus
[Official Website](https://www.epplussoftware.com/),
[nuget](https://www.nuget.org/packages/EPPlus/)
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

# FluentResults
FluentResults is a lightweight .NET library developed to solve a common problem. It returns an object indicating success or failure of an operation instead of throwing/using exceptions.

[Github](https://github.com/altmann/FluentResults)
```
> Install-Package FluentResults
```
# Word
## Xceed DocX
[nuget](https://www.nuget.org/packages/DocX)

# Logging
## SigNoz
SigNoz is an open-source observability tool that helps you monitor your applications and troubleshoot problems. It provides traces, metrics, and logs under a single pane of glass. It is available both as an open-source software and a cloud offering.

With SigNoz, you can do the following:
* Visualise Traces, Metrics, and Logs in a single pane of glass
* Monitor application metrics like p99 latency, error rates for your services, external API calls, and individual endpoints.
* Find the root cause of the problem by going to the exact traces which are causing the problem and see detailed flamegraphs of individual request traces.
* Run aggregates on trace data to get business-relevant metrics
* Filter and query logs, build dashboards and alerts based on attributes in logs
* Monitor infrastructure metrics such as CPU utilization or memory usage
* Record exceptions automatically in Python, Java, Ruby, and Javascript
* Easy to set alerts with DIY query builder
    
[Site](https://signoz.io/)

# dotnet-outdated
[Nuget](https://www.nuget.org/packages/dotnet-outdated-tool), [Github](https://github.com/dotnet-outdated/dotnet-outdated)
