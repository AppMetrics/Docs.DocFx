# Reporting & Visualization

There are several TSDB reporting extensions which App Metrics provides, see the **Reporting Extensions** menu on the left.

App Metrics does not include a visualization tool, [Grafana](https://grafana.com/) already does an amazing job of this supporting the most popular Timeseries Databases (TSBDs) available.

## Reporting from an ASP.NET Core Web Application

First head over to the documentation on [web monitoring](../web-application-monitoring/index.md) and review how to configure the reporter for your chosen TSDB.

Next, to run the reporter in a web application, the `UseMetricsReporting` extention method on the `IApplicationBuilder` can be used as show below. 

The extension methods takes the `IApplicationLifetime` instance which is used to run reporting after the application has successfully started up and uses the `lifetime.ApplicationStopping` cancellation token to gracefully end reporting on application shutdown.

[!code-csharp[Main](../src/samples/AppMetrics.Startup.CodeSnippets/StartupWithReporting.cs?highlight=11)]

> [!TIP]
> **Don't see the reporter your looking for?**
>
>
> [Open a new github issue](https://github.com/alhardy/AppMetrics.Reporters/issues/new) to discuss adding support.