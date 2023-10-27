using TradingEngineServer.Core;

using var engine = TradingEngineServerHostBuilder.BuildTradingEngineServer();
TradingEngineServerServiceProvider.ServiceProvider = engine.Services;