using ARED.BLL.Interfaces;

namespace ARED.BLL.EventHandlers
{
    public class UserFailedToLoginEventHandler : IEventHandler
    {
        public Task HandleEventAsync(string eventData)
        {
            // POS Page opened event handling logic
            return Task.CompletedTask;
        }
    }
}
