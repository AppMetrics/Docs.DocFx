_metrics.Measure.Counter.Increment(AppMetricsRegistery.SampleCounter);
_metrics.Measure.Counter.Decrement(AppMetricsRegistery.SampleCounter);

_metrics.Measure.Gauge.SetValue(AppMetricsRegistery.Errors, () => 1);

_metrics.Provider.Histogram.Update(AppMetricsRegistery.SampleHistogram, 1);

_metrics.Provider.Meter.Mark(AppMetricsRegistery.SampleMeter, 1);

using(_metrics.Measure.Timer.Time(AppMetricsRegistery.SampleTimer))
{
    // Do something
}