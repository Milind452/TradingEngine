using Microsoft.Extensions.Hosting;

namespace TradingEngineServer.Core
{
    internal class TradingEngineServer : BackgroundService, ITradingEngineServer
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                throw new NotImplementedException();
            }
        }
    }
}