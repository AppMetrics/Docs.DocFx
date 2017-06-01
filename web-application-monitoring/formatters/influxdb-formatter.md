# ASP.NET Core Middleware InfluxDB Formatting

To serialize metrics in InfluxDB Line Protocol format when `/metrics` or `/metrics-text` is requested:

1. Add the [App.Metrics.Formatters.InfluxDB](https://www.nuget.org/packages/App.Metrics.Formatters.InfluxDB/) nuget package to your ASP.NET Core web application.
1. Configure in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupInfluxDB.cs?highlight=6,7,8)]