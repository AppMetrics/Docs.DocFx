# Apdex

[Apdex](https://en.wikipedia.org/wiki/Apdex)(Application Performance Index) allows us to monitor end-user satisfaction. It is an open industry standard that estimates the end user's satisfaction level on an application's response time through a score between 0 and 1.

The Apdex score is calculated based on your required SLA where you can define a response time threshold of T seconds, where all responses handled in T or less seconds satisfy the end user.

Apdex provides three thresholds estimating end user satisfaction, `satisfied`, `tolerating` and `frustrating`.

- **Satisfied:** Response time less than or equal to T seconds.
- **Tolerating:** Response time between T seconds and 4T seconds.
- **Satisfied:** Response time greater than 4 T seconds.

App Metrics caculates the counts of the three thresholds using a [Histogram](histograms.md) to sample data recorded. The value T seconds, histogram sample size and [reservoir sampling](../sampling/index.md) type can be configured when creating the `ApdexOptions`.


> [!NOTE]
> The Apdex score between 0 and 1 is calculated using the following:
> 
> (Satisfied requests + (Tolerating requests / 2))) / Total number of requests


## Using Apdex

[!code-csharp[Main](../../src/samples/AppMetrics.Metric.Code.Snippets/Apdex.cs?start=3&end=13)]

Which for example when using the [JSON formatter](../intro.md#configuring-a-web-host) would result in something similar to:

[!code-json[Main](../../src/samples/App.Metrics.Formatters.Json.Samples/ApdexExample.json)]    

When using the `App.Metrics.Extensions.Middleware` or `App.Metrics.Extensions.Mvc` package, an apdex score will be providing as shown above based on all requests. However you could also record an apdex score for any other request independently, which could be useful if for example if mulitple clients where using the same api, one with access to all endpoints and the other with access to a subset of endpoints, this would then allow us to report an SLA targetting each client.

> [!NOTE]
> To visualize apdex, setup [InfluxDB](https://www.influxdata.com/time-series-platform/influxdb/) and [Grafana](https://grafana.net/) on your local environment, import the `Api.InfluxDB.Sample.Apdex.json` sample dashboard into Grafana and run of the `Api.InfluxDB.Sample` sample application.

Here is the result of running the sample and viewing in Grafana

<img alt="grafana apdex demo" src="../../images/grafana_apdex.png" />

> [!NOTE]
> We can see in the image above that at the time when there were many frustrating requests the apdex as in the critial threshold at the bottom left of the dashboards, as these requests dropped of and the number of satisfied requests increased the apdex score began to increase towards one.

## Related Docs

- [Getting Started](../intro.md#measuring-application-metrics)
- [Configuration](../fundamentals/configuration.md)