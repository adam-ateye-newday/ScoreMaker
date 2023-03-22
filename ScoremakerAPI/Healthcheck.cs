using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ScoreMaker.API
{
    public class HealthCheck : IHealthCheck
    {
        private IHttpContextAccessor _httpContextAccessor;

        public HealthCheck(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected bool ShouldForceFail()
        {
            if ((bool)_httpContextAccessor?.HttpContext?.Request?.Query.Keys.Contains("ForceFail", StringComparer.OrdinalIgnoreCase))
            {
                return _httpContextAccessor?.HttpContext?.Request?.Query["ForceFail"].ToString() == "true";
            }

            return false;
        }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = !ShouldForceFail();

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "An unhealthy result."));
        }
    }
}
