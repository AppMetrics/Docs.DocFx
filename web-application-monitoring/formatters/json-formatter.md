# ASP.NET Core Middleware JSON Formatting

To serialize metrics, environment information and/or health as JSON when `/metrics`, `/metrics-text`, `/env` and/or `/health` are requested:

1. Add the [App.Metrics.Formatters.Json](https://www.nuget.org/packages/App.Metrics.Formatters.Json/) nuget package to your ASP.NET Core web application.
1. Configure JSON serialization in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/Startup.cs?highlight=6,7,8,9,10)]