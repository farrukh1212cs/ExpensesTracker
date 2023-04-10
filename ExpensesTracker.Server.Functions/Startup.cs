using ExpensesTracker.Server.Functions.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:FunctionsStartup(typeof(ExpensesTracker.Server.Functions.Startup))]
namespace ExpensesTracker.Server.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = builder.GetContext().Configuration;
            builder.Services.AddCosmosDBClient(config.GetSection("CosmosDbConnection").Value.ToString());
        }
    }
}
