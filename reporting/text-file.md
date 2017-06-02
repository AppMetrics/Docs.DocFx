# Text File Reporter

The [App.Metrics.Extensions.Reporting.TextFile](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.TextFile/) nuget package is an App Metrics report provider which will output metrics to a text file at a specified interval.

1. First see the [getting started](../getting-started/intro.md) guide.
1. Configure the text file reporter as follows:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/TextFileReporterSetup.cs)]

> [!TIP]
> The example above is using the `AsciiMetricPayloadBuilder`, this can be substituted with with any of the InfluxDB, Elasticsearch, Prometheus, Graphite, App Metrics JSON, or a custom payload builder.