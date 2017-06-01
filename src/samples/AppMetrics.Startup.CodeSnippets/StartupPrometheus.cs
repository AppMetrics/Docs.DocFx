public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMetrics()
			// .AddPrometheusProtobufSerialization() - Enables both plain text and protobof formats on the /metrics-text and /metrics endpoints respectively.
			.AddPrometheusPlainTextSerialization() // Enables plain text format on the /metrics-text endpoint.
			.AddPrometheusProtobufSerialization() // Enables protobuf format on the /metrics endpoint.
			.AddJsonHealthSerialization()
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
		app.UseMetrics();
	}
}