using AppNet.Bussines;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.Repositories
{
    public static class AddPersistenceServices
    {
        public static void RegisterPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<AppNetDbContext>(opt =>
            opt.UseSqlServer(DatabaseInformation.Load().ConStr));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
