using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Test.Backend.Dotnet1.Api.HealthChecks;
public class ReadinessCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        // CHECK FOR ANY DEPENDENCIES FOR READINESS
        return Task.FromResult(HealthCheckResult.Healthy("OK"));
    }
}