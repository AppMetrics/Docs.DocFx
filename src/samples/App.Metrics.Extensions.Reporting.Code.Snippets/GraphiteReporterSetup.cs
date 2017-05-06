.AddReporting(factory =>
{
    factory.AddGraphite(new GraphiteReporterSettings
    {
        HttpPolicy = new HttpPolicy
        {
            FailuresBeforeBackoff = 3,
            BackoffPeriod = TimeSpan.FromSeconds(30),
            Timeout = TimeSpan.FromSeconds(3)
        },
        GraphiteSettings = new GraphiteSettings(new Uri("net.tcp://127.0.0.1:2003")),
        ReportInterval = TimeSpan.FromSeconds(5)
    });
})