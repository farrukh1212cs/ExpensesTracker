using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Server.Functions.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddCosmosDBClient(this IServiceCollection services,string connectionString)
        {
            services.AddSingleton(sp=> new CosmosClient(connectionString));
        }

       
    }
}
