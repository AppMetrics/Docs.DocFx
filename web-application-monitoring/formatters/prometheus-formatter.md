# ASP.NET Core Middleware Prometheus Formatting

If using [Prometheus](https://prometheus.io/) for persisting metrics, you'll find that Prometheus promotes a *Pull* rather than *Push* based model. We therefore need to have the `/metrics` endpoint return data formatted for Prometheus. Prometheus supports metric data as plain text or protobuf, App Metrics supports both of these formats whereby `/metrics-text` will return metrics in Prometheus plain text format and `/metrics` will return metrics in Prometheus protobuf format.

To add enable metric serialization supporting Prometheus:

1. Add the [App.Metrics.Formatters.Prometheus](https://www.nuget.org/packages/App.Metrics.Formatters.Prometheus/) nuget package to your ASP.NET Core web application.
1. Configure Protobuf & Plain Text Prometheus serialization in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupPrometheus.cs?highlight=6,7,8)]

> [!NOTE]
> Notice the above is still using the App.Metrics.Formatters.Json package for health check serialization through `AddJsonHealthSerialization`.