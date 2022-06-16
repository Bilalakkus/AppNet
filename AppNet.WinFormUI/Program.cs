using AppNet.Bussines.Services;
using Microsoft.Extensions.DependencyInjection;

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
            var services = new ServiceCollection();
            services.AddScoped<FrmUser>();
            ConfigureServices(services);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var form = sp.GetRequiredService<FrmUser>();
                Application.Run(form);
            }
            Application.Run(new FrmUser());
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            //winform servislerini burada register edebiliriz.

            services.RegisterBusinessServices();
        }
    }
}