public class CustomJsonMetricsResponseWriter : IMetricsResponseWriter
{
	private readonly IMetricDataSerializer _serializer;

	public CustomJsonMetricsResponseWriter(IMetricDataSerializer serializer)
	{
		_serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
	}
	
	public string ContentType => "application/vnd.app.metrics.v1.custom.metrics+json";

	public Task WriteAsync(HttpContext context, MetricsDataValueSource metricsData, CancellationToken token = default(CancellationToken))
	{
		var json = _serializer.Serialize(metricsData);

		return context.Response.WriteAsync(json, token);
	}
}

public class CustomJsonHealthResponseWriter : IHealthResponseWriter
{
	private readonly IHealthStatusSerializer _serializer;

	public CustomJsonHealthResponseWriter(IHealthStatusSerializer serializer)
	{
		_serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
	}
	
	public string ContentType => "application/vnd.app.metrics.v1.custom.health+json";

	public Task WriteAsync(HttpContext context, HealthStatus healthStatus, CancellationToken token = default(CancellationToken))
	{
		var json = _serializer.Serialize(healthStatus);

		return context.Response.WriteAsync(json, token);
	}
}

public static class MetricsHostExtensions
{
	public static IMetricsHostBuilder AddCustomJsonHealthSerialization(this IMetricsHostBuilder host)
	{
		host.Services.Replace(ServiceDescriptor.Transient<IHealthResponseWriter, JsonHealthResponseWriter>());
		host.Services.Replace(ServiceDescriptor.Transient<IHealthStatusSerializer, HealthStatusSerializer>());

		return host;
	}	

	public static IMetricsHostBuilder AddCustomJsonMetricsSerialization(this IMetricsHostBuilder host)
	{
		host.Services.Replace(ServiceDescriptor.Transient<IMetricsResponseWriter, JsonMetricsResponseWriter>());
		host.Services.Replace(ServiceDescriptor.Transient<IMetricDataSerializer, MetricDataSerializer>());

		return host;
	}

	public static IMetricsHostBuilder AddCustomJsonSerialization(this IMetricsHostBuilder host)
	{
		host.AddJsonHealthSerialization();
		host.AddJsonMetricsSerialization();

		return host;
	}
}

public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddMetrics()
			.AddCustomJsonSerialization()
			.AddHealthChecks()
			.AddMetricsMiddleware();
	}

	public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
	{            
		app.UseMetrics();
	}
}