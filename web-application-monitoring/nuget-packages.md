# Web Monitoring Packages

This page provides a brief overview of the packages available in terms of monitoring web applications with App Metrics.

## App.Metrics.Extensions.Middleware

The `App.Metrics.Extensions.Middleware` package provides a set of ASP.NET Core middleware components which will measure metrics such as request rates, errors rates and percentages, OAuth2 client tracking etc by simply installing the package and required startup configuration.

The package also provides various endpoints to a web application:

- `/metrics` - Exposes all metrics as JSON or Protobuf for example.
- `/health` - Executes all health checks registered to determine the healthiness of the application. 
- `/ping` - Used to determine if you can get a successful pont response, useful for load balancers.
- `/metrics-text` - Renders a "humannized" version of the `/metrics` endpoint.


```console
nuget install App.Metrics.Extensions.Middleware
   ```

## App.Metrics.Extensions.Mvc

The `App.Metrics.Extensions.Mvc` package has a dependency on `App.Metrics.Extensions.Middleware` to automatically measure request rates etc but also provides tracking of attribute based routes for example. The separate package exists so that client applications are not forced to take a depdenency on ASP.NET Core MVC.
    
```console
nuget install App.Metrics.Extensions.Mvc
   ```       

## App.Metrics.Formatters.Json

The `App.Metrics.Formatters.Json` package provides the abliity to JSON serializer/deserializer metrics recorded by your application, for example allowing `/metrics` to return a JSON representation metrics.

> [!TIP]
> Using [Prometheus](https://prometheus.io/)? There is an App Metrics [Prometheus extension package](https://www.nuget.org/packages/App.Metrics.Formatters.Prometheus) providing the ability to format metrics in prometheus format, supports protobuf and plain text.

```console
nuget install App.Metrics.Formatters.Json
   ```      

# Pre AspNet Core Web Applications

For those not yet using ASP.NET Core, packages also exist providing the same functionality for OWIN, ASP.NET MVC and ASP.NET Web API

## App.Metrics.Extensions.Owin

This is the OWIN equivalent to [AspNet Core Middleware](https://www.nuget.org/packages/App.Metrics.Extensions.Middleware/).
    
```console
nuget install App.Metrics.Extensions.Owin -pre
   ```       

## App.Metrics.Extensions.Owin.Mvc

The `App.Metrics.Extensions.Owin.Mvc` package has a dependency on `App.Metrics.Extensions.Owin` an simply provides some AspNet MVC specific extensions allowing `App.Metrics.Extensions.Owin` to determine the route template of requests.
    
```console
nuget install App.Metrics.Extensions.Owin.Mvc -pre
   ```       

## App.Metrics.Extensions.Owin.WebApi

The `App.Metrics.Extensions.Owin.WebApi` package has a dependency on `App.Metrics.Extensions.Owin` an simply provides some AspNet WebApi specific extensions allowing `App.Metrics.Extensions.Owin` to determine the route template of requests.
    
```console
nuget install App.Metrics.Extensions.Owin.WebApi -pre
   ```     

> [!NOTE]
> .NET 452 App Metric packages are still targetting App Metrics RC1 due to lack of adoption.

- [Source Code](https://github.com/alhardy/AppMetrics.Owin)
- [Samples](https://github.com/alhardy/AppMetrics.Samples/blob/master/AppMetrics.Samples.NET452.sln)