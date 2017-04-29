# Generic Dashboards

Out-of-box, App.Metrics includes generic Grafana web application dashboards that are built to monitor metrics reported by application's that are using [App.Metrics.Extensions.Middleware](nuget-packages.md#appmetricsextensionsmiddleware).

## Generic Web Dashboard Features

- Metrics measured by the [App Metrics ASP.NET Core Middleware](middleware.md) are pre-configured in the Grafana dashboard.
- Supports filtering graphs by environment allow the same dashbaord to be re-used across environments.
- Supports filtering graphs by application. The idea is to tag metrics by your application's name allow you to re-use the same dashboard instance for all web applications using App Metrics.
- Graphs are configured to use a `datasource` template variable so that you don't need to update all charts with the datasource you configured in Grafana.
- Display a health overview showing passed, degraded and failed checks as well as an overall health status, color coded by the status value.

<img alt="grafana web demo" src="https://raw.githubusercontent.com/alhardy/AppMetrics.DocFx/master/images/generic_grafana_dashboard_demo.gif" />

## Generic OAuth2 Web Dashboard Features

- OAUth2 Metrics measured by the [App Metrics ASP.NET Core Middleware](middleware.md#oauth2) are pre-configured in the Grafana dashboard.
- Supports filtering graphs by environment, application and datasource as explained above.
- Supports filtering graphs by `client_id` so that we can visualize request rates for example on each API endpoint, useful for example to determine client rate limits or what versions clients are using.
- Supports filtering graphs by `route`, allowing us to clearly  visualize a specific endpoint. 

<img alt="grafana web oauth2 demo" src="https://raw.githubusercontent.com/alhardy/AppMetrics.DocFx/master/images/generic_grafana_oauth2_dashboard_demo.gif" />

## How to setup the dashboards

1. Configure your application to use [App Metrics ASP.NET Core Middleware](../getting-started/intro.md#configuring-a-web-host) and [Reporting](../reporting/index.md) targetting your desired TSDB.
2. Run your application to report some metrics
3. Download and install [Grafana](https://grafana.com/grafana/download), then create a new datasource specifying the reporter's details configured as part of your application setup.
3. [Import the desired Grafana dashboard(s)](https://grafana.com/dashboards?search=appmetrics) by copying and pasting the dasboard ID into the [Import Dashboard](http://docs.grafana.org/reference/export_import/#importing-a-dashboard) window in Grafana

## Get the Grafana dashboards!

### Generic Web
- [InfluxDB](https://grafana.com/dashboards/2125).
- [Elasticsearch](https://grafana.com/dashboards/2140).
- [Prometheus](https://github.com/alhardy/AppMetrics.Extensions.Prometheus). *Dashbaord work in progress*
- [Graphite](https://github.com/alhardy/AppMetrics.Extensions.Graphite). *Dashbaord work in progress*

### Generic OAuth2 Web
- [InfluxDB](https://grafana.com/dashboards/2137).
- [Elasticsearch](https://grafana.com/dashboards/2143).
- [Prometheus](https://github.com/alhardy/AppMetrics.Extensions.Prometheus). *Dashbaord work in progress*
- [Graphite](https://github.com/alhardy/AppMetrics.Extensions.Graphite). *Dashbaord work in progress*


> [!TIP]
> All the [sample apps](../samples/index.md) have [sample Grafana dashboards](https://github.com/alhardy/AppMetrics.Samples/tree/master/grafana_dashboards) that can also be downloaded and imported into Grafana for testing.