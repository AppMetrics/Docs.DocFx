# Web Monitoring Packages

This page provides a brief overview of the packages available in terms of monitoring web applications with App Metrics.

## App.Metrics.Extensions.Middleware

The `App.Metrics.Extensions.Middleware` package provides a set of ASP.NET Core middleware components which will measure metrics such as request rates, errors rates and percentages, OAuth2 client tracking etc by simply installing the package and required startup configuration.

The package also provides various endpoints to a web application:

- `/metrics` - Exposes all metrics using the configured metrics formatting.
- `/health` - Executes all health checks registered to determine the healthiness of the application.
- `/ping` - Used to determine if you can get a successful pont response, useful for load balancers.
- `/metrics-text` - Exposes all metrics using the configured text formatting.
- `/env` - Exposes environment information about the application e.g. OS, Machine Name, Assembly Name, Assembly Version etc.

```console
nuget install App.Metrics.Extensions.Middleware
   ```

## App.Metrics.Extensions.Mvc

The `App.Metrics.Extensions.Mvc` package has a dependency on `App.Metrics.Extensions.Middleware` to automatically measure request rates etc but also provides tracking of attribute based routes for example. The separate package exists so that client applications are not forced to take a depdenency on ASP.NET Core MVC.

```console
nuget install App.Metrics.Extensions.Mvc
   ```

## App.Metrics.Formatters.Json

The `App.Metrics.Formatters.Json` package provides the ability to JSON serialize metrics and/or health results recorded by your application. i.e. allows your `/metrics`, `/metrics-text` or `/health` to return a JSON representation of metrics and/or health results.

```console
nuget install App.Metrics.Formatters.Json
   ```

## App.Metrics.Formatters.Ascii

The `App.Metrics.Formatters.Ascii` package provides the ability to report metrics and/or health results recorded by your application in plain text. i.e. allows your `/metrics`, `/metrics-text` or `/health` to return a plain text representation of metrics and/or health results.

```console
nuget install App.Metrics.Formatters.Ascii
   ```

## App.Metrics.Formatters.ElasticSearch

The `App.Metrics.Formatters.ElasticSearch` package provides the ability to report metrics results recorded by your application as Elasticsearch documents. Can be configured on both the  `/metrics` and `/metrics-text` endpoints.

```console
nuget install App.Metrics.Formatters.ElasticSearch
   ```

## App.Metrics.Formatters.InfluxDB

The `App.Metrics.Formatters.InfluxDB` package provides the ability to report metrics results recorded by your application in InfluxDB Line Protocol format. Can be configured on both the  `/metrics` and `/metrics-text` endpoints.

```console
nuget install App.Metrics.Formatters.InfluxDB
   ```

## App.Metrics.Formatters.Graphite

The `App.Metrics.Formatters.Graphite` package provides the ability to report metrics results recorded by your application in Grahpite Plain Text format. Can be configured on both the  `/metrics` and `/metrics-text` endpoints.

```console
nuget install App.Metrics.Formatters.Graphite
   ```

# Pre ASP.NET Core Web Applications

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