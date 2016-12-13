public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMetrics(options => {
                options.DefaultContextLabel = "MyContext",
                options.DefaultSamplingType = SamplingType.SlidingWindow;                        	
            }, Configuration.GetSection("AppMetrics"))
            .AddJsonSerialization()
            .AddHealthChecks()
            .AddMetricsMiddleware();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {	        
        app.UseMetrics();
    }
}