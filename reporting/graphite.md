# Graphite Reporter

Metrics can be reported to [Graphite](https://graphiteapp.org/) using the [App.Metrics.Extensions.Reporting.Graphite](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.Graphite/) nuget package.

1. First see the [getting started](../getting-started/intro.md) guide.
1. Configure the Graphite reporter as follows:

[!code-csharp[Main](../src/samples/App.Metrics.Extensions.Reporting.Code.Snippets/GraphiteReporterSetup.cs)]

> [!NOTE]
> UDP is supported as well as TCP, the protocol is determined by the Uri passed into `GraphiteSettings`.
>
> e.g.`net.tcp://127.0.0.1:2003/` Or `net.udp://127.0.0.1:2003/`.

## Web Monitoring

See the [**generic Grafana web dashboards**](../web-application-monitoring/visualization-grafana.md) provided.