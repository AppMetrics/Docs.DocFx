# HTTP Reporter

Metrics can be reported to a custom http endpoint using the [App.Metrics.Extensions.Reporting.Http](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.Http/) nuget package.

1. First see the [getting started](../getting-started/intro.md) guide.
1. Configure the HTTP reporter as follows:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/HttpReporterSetup.cs)]

> [!TIP]
> The example above is using the `AsciiMetricPayloadBuilder`, this can be substituted with with any of the InfluxDB, Elasticsearch, Prometheus, Graphite, App Metrics JSON, or a custom payload builder.