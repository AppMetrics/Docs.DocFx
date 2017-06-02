public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMvc(options => options.AddMetricsResourceFilter());
		
		services.AddMetrics()
			// .AddJsonSerialization() - Enables json format on the /metrics-text, /metrics, /health and /env endpoints.
			.AddJsonMetricsSerialization() // Enables json format on the /metrics-text endpoint.
			.AddJsonMetricsTextSerialization() // Enables json format on the /metrics endpoint.
			.AddJsonHealthSerialization() // Enables json format on the /health endpont.
			.AddJsonEnvironmentInfoSerialization() // Enables json format on the /env endpont.
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
        app.UseMetrics();
		app.UseMvc();
	}
}