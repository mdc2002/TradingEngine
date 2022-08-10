using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                // Start with configuration (be able to add the ability to have options in our services)
                services.AddOptions();
                IServiceCollection serviceCollection1 = services.Configure<TradingEngineServerConfiguration>(context.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));

                // Add singleton objects.
                IServiceCollection serviceCollection = services.AddSingleton<ITradingEngineServer, TradingEngineServer>();

                // Add hosted service (the type that Microsoft's hosting library that we have imported here will rely on inheriting from background service
                services.AddHostedService<TradingEngineServer>();


            }).Build();
    } }
