
using System;


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using TradingEngineServer.Core;

// This will build my entire dependency injection container and hosted service for me in one line (very clean and easy)
// I use "using" here because I want to dispose of this engine when the program terminates
// Used to get rid of unmanaged resources like database connections, streams, etc.

using var engine = TradingEngineServerHostBuilder.BuildTradingEngineServer();
TradingEngineServerServiceProvider.ServiceProvider = engine.Services;

// This engine is now an IHost (no longer of type TradingEngineServer)