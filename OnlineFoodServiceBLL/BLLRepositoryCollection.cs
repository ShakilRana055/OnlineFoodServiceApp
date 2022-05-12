using Microsoft.Extensions.DependencyInjection;
using OnlineFoodServiceBLL.BLLRepository;
using OnlineFoodServiceBLL.IBLLRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceBLL
{
    public static class BLLRepositoryCollection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddTransient<IBLLCategoryRepository, BLLCategoryRepository>();
            return services;
        }
    }
}
