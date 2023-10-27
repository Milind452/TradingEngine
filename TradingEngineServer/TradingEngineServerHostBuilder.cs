using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer() =>
            Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                // Configuration
                services.AddOptions();
                services.Configure<TradingEngineServerConfiguration>(
                    context.Configuration.GetSection(nameof(TradingEngineServerConfiguration))
                );

                // Register Singleton Objects
                services.AddSingleton<ITradingEngineServer, TradingEngineServer>();

                // Register Hosted Services
                services.AddHostedService<TradingEngineServer>();
            }).Build();
    }
}