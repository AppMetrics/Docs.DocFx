public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMetrics()
			// .AddAsciiSerialization() - Enables plain text format on the /metrics-text, /metrics, /health and /env endpoints.
			.AddAsciiMetricsSerialization() // Enables plain text format on the /metrics-text endpoint.
			.AddAsciiMetricsTextSerialization() // Enables plain text format on the /metrics endpoint.
			.AddAsciiHealthSerialization() // Enables plain text format on the /health endpont.
			.AddAsciiEnvironmentInfoSerialization() // Enables plain text format on the /env endpont.
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
		app.UseMetrics();
	}
}