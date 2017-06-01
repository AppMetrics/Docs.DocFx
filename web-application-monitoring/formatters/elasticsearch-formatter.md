# ASP.NET Core Middleware ElasticSearch Formatting

To serialize metrics in ElasticSearch document format when `/metrics` or `/metrics-text` is requested:

1. Add the [App.Metrics.Formatters.ElasticSearch](https://www.nuget.org/packages/App.Metrics.Formatters.ElasticSearch/) nuget package to your ASP.NET Core web application.
1. Configure in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupElasticSearch.cs?highlight=6,7,8)]