using Microsoft.Extensions.DependencyInjection;
using OnlineFoodServiceDAL.DALRepository;
using OnlineFoodServiceDAL.IDALRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceDAL
{
    public static class RepositoryCollection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IDALCategoryRepository, DALCategoryRepository>();
            services.AddTransient<ISQLServerConfiguration, SQLServerConfiguration>();
            return services;
        }
    }
}
