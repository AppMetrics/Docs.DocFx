public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMetrics(options => {
                options.DefaultContextLabel = "MyContext";
                options.WithGlobalTags((globalTags, envInfo) =>
                {
                    globalTags.Add("host", envInfo.HostName);
                    globalTags.Add("machine_name", envInfo.MachineName);
                    globalTags.Add("app_name", envInfo.EntryAssemblyName);
                    globalTags.Add("app_version", envInfo.EntryAssemblyVersion);
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