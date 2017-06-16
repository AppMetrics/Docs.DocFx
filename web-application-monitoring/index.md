# Web Application Monitoring

Insight into real-time application metrics is such a great thing to have, especially web applications. It allows us to detect and alert on anomalies when releasing a new version, assists in identifing bottlenecks, provides insight into why our appilcation may be scaling too often during a particular time of the day, allows us to provide trending statistics to our stakeholders, allows us to identifiy how often and at what rate clients are requesting specific endpoints in an API and much much more.

App Metrics makes it easy to get up and running with an open source monitoring solution, providing extensions allowing us to report to various open source Timeseries Databases (TSDB) and also provides generic dashbaords allowing us to visualize our application's metrics in real-time.

There are several TSDB reporting extensions which App Metrics provides. Head over the to [reporting documentation](../reporting/index.md) to see what's available. If you can't find what you're looking for, [open a new github issue](https://github.com/alhardy/AppMetrics.Reporters/issues/new) to discuss adding support.

Out-of-box App Metrics doesn't provide a visualization tool, instead it includes some [generic Grafana dashboards](visualization-grafana.md) for web application monitoring, Grafana does such an amazing job at this already and supports the most popular TSBDs available.

## Getting Started

- Review the [nuget packages available](nuget-packages.md) for web application monitoring.
- Take a look at the out-of-box metrics provided by the [ASP.NET Core Middleware](middleware.md).
- See the web application [getting started guide](../getting-started/intro.md#configuring-a-web-host).

## What's next

- With your web application configured, choose and configure one of the [reporters](../reporting/index.md).
- Now you have your metrics persisted, check out the [Grafana dashboards](visualization-grafana.md) provided.
- Start tracking your own [custom metrics](../getting-started/metric-types/overview.md) and graphing them with Grafana.

### Related Articles

- [ASP.NET Core Real-time Monitoring with InfluxDB and Grafana](https://al-hardy.blog/2017/04/28/asp-net-core-monitoring-with-influxdb-grafana/)
- [Open Source Application Performance Management](https://al-hardy.blog/2017/04/08/open-source-apm/)
