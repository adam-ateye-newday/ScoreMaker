using System.Net.Mime;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace ScoreMaker.API
{
    public static class HealthCheckExtensions
    {
        public static IEndpointConventionBuilder MapCustomHealthChecks(
            this IEndpointRouteBuilder endpoints, string serviceName)
        {
            return endpoints.MapHealthChecks("/healthcheck", new HealthCheckOptions
            {
                ResponseWriter = async (context, report) =>
                {
                    var result = JsonConvert.SerializeObject(
                        new
                        {
                            status = Enum.GetName(typeof(HealthStatus), report.Entries.First().Value.Status)
                        });
                    context.Response.ContentType = MediaTypeNames.Application.Json;
                    await context.Response.WriteAsync(result);
                }
            });
        }
    }
}
