# App Metric's Nuget Packages

----------

The `App.Metrics` package provides the core services and application configuration to get you started with instrumenting your code to measure application metrics. This is a .NET Standard Class Library

```console
nuget install App.Metrics -pre
   ```    

----------

The `App.Metrics.Extensions.Middleware` package provides a set of Middleware Components which will measure request rates, errors rates, OAuth Client tracking etc.
    
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