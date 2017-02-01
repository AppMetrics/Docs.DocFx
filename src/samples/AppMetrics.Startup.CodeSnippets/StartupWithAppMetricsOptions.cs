public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(options => options.AddMetricsResourceFilter());
        
        services.AddMetrics(options => {
                options.DefaultContextLabel = "MyContext",                
                options.GlobalTags.Add("env", "stage");
                options.MetricsEnabled = true;
                options.ReportingEnabled = true;     	
            })
            .AddDefaultReservoir(() => new Lazy<IReservoir>(() => new DefaultSlidingWindowReservoir()))
            .AddJsonSerialization()
            .AddHealthChecks()
            .AddMetricsMiddleware();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {	        
        app.UseMetrics();
    }
}