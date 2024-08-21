using ARED.BLL.Interfaces;
using ARED.Shared.Models;
using System.Text.Json;

namespace ARED.BLL.Actions
{
    public class ShowPopupAction : IAction
    {
        private readonly INotificationService _customNotificationService;

        public ShowPopupAction(INotificationService customNotificationService)
        {
            _customNotificationService = customNotificationService;
        }

        public void Execute(string properties)
        {
            // JSON verisini ayrıştır
            var popupProperties = JsonSerializer.Deserialize<NotificationModel>(properties);
            if (popupProperties != null)
                _customNotificationService.Show(popupProperties);
        }
    }
}
