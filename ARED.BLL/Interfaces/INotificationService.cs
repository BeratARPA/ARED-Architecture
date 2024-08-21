using ARED.Shared.Models;

namespace ARED.BLL.Interfaces
{
    public interface INotificationService
    {
        void Show(NotificationModel notification);
    }
}
