// Gauge Basic

var processPhysicalMemoryGauge = new GaugeOptions
{
    Name = "Process Physical Memory",
    MeasurementUnit = Unit.Bytes
}

var process = Process.GetCurrentProcess();

_metrics.Measure.Gauge.SetValue(MetricsRegistry.Gauges.TestGauge, () => process.WorkingSet64);

// Gauge Advanced

// Derived

var process = Process.GetCurrentProcess();

var processPhysicalMemoryGauge = new GaugeOptions
{
    Name = "Process Physical Memory (MB)",
    MeasurementUnit = Unit.MegaBytes
};

var physicalMemoryGauge = new FunctionGauge(() => process.WorkingSet64);

_metrics.Measure.Gauge.SetValue(MetricsRegistry.Gauges.DerivedGauge,
        () => new DerivedGauge(physicalMemoryGauge, g => g / 1024.0 / 1024.0));

// Ratio

var cacheHits = _metrics.Provider.Meter.Instance(MetricsRegistry.Meters.CacheHits);
var calls = _metrics.Provider.Timer.Instance(MetricsRegistry.Timers.DatabaseQueryTimer);

var cacheHit = Rnd.Next(0, 2) == 0;

using (calls.NewContext())
{
    if (cacheHit)
    {
        cacheHits.Mark();
    }

    Thread.Sleep(cacheHit ? 10 : 100);
}

_metrics.Measure.Gauge.SetValue(MetricsRegistry.Gauges.CacheHitRatioGauge, () => new HitRatioGauge(cacheHits, calls, m => m.OneMinuteRate));