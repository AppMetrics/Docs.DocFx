# Reporting

The current release of App.Metrics supports InfluxDB, Console and Text File Reporters.

## Console Reporter

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, you can then add the [Console Report Provider](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.Console/) as below:

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/MetricsProgram.cs?highlight=30,31,32,33,18)]

## InfluxDB Reporter

Metrics can be reported to [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/) using the [InfluxDB Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.InfluxDB/) which has been tested with InfluxDB version 1.1.0.

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, you can then add the InfluxDB Report Provider as below:

[!code-csharp[Main](../../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/InfluxDBReporterSetup.cs)]

See the [api documentation](../../api/App.Metrics.Extensions.Reporting.InfluxDB.IInfluxDbReporterSettings.html) on the `InfluxDbReporterSettings` available.

## ElasticSearch Reporter

Metrics can be reported to [ElasticSearch](https://www.elastic.co/) using the [ElasticSearch Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.ElasticSearch/).

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, you can then add the ElasticSearch Report Provider as below:

[!code-csharp[Main](../../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/ElasticSearchReporterSetup.cs)]

See the [api documentation](../../api/App.Metrics.Extensions.Reporting.ElasticSearch.ElasticSearchReporterSettings.html) on the `ElasticSearchReporterSettings` available.

## Text File Reporter

[Configure a Console Application](../intro.md#configuring-a-console-application) with App Metrics, similar to the Console Reporter example above a [Text Report Provider](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.TextFile/) can be added as below:

[!code-csharp[Main](../../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/TextFileReporterSetup.cs)]

## Run Reporting in a Web Host

To run the registered reporters in a web application, the `UseMetricsReporting` `IApplicationBuilder` extention method can be used as show below. The extension methods takes the `IApplicationLifetime` instance which is used to run reporting after the application has successfully started up and uses the `lifetime.ApplicationStopping` cancellation token to gracefully end reporting on application shutdown.

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupWithReporting.cs?highlight=11)]

> [!NOTE]
> ### Don't see the reporter your looking for?
> Pull requests or more than welcome, for now see the [Console](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Reporting.Console) and [Text File](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Reporting.TextFile) reporters for guidance on implementing a new reporter.