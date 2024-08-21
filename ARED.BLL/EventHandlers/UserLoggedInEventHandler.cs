using ARED.BLL.Interfaces;

namespace ARED.BLL.EventHandlers
{
    public class UserLoggedInEventHandler : IEventHandler
    {
        public Task HandleEventAsync(string eventData)
        {
            // User logged in event handling logic
            return Task.CompletedTask;
        }
    }
}
