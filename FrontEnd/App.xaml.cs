using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CrossCutting.Config;
using FrontEnd.ApiCaller;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace FrontEnd
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IConfiguration Configuration { get; }

        private readonly ServiceProvider _serviceProvider;

        public App()
        {

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            
            //services.AddTransient<IAppConfig, AppConfig>();
            //services.AddTransient<IApiCaller, FrontEnd.ApiCaller.ApiCaller>();
            services.AddSingleton<PeopleSystemView>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<PeopleSystemView>();
            mainWindow.Show();
        }
    }
}
