# Getting started

This page contains two quick start guides to getting started with App Metrics. The first demonstrates how to get started in a web application and the second how to get started in a console application.

## Configuring a Web Host

App Metrics includes ASP.NET Core middleware which will collect typical metrics related to a web application. See the [middleware documentation](../web-application-monitoring/middleware.md) for more details.

The following steps assume you have already created a [new ASP.NET Core MVC or API project](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc).

### Step 1

Add the [App.Metrics](https://www.nuget.org/packages/App.Metrics/), [App.Metrics.Extensions.Middleware](https://www.nuget.org/packages/App.Metrics.Extensions.Middleware/) and [App.Metrics.Formatters.Json](https://www.nuget.org/packages/App.Metrics.Formatters.Json/) nuget packages to your project.

```console
nuget install App.Metrics

nuget install App.Metrics.Extensions.Middleware

nuget install App.Metrics.Formatters.Json
```

### Step 2

App Metrics is configured using the typical pattern to provide services and configuration to an ASP.NET Core project by adding required services to the `ConfigureServices` method in the `Startup.cs`

Modify your `Startup.cs` with the following:

[!code-csharp[Main](../src/samples/AppMetrics.Startup.CodeSnippets/Startup.cs)]

> [!NOTE]
> The `AddMetricsResourceFilter` extension method on `MvcOptions` is required to allow App Metrics to inspect route template information to tag metrics.

### Step 3

Run your web application and request the following urls.

|Endpoint|Description|
|------|:--------|
|`/ping`|Used to determine if you can get a successful pont response, useful for load balancers.
|`/metrics`|Renders all metrics using the configured `IMetricsDataSerializer`, in our case in json format.
|`/metrics-text`|Renders a Humannized version of the metric data captured by the application.
|`/health`|Executes all health checks registered to determine the health status of the application.

> [!TIP]
> Metrics formatting is pluggable, see the App Metrics Middleware Formatter docs on how to [implement a custom formatter](../web-application-monitoring/formatters/overview.md#implementing-a-custom-formatter) or what other [formatting options are available](../web-application-monitoring/formatters/overview.md#available-formatters).

> [!TIP]
> See the App Metrics Health Check docs on how to [implement health checks](health-checks/index.md#implementing-a-health-check).

## Configuring a Console Application

App Metrics can also be used outside a web context. Create a new console application and follow the steps below.

### Step 1

Add the [App.Metrics](https://www.nuget.org/packages/App.Metrics/) and [App.Metrics.Extensions.Reporting.Console](https://www.nuget.org/packages/App.Metrics.Extensions.Reporting.Console/) nuget packages to your project.

```console
nuget install App.Metrics

nuget install App.Metrics.Extensions.Reporting.Console
```

### Step 2

Modify your `Program.cs` with the following:

[!code-csharp[Main](../src/samples/AppMetrics.Startup.CodeSnippets/MetricsProgram.cs)]

### Step 3

Replace the `// TODO: use metrics to start measuring metrics` comment in the above snippet with code that [records metrics](./fundamentals/recording-metrics.md#recording-metrics-using-an-imetrics-instance) and run your application.

## Notes on the IServiceCollection extensions

|Extension|Description|
|------|:--------|
|`AddMetrics`|Registers App Metrics services with the `IServiceCollection`. This method also also provides options to change the default metrics configuration if you wish to do so.
|`AddHealthChecks`|Registers the Health Checking sytem, it will scan for classes within the project and any other project which has a reference to App Metrics and register any class which inherits `HealthCheck`. Alternatively, this method also provides access to the `IHealthCheckFactory` where you can register health checks inline.
|`AddMetricsMiddleware`|Registers middleware components providing serveral metrics related endpoints show in the next step.
|`AddReporting`|Provides access to the `IReportFactory` allowing multiple metric report providers to be configured that will execute on each report run at the specified interval.

## Related Articles

- [ASP.NET Core Real-time Monitoring with InfluxDB and Grafana](https://al-hardy.blog/2017/04/28/asp-net-core-monitoring-with-influxdb-grafana/)