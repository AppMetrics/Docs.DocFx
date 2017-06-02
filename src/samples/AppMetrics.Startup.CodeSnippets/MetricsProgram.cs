public class Host
{ 
    public static void Main()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        ConfigureMetrics(serviceCollection);
        
        var provider = serviceCollection.BuildServiceProvider();
        provider.GetRequiredService<IMetrics>();
        
        var metrics = provider.GetRequiredService<IMetrics>();

        // TODO: use metrics to start measuring metrics
                    
        var reporterFactory = provider.GetRequiredService<IReportFactory>();
        var reporter = reporterFactory.CreateReporter();
        // Will continue to run for the configured report internal
        reporter.RunReports(metrics);           

        Console.ReadKey();
    }

    private static void ConfigureMetrics(IServiceCollection services)
    {
        services
            .AddMetrics()
            .AddHealthChecks()
            .AddReporting(factory =>
            {                    
                factory.AddConsole(
                    new ConsoleReporterSettings
                    {
                        ReportInterval = TimeSpan.FromSeconds(20),
                    },                    
                    new AsciiMetricPayloadBuilder());
            });
    }

    private static void ConfigureServices(IServiceCollection services)
    {                      
        var loggerFactory = new LoggerFactory();
        loggerFactory.AddConsole((l, s) => s == LogLevel.Trace);            
        services.AddSingleton<ILoggerFactory, LoggerFactory>();
        services.AddLogging();            
    }       
} 