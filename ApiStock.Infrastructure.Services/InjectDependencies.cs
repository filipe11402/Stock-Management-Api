using ApiStock.Domain.Abstract;
using ApiStock.Infrastructure.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStock.Infrastructure.Services
{
    public static class InjectDependencies
    {
        public static void AddServices(this IServiceCollection services) 
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
