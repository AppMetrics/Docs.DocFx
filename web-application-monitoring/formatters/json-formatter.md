# ASP.NET Core Middleware JSON Formatting

To serialize metrics and health as JSON when `/metrics` and `/health` are requested: 

1. Add the [App.Metrics.Formatters.Json](https://www.nuget.org/packages/App.Metrics.Formatters.Json/) nuget package to your ASP.NET Core web application.
2. Configure JSON serailization in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/Startup.cs?highlight=6)]