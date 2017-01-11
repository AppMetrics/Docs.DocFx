# App Metric's Nuget Packages

----------

The `App.Metrics` package provides the core services and application configuration to get you started with instrumenting your code to measure application metrics. This is a .NET Standard Class Library

```console
nuget install App.Metrics -pre
   ```    

----------

The `App.Metrics.Extensions.Middleware` package provides a set of Middleware Components which will measure request rates, errors rates, OAuth Client tracking etc.

For web applications running AspNet MVC or AspNet WebApi (pre AspNet Core), the [.NET 4.5.2 packages](./nuget-packages.html#pre-aspnet-core-web-applications) can be used as a replacement, `App.Metrics.Extensions.Middleware` requires AspNet Core.
    
```console
nuget install App.Metrics.Extensions.Middleware -pre
   ```    

----------

The `App.Metrics.Extensions.Mvc` package has a dependancy on `App.Metrics.Extensions.Middleware` to automatically measure request rates etc but also provides tracking of attribute based routes for example. 
    
```console
nuget install App.Metrics.Extensions.Mvc -pre
   ```       

----------

The `App.Metrics.Formatters.Json` package privates the abliity to json serializer/deserializer metrics recorded by your application. 

```console
nuget install App.Metrics.Formatters.Json -pre
   ```      

----------

The `App.Metrics.Extensions.Reporting.Console` package is an App Metrics report provider which will output metrics to a console at a specified interval.

```console
nuget install App.Metrics.Extensions.Reporting.Console -pre
   ```          

----------

The `App.Metrics.Extensions.Reporting.TextFile` package is an App Metrics report provider which will output metrics to a text file at a specified interval.

```console
nuget install App.Metrics.Extensions.Reporting.TextFile -pre
   ```

----------

The `App.Metrics.Extensions.Reporting.InfluxDB` package is an App Metrics report provider which will flush metrics to a [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/) at a specified interval.

```console
nuget install App.Metrics.Extensions.Reporting.InfluxDB -pre
   ```   

## Pre AspNet Core Web Applications

- [Source Code](https://github.com/alhardy/AppMetrics.Owin)
- [Samples](https://github.com/alhardy/AppMetrics.Samples/blob/master/AppMetrics.Samples.NET452.sln)

----------

The `App.Metrics.Extensions.Owin` package package provides a set of Owin Middleware Components which will measure request rates, errors rates, OAuth Client tracking etc. This is the OWIN equivalent to [AspNet Core Middleware](https://www.nuget.org/packages/App.Metrics.Extensions.Middleware/).
    
```console
nuget install App.Metrics.Extensions.Owin -pre
   ```       

----------

----------

The `App.Metrics.Extensions.Owin.Mvc` package has a dependancy on `App.Metrics.Extensions.Owin` an simply provides some AspNet MVC specific extensions allowing `App.Metrics.Extensions.Owin` to determine the route template of requests.
    
```console
nuget install App.Metrics.Extensions.Mvc -pre
   ```       

----------

----------

The `App.Metrics.Extensions.Owin.WebApi` package has a dependancy on `App.Metrics.Extensions.Owin` an simply provides some AspNet WebApi specific extensions allowing `App.Metrics.Extensions.Owin` to determine the route template of requests.
    
```console
nuget install App.Metrics.Extensions.WebApi -pre
   ```       

----------