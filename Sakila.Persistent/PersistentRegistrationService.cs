using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Sakila.Application.Contracts;
using Sakila.Persistent.Repositories;
using UserMap.Persistent;
using UserMap.Application.Contracts.Ads;
using UserMap.Persistent.Repositories;
using UserMap.Application.Contracts.ReportWarm;

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
            services.AddScoped<IAdsRepository,AdsRepository>();
            services.AddScoped<IReportWarmRepository, ReportWarmRepository>();
            return services;
        }

    }
}