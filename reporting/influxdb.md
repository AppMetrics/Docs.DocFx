## InfluxDB Reporter

Metrics can be reported to [InfluxDB](https://www.influxdata.com/products/open-source/#influxdb) using the [InfluxDB Reporter package](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.InfluxDB/).

1. First see the [getting started](../getting-started/intro.md) guide.

2. Configure the InfluxDB reporter as follows:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/InfluxDBReporterSetup.cs)]

### Web Monitoring

See the [**generic Grafana web dashboards**](../web-application-monitoring/visualization-grafana.md) provided.