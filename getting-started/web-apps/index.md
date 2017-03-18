# Web Application Monitoring

App Metrics includes a set of middleware components to automatically track typical metrics used in monitoring a web application. The metrics recorded by thse middleware components are registered under the `Application.HttpRequests` [context](../fundamentals/organizing-metrics.md).

The following are the default metrics recorded:

## Apdex

Monitors the [Application Performance Index](../metric-types/apdex.md) of the web application which allows us to monitor end-user satisfication.

## Errors

The error middleware records the following error metrics:

1. The total number of error requests per http status code.
2. The percentage of overall error requests and percentage of each endpoints error requests. *This is calculated by using a hit percentage gauge which calculates the percentage of failed requests using the one minute rate of error requests and one minute rate overall web requests.*
3. An overall error request rate and error request rate per endpoint.

## Throughput & Response Times

To measure the throughput and response times within a web application, [Timers](../metric-types/timers.md) are registered to record:

1. The overall throughput and request duration of all routes
2. The throughput and request duration per route within the web application

## POST and PUT request sizes

[Histograms](../metric-types/histograms.md) are used to track POST and PUT requests sizes of incomming HTTP requests.

## OAuth2

If your web application is secured with OAuth2, by default App.Metrics will record metrics on a per client basis. This provides some useful insights into clients of your APIs.

1. An overall and per endpoint request rate for each client.
2. An overall and per endpoint error rate for each client.
3. The POST and PUT request sizes for each client.

## Generic Dashboards

Out of box, App.Metrics includes [generic Grafana web application dashboards](https://github.com/alhardy/AppMetrics/tree/1.0.0/sandbox):

### Web Application Monitoring

Includes dynamic template variables to filter graphs by application, datasource and environment.

<img alt="grafana web demo" src="../../images/generic_grafana_dashboard_demo.gif" />

> Grab the dashboard [here](https://github.com/alhardy/AppMetrics/blob/1.0.0/sandbox/App.Metrics.Sandbox-InfluxDB-GenericWeb.json)

### OAuth2 Client Monitoring in a Web Application

Includes dynamic template variables to filter graphs by application, datasource and environment, client_id and endpoint.

<img alt="grafana web oauth2 demo" src="../../images/generic_grafana_oauth2_dashboard_demo.gif" />

> Grab the dashboard [here](https://github.com/alhardy/AppMetrics/blob/1.0.0/sandbox/App.Metrics.Sandbox-InfluxDB-GenericWebOAuth2.json)

> [!NOTE]
> Find other [sample Grafana dashboards](https://github.com/alhardy/AppMetrics.Samples/tree/master/grafana_dashboards) for App.Metrics these can be downloaded and imported into Grafana.

## Related Docs

- [How to configure a Web Host](../intro.md#configuring-a-web-host)
- [How to configure reporting in a Web Host](../reporting/index.md#run-reporting-in-a-web-host)
- [Middleware configuration options](../fundamentals/middleware-configuration.md)