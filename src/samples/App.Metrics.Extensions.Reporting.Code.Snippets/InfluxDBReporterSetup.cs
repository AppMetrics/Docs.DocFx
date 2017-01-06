.AddReporting(factory =>
{
    factory.AddInfluxDb(new InfluxDBReporterSettings
    {
        HttpPolicy = new HttpPolicy
        {
            FailuresBeforeBackoff = 3,
            BackoffPeriod = TimeSpan.FromSeconds(30),
            Timeout = TimeSpan.FromSeconds(3)
        },
        InfluxDbSettings = new InfluxDBSettings("appmetricsapi", new Uri("http://127.0.0.1:8086")),
        ReportInterval = TimeSpan.FromSeconds(5)
    });
})