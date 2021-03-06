using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace AppNet.Bussines.Services
{
    public static class AddBusinessServices
    {
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.RegisterPersistenceService();
            // services.AddScoped(Assembly.GetExecutingAssembly());
            services.AddScoped<ICategoriService, CategoriService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISafeService, SafeService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<ISuplierService, SuplierService>();
            services.AddScoped<IDatabaseService, DataBaseService>();
            services.AddScoped<ILoggerDbService, LoggerDbService>();
            services.AddScoped<IOrderDetailService, OrderDetailServices>();
            //services.AddScoped<Logger, Logger>();
        }
    }
}
