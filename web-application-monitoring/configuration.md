# AspNet Middleware Configuration Options

App Metrics includes an AspNet Middleware Extension package which will record web metrics such as, error rates and percentages, per endpoint and an overall request rates etc.

Configuration options are accessible through the `AddMetricsMiddleware` extension on the `IMetricsHostBuilder`.

These configuration options include:

|Property|Description|
|------|:--------|
|**HealthEndpoint**|Allows customization of the endpoint which will report the health status of the application. The default path is `/health`.
|**HealthEndpointEnabled** |Allows enabling/disabling of the `/health` endpoint, when disabled will result in a 404 status code, the default is true.
|**IgnoredRoutesRegexPatterns**|The AspNet Middleware Extension measures for example a Timer metric for each request, specific endpoints can be ignored by providing an `IList<string>` of regex patterns.
|**MetricsEndpoint** |Allows customization of the endpoint which will report a snapshot of the applications current metric measurements. The default path is `/metrics`.
|**MetricsEndpointEnabled**|Allows enabling/disabling of the `/metrics` endpoint, when disabled will result in a 404 status code, the default is true.
|**MetricsTextEndpoint**|Allows customization of the endpoint which will report a snapshot of the applications current metric measurements in a hummanized format. The default path is `/metrics-text`.
|**MetricsTextEndpointEnabled**|Allows enabling/disabling of the `/metrics-text` endpoint, when disabled will result in a 404 status code, the default is true.
|**OAuth2TrackingEnabled**|Allows recording of all OAuth2 Client tracking to be disabled. When enabled middleware is configured to track request rates, an overall percentage of requests per Client / per endpoint, and error rates per Client.
|**DefaultTrackingEnabled**|Allows enabling/disabling of the default [tracking middleware](https://github.com/alhardy/AppMetrics/tree/master/src/App.Metrics.Extensions.Middleware). If disabled all metrics endpoints are still enabled, by default all tracking middleware is enabled.
|**PingEndpoint**|Allows customization of the ping endpoint which simply returns pong. The default path is `/ping`.
|**PingEndpointEnabled**|Allows enabling/disabling of the `/ping` endpoint, when disabled will result in a 404 status code, the default is true.
|**ApdexTrackingEnabled**|Allows enabling/disabling of calculating the [Apdex](../getting-started/metric-types/apdex.md) score of a web application, the default is true.
|**ApdexTSeconds**|The [Apdex](../getting-started/metric-types/apdex.md) T seconds value used in calculating the score on the samples collected.
|**IgnoredHttpStatusCodes**|Allows specific http status codes to be ignored when reporting on request failes, e.g. You might not want to alert on 400 status codes or monitor 404 status codes.

## Fluent configuration using `Action<AspNetMetricsOptions>`

[!code-csharp[Main](../src/samples/AppMetrics.Startup.CodeSnippets/StartupWithAspNetOptions.cs?highlight=10)]

> [!TIP]
> If you require some configuration to be environment specific (e.g. disabling metrics in a uat environment) and therefore would pefer some options in `appsettings`, the middleware extension has a couple of overrides supporting options from both `Action<AspNetMetricsOptions>` and `Microsoft.Extensions.Configuration.IConfiguration`.

## Configuration using `Microsoft.Extensions.Configuration.IConfiguration`

An alternative to configuring options through `Action<AspNetMetricsOptions>`, options can also be registered using Microsoft's configuration extensions for example providing an app settings section.

Below is an example `Startup.cs` using `appsettings.json` as a configuration source:

[!code-csharp[Main](../src/samples/AppMetrics.Startup.CodeSnippets/StartupWithAppMetricsOptionsIConfiguration.cs?highlight=22)]    

And the `appsettings.json` file may looking something like the following:

[!code-json[Main](../src/samples/App.Metrics.Formatters.Json.Samples/AspNetOptions.json)]

> [!NOTE]
> To have ASP.NET Core MVC route names used for metric names, a resource filter is required to determine the matching route template from requests, add the resource filter when configuring the ASP.NET Core MVC services.
> 
> ```csharp
> services.AddMvc(options => options.AddMetricsResourceFilter());
>  ```

## Next Steps

- [App MetricsConfiguration Options](configuration.md)
- [Sample Applications](../samples/index.md)
