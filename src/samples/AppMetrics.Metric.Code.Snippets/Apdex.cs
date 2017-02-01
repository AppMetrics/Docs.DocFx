// Apdex Basic

var apdex = new ApdexOptions
{
    Name = "Sample Apdex",
    ApdexTSeconds = 0.5 // Adjust based on your SLA    
};

using (_metrics.Measure.Apdex.Track(MetricsRegistry.ApdexScores.TestApdex))
{
    // Method to track apdex score for
}