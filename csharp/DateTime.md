# Date and Times in .NET
Useful library - Noda Time (https://nodatime.org/)

Date ambuguity is solved with ISO 8601.

2019-06-10T18:00:00+00:00

DateTeime doesn't contain time zone specific information.

When to use DateTime:
- Dates
- Times
- UTC
- Date and time arithmetic
- Missing time zone information
- Interop with external systems

TimeZoneInfo - time zone information

DateTimeOffset - includes time zone information

DateTimeOffset should be preferred over using DateTime

## Date and Time arithmetics
TimeSpan class
Calendar class
ISOWeek
## Common scenarios
