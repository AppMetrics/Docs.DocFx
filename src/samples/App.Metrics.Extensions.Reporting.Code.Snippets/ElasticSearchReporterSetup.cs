.AddReporting(factory =>
{
    factory.AddElasticSearch(new ElasticSearchReporterSettings
    {
        HttpPolicy = new HttpPolicy
        {
            FailuresBeforeBackoff = 3,
            BackoffPeriod = TimeSpan.FromSeconds(30),
            Timeout = TimeSpan.FromSeconds(3)
        },
        ElasticSearchSettings = new ElasticSearchSettings(new Uri("http://localhost:9200"), "metrics"),
        ReportInterval = TimeSpan.FromSeconds(5)
    });
})