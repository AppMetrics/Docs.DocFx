public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMetrics()
			// .AddInfluxDBLineProtocolSerialization() - Enables line protocol format on the /metrics-text and /metrics endpoints respectively.
			.AddInfluxDBLineProtocolMetricsTextSerialization() // Enables line protocol format on the /metrics-text endpoint.
			.AddInfluxDBLineProtocolMetricsSerialization() // Enables line protocol format on the /metrics endpoint.
			.AddAsciiHealthSerialization()
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
		app.UseMetrics();
	}
}