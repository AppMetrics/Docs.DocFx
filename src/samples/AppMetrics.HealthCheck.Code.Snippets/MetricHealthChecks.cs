public void ConfigureServices(IServiceCollection services)
{
    services.AddMetrics()        
        .AddHealthChecks(factory =>
        {
            factory.RegisterMetricCheck(
                                 name: "Overall Response Time",
                                 options: MyMetricsRegistry.OverallWebRequestTimer,                                 
                                 passing: value => (message: $"OK. 98th Percentile < 100ms ({value.Histogram.Percentile98}{MyMetricsRegistry.OverallWebRequestTimer.DurationUnit.Unit()})", result: value.Histogram.Percentile98 < 100),
                                 warning: value => (message: $"WARNING. 98th Percentile > 100ms ({value.Histogram.Percentile98}{MyMetricsRegistry.OverallWebRequestTimer.DurationUnit.Unit()})", result: value.Histogram.Percentile98 < 200),
                                 failing: value => (message: $"FAILED. 98th Percentile > 200ms ({value.Histogram.Percentile98}{MyMetricsRegistry.OverallWebRequestTimer.DurationUnit.Unit()})", result: value.Histogram.Percentile98 > 200));
        });        
}