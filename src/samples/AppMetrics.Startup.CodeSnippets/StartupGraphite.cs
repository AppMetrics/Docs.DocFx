public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMetrics()
			// .AddGraphiteSerialization() - Enables graphite plain text format on the /metrics-text and /metrics endpoints respectively.
			.AddGraphiteMetricsTextSerialization() // Enables graphite plain text format on the /metrics-text endpoint.
			.AddGraphiteMetricsSerialization() // Enables graphite plain text format on the /metrics endpoint.
			.AddAsciiHealthSerialization()
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
		app.UseMetrics();
	}
}