# ASP.NET Core Middleware ASCII Formatting

To serialize metrics, environment info and/or health as plain text when `/metrics`, `/metrics-text`, `/env` and/or `/health` are requested:

1. Add the [App.Metrics.Formatters.Ascii](https://www.nuget.org/packages/App.Metrics.Formatters.Ascii/) nuget package to your ASP.NET Core web application.
1. Configure in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupAscii.cs?highlight=6,7,8,9,10)]