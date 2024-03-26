using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WestWindSystem.DAL;
using WestWindSystem.BLL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace WestWindSystem
{
    public static class WestWindExtensions
    {

        public static void WWExtensions(
            this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            //register the context
            services.AddDbContext<WestWindContext>(options);

            //we need to AddTransient for each service class in the BBL
            services.AddTransient<RegionServices>((ServiceProvider) =>
            {
                var context = ServiceProvider.GetService<WestWindContext>();
                return new RegionServices(context);
            });

            services.AddTransient<CustomerServices>((ServiceProvider) =>
            {
                var context = ServiceProvider.GetService<WestWindContext>();
                return new CustomerServices(context);
            });


        }


    }
}
