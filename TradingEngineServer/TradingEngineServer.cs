using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TradingEngineServer.Core
{
    internal class TradingEngineServer : BackgroundService, ITradingEngineServer
    {
        private readonly ILogger<TradingEngineServer> _logger;
        public TradingEngineServer(ILogger<TradingEngineServer> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                throw new NotImplementedException();
            }
        }
    }
}