# Web Application Monitoring via ASP.NET Core Middleware

App Metrics includes a set of middleware components to automatically track typical metrics used in monitoring a web application. The metrics recorded by thse middleware components are registered under the `Application.HttpRequests` [Metric Context](../getting-started/fundamentals/organizing-metrics.md) by default.

The following are the default metrics recorded:

## Apdex

Monitors the [Application Performance Index](../getting-started/metric-types/apdex.md) of the web application which allows us to monitor end-user satisfication.

## Errors

The error middleware records the following error metrics:

1. The total number of error requests per http status code.
2. The percentage of overall error requests and percentage of each endpoints error requests.
3. An overall error request rate and error request rate per endpoint.

> [!TIP]
> There are several types of [Gauges](https://alhardy.github.io/app-metrics-docs/getting-started/metric-types/gauges.html) provided by App Metrics, a Hit Percentage Gauge is used for example to calculate the request error rate percentage by calculating the percentage of failed requests using the one minute rate of error requests and the one minute rate of overall web requests.

## Throughput & Response Times

To measure the throughput and response times within a web application, [Timers](../getting-started/metric-types/timers.md) are registered to record:

1. The overall throughput and request duration of all routes
2. The throughput and request duration per route within the web application

## POST and PUT request sizes

[Histograms](../getting-started/metric-types/histograms.md) are used to track POST and PUT requests sizes of incomming HTTP requests.

## OAuth2

If your web application is secured with OAuth2, by default App.Metrics will record metrics on a per client basis. This provides some useful insights into clients of your APIs.

1. An overall and per endpoint request rate for each client.
2. An overall and per endpoint error rate for each client.
3. The POST and PUT request sizes for each client.

## Related Docs

- [How to configure a Web Host](../getting-started/intro.md#configuring-a-web-host)
- [How to configure reporting in a Web Host](../reporting/index.md#run-reporting-in-a-web-host)
- [Metric Types](../getting-started/metric-types/overview.md)