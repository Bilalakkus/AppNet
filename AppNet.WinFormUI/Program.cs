using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Bussines.Services;
using AppNet.Domain.Entities.Abstract;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Persistence;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Reflection;

namespace AppNet.WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settings = DatabaseInformation.Load();
            var services = new ServiceCollection();
            ConfigureServices(services);
            ApplicationConfiguration.Initialize();

            //services.AddScoped<ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly())>;

            //services.AddScoped(Assembly.GetExecutingAssembly());
            // services.AddScoped(s => new AppNetDbContext(Configuration.GetConnectionString("AppNetDbContext")));

            services.AddScoped<FrmLogin>();
            services.AddScoped<FrmCategoryList>();
            services.AddScoped<FrmCategorySave>();
            services.AddScoped<FrmCustomerList>();
            services.AddScoped<FrmCustomerSave>();
            services.AddScoped<FrmDashbord>();
            services.AddScoped<FrmEmployee>();
            services.AddScoped<FrmOrder>();
            services.AddScoped<FrmProductSave>();
            services.AddScoped<FrmSafe>();
            services.AddScoped<FrmSupplierSave>();
            services.AddScoped<MDIDashboard>();
            services.AddScoped<FrmDateBaseInformation>();
            services.AddScoped<Logger>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                if (settings != null && settings.Server != null)
                {
                    var loginFrm = sp.GetRequiredService<FrmLogin>();
                    Application.Run(loginFrm);
                }
                else
                {
                    MessageBox.Show("Lütfen Veritabanınızı oluşturunuz!", "Veri tabanı bilgilerine ulaşılamadı");
                    var frmDataBase = sp.GetRequiredService<FrmDateBaseInformation>();
                    frmDataBase.ShowDialog();
                    //Application.Run(frmDataBase);
                }
            }
        }
        private static void ConfigureServices(IServiceCollection services)
        {
             services.RegisterBusinessServices();
        }
    }
}