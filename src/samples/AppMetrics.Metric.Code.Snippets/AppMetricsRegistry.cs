public static class AppMetricsRegistery
{
    public static GaugeOptions Errors { get; } = new GaugeOptions
    {
        Name = "Errors"            
    };

    public static CounterOptions SampleCounter { get; } = new CounterOptions
    {
        Name = "Sample Counter",
        MeasurementUnit = Unit.Calls,
    };

    public static HistogramOptions SampleHistogram { get; } = new HistogramOptions
    {
        Name = "Sample Histogram",
        Reservoir = new Lazy<IReservoir>(() => new DefaultAlgorithmRReservoir()),
        MeasurementUnit = Unit.MegaBytes            
    };

    public static MeterOptions SampleMeter { get; } = new MeterOptions
    {
        Name = "Sample Meter",
        MeasurementUnit = Unit.Calls            
    };

    public static TimerOptions SampleTimer { get; } = new TimerOptions
    {
        Name = "Sample Timer",
        MeasurementUnit = Unit.Items,
        DurationUnit = TimeUnit.Milliseconds,
        RateUnit = TimeUnit.Milliseconds,            
        Reservoir = new Lazy<IReservoir>(() => new DefaultForwardDecayingReservoir(sampleSize:1028, alpha:0.015))
    };
}