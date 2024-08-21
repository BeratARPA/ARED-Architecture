using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace ARED.UI.Services
{
    public class NavigatorService
    {
        private readonly IServiceProvider _serviceProvider;
        private Frame _frame;

        public NavigatorService(Frame frame, IServiceProvider serviceProvider)
        {
            _frame = frame ?? throw new ArgumentNullException(nameof(frame));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public void Navigate(Type pageType, object parameter = null)
        {
            if (_frame == null)
                throw new InvalidOperationException("Frame is not initialized.");

            var page = _serviceProvider.GetRequiredService(pageType) as System.Windows.Controls.UserControl;
            if (page == null)
                throw new InvalidOperationException($"No service for type '{pageType}' has been registered.");

            _frame.Navigate(page, parameter);
        }

        public void GoBack()
        {
            if (_frame.CanGoBack)
            {
                _frame.GoBack();
            }
        }

        public void GoForward()
        {
            if (_frame.CanGoForward)
            {
                _frame.GoForward();
            }
        }

        public void SetFrame(Frame frame)
        {
            _frame = frame;
        }
    }
}
