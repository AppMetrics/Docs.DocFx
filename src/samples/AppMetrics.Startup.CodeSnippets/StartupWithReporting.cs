public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure...
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, IApplicationLifetime lifetime)
    {	        
        app.UseMetrics();
        app.UseMetricsReporting(lifetime);
    }
}