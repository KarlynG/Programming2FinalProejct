using Microsoft.Extensions.DependencyInjection;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientsRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            services.AddScoped<IVendorsRepository, VendorsRepository>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<IEntriesRepository, EntriesRepository>();
            services.AddScoped<IBillingRepository, BillingRepository>();
            services.AddScoped<IEventLogRepository, EventLogRepository>();
        }
    }
}
