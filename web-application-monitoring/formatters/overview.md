# ASP.NET Core Middleware Response Formatters

App Metric's Middleware supports pluggable formatters which provide the ability to serialize metric and health check data depending on your requirements. This allows the `Metrics` and `Health` endpoints `Content-Types` to be customized.

By allowing for example the `/metrics` endpoint to return metrics in a TSDB specific format, it enables a pull based collection approach rather than push via a reporter. 

Similar formatting options can also be used with the `Text File Reporter` if using a collection agent to flush metrics or the `HTTP Reporter` to push metrics in the required format to a custom HTTP collection endpoint.

## Available Formatters

- [ASCII](ascii-formatter.md)
- [JSON](json-formatter.md)
- [Prometheus](prometheus-formatter.md)
- [InfluxDB](influxdb-formatter.md)
- [ElasticSeach](elasticsearch-formatter.md)
- [Graphite](graphite-formatter.md)

## Implementing a Custom Formatter

Other than the custom serialization code, to wire up a custom formatter to plugin to App Metrics you just need to implement a couple of interfaces, `IHealthResponseWriter` if required, and `IMetricsResponseWriter`.

As a guide, we can look at how to implement a custom JSON formatter:

> [!NOTE]
> For brevity, the code snippets don't include the serialization code, just the required infrastructure code to plug the formatter into App Metrics Middleware.

### Implement the `IMetricsResponseWriter` interface.

[!code-csharp[Main](../../src/samples/AppMetrics.Formatters.CodeSnippets/Custom.cs?end=18)]

### Implement the `IHealthResponseWriter` interface.

[!code-csharp[Main](../../src/samples/AppMetrics.Formatters.CodeSnippets/Custom.cs?start=20&end=37)]

### Exposing the formatter to the App Metrics configuration API

Add extensions methods on `IMetricsHostBuilder` making is easy for users to configure the formatter.

[!code-csharp[Main](../../src/samples/AppMetrics.Formatters.CodeSnippets/Custom.cs?start=39&end=64)]

> [!TIP]
> Implementing a custom metrics text or environment information formatter is the same as above but instead implement the `IMetricsTextResponseWriter` or `IEnvironmentInfoResponseWriter` interfaces.

### Using the Formatter

Modify the application's `Startup.cs` to looking like the following:

[!code-csharp[Main](../../src/samples/AppMetrics.Formatters.CodeSnippets/Custom.cs?start=65)]

> [!TIP]
> In the `IMetricsHostBuilder` extension method code snippet, you'll notice two additional extension methods, `AddCustomJsonMetricsSerialization` and `AddCustomJsonHealthSerialization`. 
> This is useful for applications which want to format health checks differently to metrics for example, such applications can then have a dependency on mulitple formatter packages.
