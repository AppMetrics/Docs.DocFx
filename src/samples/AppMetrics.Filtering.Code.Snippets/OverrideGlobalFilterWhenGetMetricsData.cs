public class MyService
{
    private readonly IMetrics _metrics;

    public MyService(IMetrics metrics)
    {
        _metrics = metrics;
    }

    public MetricsDataValueSource DoSomething()
    {
        var filter = new DefaultMetricsFilter().WhereMetricNameStartsWith("test_");
        return _metrics.Snapshot.Get(filter);
    }
}