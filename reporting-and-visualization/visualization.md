# Visualizing Metrics

App Metrics does not include any visualzation tool but does include generic [Grafana](http://grafana.org/) dashboards for web applications which will get you started with the default metrics measured by [App Metrics Middleware](../getting-started/fundamentals/middleware-configuration.md). There are also [Sample Applications](https://github.com/alhardy/AppMetrics.Samples), each with a ready-to-go Grafana [dashboard](https://github.com/alhardy/AppMetrics.Samples/tree/master/grafana_dashboards) to help you get started.

The [sample console application](https://github.com/alhardy/AppMetrics.Samples/tree/master/src/App.Sample) is configured to report metrics to [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/), with metrics persisted in InfluxDB, [Grafana](https://grafana.net/) can be used to visualize and alert on metrics. Below is a Grafana dashbaord showing some of the metrics recorded by the sample console application.

## Grafana Dashboards for App Metrics Middleware

### Web Monitoring

<img alt="grafana app metrics middleware" src="https://raw.githubusercontent.com/alhardy/AppMetrics.DocFx/master/images/generic_grafana_dashboard_demo.gif" />

### OAuth2 Monitoring

<img alt="grafana app metrics oauth2 middleware" src="https://raw.githubusercontent.com/alhardy/AppMetrics.DocFx/master/images/generic_grafana_oauth2_dashboard_demo.gif" />

### Grafana + InfluxDB Demo Dashboard


<img alt="grafana demo" src="../../images/grafana_console.gif" />

## Sample Grafana Dashboards

The github repository contains sample dashboards which can be imported into Grafana, you can find the sample applications [here](../../samples/index.md)
