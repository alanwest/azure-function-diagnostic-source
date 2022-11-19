using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using OpenTelemetry;

[assembly: FunctionsStartup(typeof(FunctionsOpenTelemetry.Startup))]
namespace FunctionsOpenTelemetry
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var tracerProvider = Sdk.CreateTracerProviderBuilder();
        }
    }
}
