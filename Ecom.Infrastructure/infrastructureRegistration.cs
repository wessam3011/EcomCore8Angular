using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using Ecom.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure
{
    public static class infrastructureRegistration
    {
        public static IServiceCollection infrastructureConfiguration(this IServiceCollection services, IConfiguration configuration) 
        {
            //scope between genericRepository and IGernericRepository

            //used when sending email as example
            //services.AddTransient

            //temporary saving such as http request
            //services.AddScoped

            //used when I want something working all the time
            //services.AddSingleton


            //fe way a7san meen el manzar dah : iunit of work interface
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped< IProductRepository, ProductRepository>();
            //services.AddScoped<IPhotoRepository, PhotoRepository>();

            //apply unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //apply dbcontext
            services.AddDbContext<AppDbContext>(op=> op.UseSqlServer(configuration.GetConnectionString("EcomDataBase")));
            return services;
        }
    }
}
