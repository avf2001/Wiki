# Interceptors
https://learn.microsoft.com/en-us/ef/core/logging-events-diagnostics/interceptors
## Detect Slow Queries
```csharp
public class SqlQueiesInterceptor: DbCommandInterceptor
{
    public override DbDataReader ReaderExecuted(
        DbCommand command,
        CommandExecutedEventData eventData,
        DbDataReader result
    )
    {
        if (eventData.Duraton.TotalMilliseconds > 500)
        {
            File.AppendAllText(
                "lonqQueries.txt",
                command.CommandText +
                    " MS:" +
                    eventData.Duraton.TotalMilliseconds +
                    Environmend.NewLine +
                    Environmend.NewLine
            );
        }

        return base.ReaderExecuted(command, eventData, result);
    }
}
```
