using ARED.UI.Services;
using ARED.UI.ViewModels;
using System.Windows;

namespace ARED.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IServiceProvider _serviceProvider;
        public MainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            GlobalVariables.Navigator = new NavigatorService(FrameContent, _serviceProvider);
        }

        private async void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxPassword.Text))
                return;

            if (DataContext is MainViewModel)
            {
                var mainViewModel = DataContext as MainViewModel;

                mainViewModel.Password = TextBoxPassword.Text;
                await mainViewModel.LoginAsync();
            }
        }
    }
}