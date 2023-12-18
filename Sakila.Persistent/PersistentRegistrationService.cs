using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Sakila.Application.Contracts;
using Sakila.Persistent.Repositories;
using UserMap.Persistent;

namespace Sakila.Persistent
{
    public static  class PersistentRegistrationService
    {

        public static IServiceCollection ConfigurePersistenceRegister(this IServiceCollection services, IConfiguration configuration)
        {
            string conectionString = configuration.GetConnectionString("usermap");
            services.AddDbContext<UserMapContext>(x =>
            {
                MySqlServerVersion version = new(new Version(8, 0, 0));
                x.UseMySql(conectionString, version);
            });
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped<Application.Contracts.Actor.ISpaceRepository,Repositories.SpacesRepository>();
            services.AddScoped<Application.Contracts.Citys.ISurfaceRepository, Repositories.SurfacesRepository>();
            return services;
        }

    }
}