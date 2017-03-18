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
            // Check connectivity to google with a "ping", passes if the result is `IPStatus.Success`
            factory.RegisterPingHealthCheck("google ping", "google.com", TimeSpan.FromSeconds(10));
            // Check connectivity to github by ensuring the GET request results in `IsSuccessStatusCode`
            factory.RegisterHttpGetHealthCheck("github", new Uri("https://github.com/"), TimeSpan.FromSeconds(10));
        })
        .AddMetricsMiddleware();
}