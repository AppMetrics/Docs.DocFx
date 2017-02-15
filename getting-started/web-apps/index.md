# Web Application Monitoring

App Metrics includes a set of middleware components to automatically track typical metrics used in monitoring a web application. The metrics recorded by thse middleware components are registered under the `Application.HttpRequests` [context](../fundamentals/organizing-metrics.md).

The following are the default metrics recorded:

## Apdex

Monitors the [Application Performance Index](../metric-types/apdex.md) of the web application which allows us to monitor end-user satisfication.

## Errors

The error middleware records the following error metrics:

1. A [Meter](../metric-types/meters.md) measuring the error rate per route tagged by http status code
2. A [Meter](../metric-types/meters.md) measuring the web applications overall error rate tagged by http status code
3. A [Gauge](../metric-types/gauges.md) measuring the web applications overall percentage of failing requests. This is calculated by using a hit percentage gauge which calculates the percentage of failed requests using the one minute rate of error requests and one minute rate overall web requests.

## Throughput & Web Transaction Time

To measure the throughput and web transaction times within a web application, [Timers](../metric-types/timers.md) are registered to record:

1. The overall throughput and request duration of all routes
2. The throughput and request duration per route within the web application

## POST and PUT request sizes

A [Histogram](../metric-types/histograms.md) is used to track POST and PUT requests sizes of incomming HTTP requests.

## OAuth2

If your web application is secured with OAuth2, by default, error rates and the throughput (overall and per route) is tracked on a per client basis. This provides some useful insights into clients of your APIs.

## Sample Dashboard

Below is a sample Grafana dashboard showing showing some of the above metrics.

<img alt="grafana demo" src="../../images/web_host_grafana.png" />

> [!NOTE]
> All [sample dashboards](https://github.com/alhardy/AppMetrics.Samples/tree/master/grafana_dashboards) mentioned in the documenation can be downloaded and imported into Grafana.

## Related Docs

- [How to configure a Web Host](../intro.md#configuring-a-web-host)
- [How to configure reporting in a Web Host](../reporting/index.md#run-reporting-in-a-web-host)
- [Middleware configuration options](../fundamentals/middleware-configuration.md)