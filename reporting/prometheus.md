# Prometheus Reporter

[Prometheus](https://prometheus.io/) promotes a *Pull* based approach rather than *Push*, therefore App Metrics does not include a reporter to push metrics, but rather supports formatting metric data in Prometheus format.

Prometheus formatting is provided by the [App.Metrics.Formatters.Prometheus](https://www.nuget.org/packages/App.Metrics.Formatters.Prometheus) nuget package, when configured the `/metrics` endpoint will serve metrics in Prometheus format for collection.

1. First see the [getting started](../getting-started/intro.md) guide.
1. Configure Prometheus formatting as explained in the [formatter documentation](../web-application-monitoring/formatters/prometheus-formatter.md)

## Web Monitoring

See the [**generic Grafana web dashboards**](../web-application-monitoring/visualization-grafana.md) provided.