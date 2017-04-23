## InfluxDB Reporter

Metrics can be reported to [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/) using the [InfluxDB Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.InfluxDB/) which has been tested with InfluxDB version 1.1.0.

[Configure a Console Application](../getting-started/intro.md#configuring-a-console-application) with App Metrics, you can then add the InfluxDB Report Provider as below:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/InfluxDBReporterSetup.cs)]

See the [api documentation](../api/App.Metrics.Extensions.Reporting.InfluxDB.IInfluxDbReporterSettings.html) on the `InfluxDbReporterSettings` available.