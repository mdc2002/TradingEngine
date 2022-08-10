using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Core
{
    public static class TradingEngineServerServiceProvider
    {
        // We are going to have this IServiceProvider accessible to us throughout the entire application in case we need it because its class is static 
        //and because this member variable is static
        public static IServiceProvider ServiceProvider { get; set; }
            
    }
}
