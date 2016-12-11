# Reporting

The current release of App.Metrics supports InfluxDB, Console and Text File Reporters.

## Console Reporter

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, you can then add the [Console Report Provider](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.Console/) as below:

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/MetricsProgram.cs?highlight=30,31,32,33,18)]

## InfluxDB Reporter

The [InfluxDB Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.InfluxDB/) is currently an alpha release, it has been tested with InfluxDB version 1.1.0.

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, you can then add the InfluxDB Report Provider as below:

[!code-csharp[Main](../../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/InfluxDBReporterSetup.cs)]

## Text File Reporter

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, similar to the Console Reporter example above a [Text Report Provider](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.TextFile/) can be added as below:

[!code-csharp[Main](../../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/TextFileReporterSetup.cs)]

> [!NOTE]
> ### Don't see the reporter your looking for?
> Pull requests or more than welcome, for now see the [Console](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Reporting.Console) and [Text File](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Reporting.TextFile) reporters for guidance on implementing a new reporter.