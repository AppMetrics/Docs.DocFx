# Recording Application Metrics

App Metrics provides access to an `IMetrics` instance, registered as a single instance. This can be injected where required to start recording different types of metrics.

Each metric being measured should be described through one of the below classes, which provides details about the metric being measured.

|Options|Description|
|------|:--------|
|`GaugeOptions`|Allows the metric context, metric name, unit of measurement, and tags to be specified.
|`CounterOptions`|Allows the metric context, metric name, unit of measurement, and tags to be specified.
|`MeterOptions`|Allows the metric context, metric name, unit of measurement, rate unit and tags to be specified.
|`TimerOptions`|Allows the metric context, metric name, unit of measurement, rate unit, duration unit, sampling type and tags to be specified. Also allows a custom `IReservoir` to be used for sampling.
|`HistogramOptions`|Allows the metric context, metric name, unit of measurement, sampling type and tags to be specified. Also allows a custom `IReservoir` to be used for sampling.

*`Name` is the only required property is the property on each metric option instance.*

## Declaring Metrics

[!code-csharp[Main](../../src/samples/AppMetrics.Metric.Code.Snippets/AppMetricsRegistry.cs)]

## Recording Metrics using an `IMetrics` instance

[!code-csharp[Main](../../src/samples/AppMetrics.Metric.Code.Snippets/RecordMetrics.cs)]

## Next Steps

- [Metrics Types](../metric-types/overview.md)
- [Configuration Options](../fundamentals/configuration.md)