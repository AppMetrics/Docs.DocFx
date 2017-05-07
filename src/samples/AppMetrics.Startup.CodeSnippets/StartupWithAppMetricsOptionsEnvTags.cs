public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMetrics(options => {
                options.DefaultContextLabel = "MyContext";
                options.WithGlobalTags((globalTags, envInfo) =>
                {                    
                    globalTags.Add("server", envInfo.MachineName);
                    globalTags.Add("app", envInfo.EntryAssemblyName);
                    // Assumes _env is the IHostingEnvironment
                    globalTags.Add("env", _env.IsStaging() ? "stage" : _env.IsProduction() ? "prod" : "dev");
                });  	
            })
            .AddJsonSerialization()
            .AddHealthChecks()
            .AddMetricsMiddleware();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {	        
        app.UseMetrics();
    }
}