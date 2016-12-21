// Apdex Basic

var apdex = new ApdexOptions
{
    Name = "Sample Apdex",
    ApdexTSeconds = 0.5, // Adjust based on your SLA
    SampleSize = 1028 // Histograms sample size, defaults to 1028
};

using (_metrics.Track(MetricsRegistry.ApdexScores.TestApdex))
{
    // Method to track apdex score for
}