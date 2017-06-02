# Console Reporter

The [App.Metrics.Extensions.Reporting.Console](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.Console/) nuget package is an App Metrics report provider which will output metrics to a console at a specified interval.

1. First see the [getting started](../getting-started/intro.md) guide.
1. Configure the console reporter as follows:

[!code-csharp[Main](../src/samples/AppMetrics.Startup.CodeSnippets/MetricsProgram.cs?highlight=29,30,31,32,33,34,35,36,37)]

> [!TIP]
> The example above is using the `AsciiMetricPayloadBuilder`, this can be substituted with with any of the InfluxDB, Elasticsearch, Prometheus, Graphite, App Metrics JSON, or a custom payload builder.