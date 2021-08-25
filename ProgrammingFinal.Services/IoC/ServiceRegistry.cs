using Microsoft.Extensions.DependencyInjection;
using ProgrammingFinal.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IVendorsService, VendorsService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IEntriesService, EntriesService>();
            services.AddScoped<IBillingService, BillingService>();
            services.AddScoped<IEventLogService, EventLogService>();
        }
    }
}
