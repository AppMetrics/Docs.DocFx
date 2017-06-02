.AddReporting(factory =>
{
    factory.AddTextFile(
        new TextFileReporterSettings
        {
            ReportInterval = TimeSpan.FromSeconds(5),
            FileName = @"C:\metrics\sample.txt"
        },
        new MyCustomPayloadBuilder());
})