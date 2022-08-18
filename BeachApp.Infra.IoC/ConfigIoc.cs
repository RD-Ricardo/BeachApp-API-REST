using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BeachApp.Infra.Data.Context;
using BeachApp.Domain.Interfaces.Generic;
using BeachApp.Domain.Entities;
using BeachApp.Infra.Data.Repository;

namespace BeachApp.Infra.IoC
{
    public static class ConfigIoc
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectioMysql = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(c => c.UseMySql(connectioMysql, ServerVersion.AutoDetect(connectioMysql)));
            
            
            // services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericRepository<Product> ), typeof(ProductRepository));
            return services;
        }
    }
}