# Visualizing Metrics

App Metrics does not include any visualzation tool but does include generic [Grafana](http://grafana.org/) dashboards for web applications which will get you started with the default metrics measured by [App Metrics Middleware](../web-application-monitoring/middleware.md). There are also [Sample Applications](https://github.com/alhardy/AppMetrics.Samples), each with a ready-to-go [Grafana dashboards](https://github.com/alhardy/AppMetrics.Samples/tree/master/grafana_dashboards) to help you get started.

The [sample console application](https://github.com/alhardy/AppMetrics.Samples/tree/master/src/App.Sample) is configured to report metrics to [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/), with metrics persisted in InfluxDB, [Grafana](https://grafana.net/) can be used to visualize and alert on metrics. Below is a Grafana dashbaord showing some of the metrics recorded by the sample console application.

> [!TIP]
> You can find App Metrics compatible Grafana dashboards on [Grafana Labs](https://grafana.com/dashboards?search=appmetrics).

## Grafana Dashboards

### InfluxDB Demo Dashboard

<img alt="grafana demo" src="https://raw.githubusercontent.com/alhardy/app-metrics-docs/master/images/grafana_console.gif" />

### Web Monitoring

Generic web application dashboard, read the details [here](../web-application-monitoring/visualization-grafana.html#generic-oauth2-web-dashboard-features).

<img alt="grafana app metrics middleware" src="https://raw.githubusercontent.com/alhardy/AppMetrics.DocFx/master/images/generic_grafana_dashboard_demo.gif" />

### OAuth2 Web Monitoring

Generic OAuth2 client tracking dashboard, read the details [here](../web-application-monitoring/visualization-grafana.html#generic-oauth2-web-dashboard-features).

<img alt="grafana app metrics oauth2 middleware" src="https://raw.githubusercontent.com/alhardy/AppMetrics.DocFx/master/images/generic_grafana_oauth2_dashboard_demo.gif" />
