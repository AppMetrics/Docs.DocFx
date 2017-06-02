.AddReporting(factory =>
{
    factory.AddHttp(
        new HttpReporterSettings
        {
            // Set the endpoint where metrics should be posted
            HttpSettings = new HttpSettings(new Uri("http://localhost/metrics-receive")),
            ReportInterval = TimeSpan.FromSeconds(5),
            HttpPolicy = new HttpPolicy
                        {                            
                            // The number of http failures to cause a backoff in reporting
                            FailuresBeforeBackoff = 5, 
                            // Duration to backoff if the number of http failures have been reached
                            BackoffPeriod = TimeSpan.FromSeconds(30), 
                            // Timeout of the underlaying HTTP call
                            Timeout = TimeSpan.FromSeconds(3) 
                        }
        },
        // Formats the metrics before sending over HTTP
        new AsciiMetricPayloadBuilder());
})