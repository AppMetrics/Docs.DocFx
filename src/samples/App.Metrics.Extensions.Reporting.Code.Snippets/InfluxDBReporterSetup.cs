.AddReporting(factory =>
{
    var influxDbSettings = new InfluxDbReporterSettings
    {
        BaseAddress = new Uri("http://127.0.0.1:8086"),
        Database = "appmetrics",
        ReportInterval = TimeSpan.FromSeconds(10)                        
    };

    factory.AddInfluxDb(influxDbSettings);    
});