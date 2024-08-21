using ARED.BLL.Interfaces;
using ARED.Shared.Models;
using System.Windows;

namespace ARED.UI.Services
{
    public class NotificationService : INotificationService
    {
        public void Show(NotificationModel notification)
        {
            MessageBoxButton messageBoxButton = MessageBoxButton.OK;
            switch (notification.ButtonType)
            {
                case 0:
                    messageBoxButton = MessageBoxButton.OK;
                    break;
                case 1:
                    messageBoxButton = MessageBoxButton.OKCancel;
                    break;
                case 2:
                    messageBoxButton = MessageBoxButton.YesNoCancel;
                    break;
                case 3:
                    messageBoxButton = MessageBoxButton.YesNo;
                    break;
                default:
                    messageBoxButton = MessageBoxButton.OK;
                    break;
            }

            MessageBoxImage messageBoxImage = MessageBoxImage.Information;
            switch (notification.Icon)
            {
                case 0:
                    messageBoxImage = MessageBoxImage.None;
                    break;
                case 1:
                    messageBoxImage = MessageBoxImage.Error;
                    break;
                case 2:
                    messageBoxImage = MessageBoxImage.Hand;
                    break;
                case 3:
                    messageBoxImage = MessageBoxImage.Stop;
                    break;
                case 4:
                    messageBoxImage = MessageBoxImage.Question;
                    break;
                case 5:
                    messageBoxImage = MessageBoxImage.Exclamation;
                    break;
                case 6:
                    messageBoxImage = MessageBoxImage.Warning;
                    break;
                case 7:
                    messageBoxImage = MessageBoxImage.Asterisk;
                    break;
                case 8:
                    messageBoxImage = MessageBoxImage.Information;
                    break;
                default:
                    messageBoxImage = MessageBoxImage.Information;
                    break;
            }

            MessageBox.Show(notification.Message, notification.Title, messageBoxButton, messageBoxImage);
        }
    }
}
