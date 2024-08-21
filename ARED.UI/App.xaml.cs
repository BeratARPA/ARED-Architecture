using ARED.BLL;
using ARED.BLL.Interfaces;
using ARED.Core;
using ARED.UI.Services;
using ARED.UI.ViewModels;
using ARED.UI.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace ARED.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ConfigureServices(IServiceCollection services)
        {
            // Data Access Layer servisleri
            services.AddCoreLayer();

            // Business Logic Layer servisleri
            services.AddBusinessLogicLayer();

            services.AddSingleton<INotificationService, NotificationService>();

            // ViewModels
            services.AddTransient<MainViewModel>();

            // Views
            services.AddTransient<NavigationUserControl>();
            services.AddTransient<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // DI Container'ı oluştur
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Uygulamayı başlat
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.DataContext = serviceProvider.GetRequiredService<MainViewModel>();
            mainWindow.Show();
        }
    }
}
