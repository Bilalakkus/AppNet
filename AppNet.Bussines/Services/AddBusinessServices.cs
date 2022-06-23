using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Infrastructer.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppNet.Bussines.Services
{
    public static class AddBusinessServices
    {
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.RegisterPersistenceService();
            services.AddScoped<ICategoriService, CategoriService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISafeService, SafeService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<ISuplierService, SuplierService>();
        }
    }
}
