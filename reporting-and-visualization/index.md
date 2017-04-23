# Reporting & Visualization

## Reporting from a Web Application

To run the registered reporters in a web application, the `UseMetricsReporting` `IApplicationBuilder` extention method can be used as show below. The extension methods takes the `IApplicationLifetime` instance which is used to run reporting after the application has successfully started up and uses the `lifetime.ApplicationStopping` cancellation token to gracefully end reporting on application shutdown.

[!code-csharp[Main](../../src/samples/AppMetrics.Startup.CodeSnippets/StartupWithReporting.cs?highlight=11)]

> [!NOTE]
> ### Don't see the reporter your looking for?
> Pull requests or more than welcome, for now see the [Console](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Reporting.Console) and [Text File](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Reporting.TextFile) reporters for guidance on implementing a new reporter. 

## Next Steps

- Supported Metrics Types: [Gauges](metric-types/gauges.md), [Counters](metric-types/counters.md), [Meters](metric-types/meters.md), [Histograms](metric-types/histograms.md), [Timers](metric-types/timers.md)
- [Configuration Options](fundamentals/configuration.md)  
- [Nuget Packages](fundamentals/nuget-packages.md)
- [Sample Applications](../samples/index.md)