# ASP.NET Core Middleware Prometheus Formatting

If using [Prometheus](https://prometheus.io/) for persisting metrics, you'll find that Prometheus promotes a *Pull* rather than *Push* based model. We therefore need to have the `/metrics` endpoint return data formatted for Prometheus. Prometheus supports metric data as plain text or protobuf, App Metrics supports both of these formats.

To add enable metric serilization supporting Prometheus:

1. Add the [App.Metrics.Formatters.Prometheus](https://www.nuget.org/packages/App.Metrics.Formatters.Prometheus/) nuget package to your ASP.NET Core web application.
2. Configure Protobuf serailization in your `Startup.cs`

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupPrometheus.cs?highlight=6)]

> [!NOTE]
> Notice the above is still using the App.Metrics.Formatters.Json package for health check serilization through `AddJsonHealthSerialization`.

> [!TIP]
> To switch to plain text Prometheus serialization, replace `AddPrometheusProtobufSerialization` with `AddPrometheusPlainTextSerialization` in the above snippet