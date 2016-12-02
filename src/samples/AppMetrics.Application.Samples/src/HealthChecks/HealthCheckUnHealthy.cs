using System.Threading.Tasks;
using App.Metrics.Core;

namespace HealthChecks
{
    public class HealthCheckUnHealthy : HealthCheck
    {
        public HealthCheckUnHealthy() : base("Referencing Assembly - Sample UnHealthy")
        {
        }

        protected override Task<HealthCheckResult> CheckAsync()
        {
            return Task.FromResult(HealthCheckResult.Unhealthy("OOPS"));
        }
    }
}