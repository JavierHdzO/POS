using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Context;

namespace POS.Infrastructure.Extensions;

public static class InjectionExtenions
{
    public static IServiceCollection AddInjectionInfraetructure(this IServiceCollection services, IConfiguration configuration  ) 
    {

        var assembly = typeof(PosContext).Assembly.FullName;

        services.AddDbContext<PosContext>(opt =>
            opt.UseSqlServer(
                configuration.GetConnectionString("POSConnection"),
                b => b.MigrationsAssembly(assembly)),
                ServiceLifetime.Transient
            );

        return services;
    }
} 
