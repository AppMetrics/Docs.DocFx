# Visualizing Metrics

App Metrics does not include any visualzation tool however through reporting metrics, dashboards such as [Grafana](http://grafana.org/) and [Chronograf](https://www.influxdata.com/time-series-platform/chronograf/) can be used for visualization.

The [sample console application](https://github.com/alhardy/AppMetrics/tree/master/samples/App.Sample) is configured to report metrics to [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/), with metrics persisted in InfluxDB, [Grafana](https://grafana.net/) can be used to visualize and alert on metrics. Below is a Grafana dashbaord showing some of the metrics recorded by the sample console application.

## Grafana + InfluxDB Demo Dashboard

<img alt="grafana demo" src="../../images/grafana_console.gif" />

## Sample Grafana Dashboards

The github repository contains sample dashboards which can be imported into Grafana, you can find the sample applications [here](../../samples/index.md)
