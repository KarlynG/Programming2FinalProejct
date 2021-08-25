using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProgrammingFinal.Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Bl.Config
{
    public static class SqlServerDbConfig
    {
        public static IServiceCollection ConfigSqlServerDbContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<ProgrammingFinalContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}
