using CleanArch.Domain.Interfaces;
using CleanArch.Persistence.Context;
using CleanArch.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CleanArch.Persistence
{
    public static class ServicesExtensions
    {

        public static void ConfigurePersistenceApp(this IServiceCollection services,
                                                  IConfiguration configaration)
        {
            var connectionString = configaration.GetConnectionString("Postgre");
            services.AddDbContext<AppDbContext>(opt => opt.postgre(connectionString));

            services.AddScoped<IUnitOfWorl, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepositoty>(); 
        }
    }
}
