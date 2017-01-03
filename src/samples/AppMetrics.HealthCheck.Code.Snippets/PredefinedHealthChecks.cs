public void ConfigureServices(IServiceCollection services)
{
    var threshold = 1;

    services.AddMetrics()
        .AddJsonSerialization()
        .AddHealthChecks(factory =>
        {
            // Check that the current amount of private memory in bytes is below a threshold
            factory.RegisterProcessPrivateMemorySizeHealthCheck("Private Memory Size", threshold);
            // Check that the current amount of virtual memory in bytes is below a threshold
            factory.RegisterProcessVirtualMemorySizeHealthCheck("Virtual Memory Size", threshold);
            // Check that the current amount of physical memory in bytes is below a threshold
            factory.RegisterProcessPhysicalMemoryHealthCheck("Working Set", threshold);            
        })
        .AddMetricsMiddleware();
}