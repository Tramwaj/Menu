using Menu.Logic;
using Menu.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace Menu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider serviceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();

            var clientWindow = serviceProvider.GetRequiredService<MainWindow>();
            clientWindow.Show();
            base.OnStartup(e);
            
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMealRepository, TempMealRepository>();
            services.AddScoped<MealFaker>();

            services.AddSingleton<MainViewModel>(s => new MainViewModel(s.GetRequiredService<IMealRepository>()));

            services.AddScoped<MainWindow>(s=> new MainWindow(s.GetRequiredService<MainViewModel>()));
        }
    }
}
