# ASP.NET Core Middleware Graphite Formatting

To serialize metrics in Graphite Plain Text format when `/metrics` or `/metrics-text` is requested:

1. Add the [App.Metrics.Formatters.Graphite](https://www.nuget.org/packages/App.Metrics.Formatters.Graphite/) nuget package to your ASP.NET Core web application.
1. Configure in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupGraphite.cs?highlight=6)]