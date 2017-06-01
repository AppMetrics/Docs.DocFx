public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMetrics()
			// .AddDefaultElasticsearchSerialization() - Enables an elasticsearach document format on the /metrics-text and /metrics endpoints respectively.
			.AddElasticsearchMetricsTextSerialization() // Enables elasticsearach document format on the /metrics-text endpoint.
			.AddElasticsearchMetricsSerialization() // Enables elasticsearach document format on the /metrics endpoint.
			.AddAsciiHealthSerialization()
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
		app.UseMetrics();
	}
}