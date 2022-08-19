using System;
using System.Text.Json;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Tinkoff.InvestApi;
using Tinkoff.InvestApi.V1;

namespace tinkoff_invest_analytics
{
    /// <summary>
    /// Information from Tinkoff Invest
    /// </summary>
    internal class Tinkoff_Info
    {
        static readonly string TOKEN = Environment.GetEnvironmentVariable("TINKOFF_TOKEN");
        static readonly string BROKER_ACCOUNT_ID = Environment.GetEnvironmentVariable("TINKOFF_BROKER_ACCOUNT");
        
        public void GetClient()
        {
            // Собираем ServiceCollection с клиентом
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddInvestApiClient((_, settings) =>
            {
                settings.AccessToken = TOKEN;
            });
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var client = serviceProvider.GetRequiredService<InvestApiClient>();
        }

        public void GetAccounts()
        {
            
        }
    }
}
