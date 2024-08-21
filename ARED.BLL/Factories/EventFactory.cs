using ARED.BLL.EventHandlers;
using ARED.BLL.Interfaces;
using ARED.Entities.Enums;

namespace ARED.BLL.Factories
{
    public class EventFactory
    {
        private readonly Dictionary<EventType, Type> _eventHandlers = new Dictionary<EventType, Type>
        {
            { EventType.PopupDisplayed, typeof(PopupDisplayedEventHandler) },
            { EventType.UserFailedToLogin, typeof(UserFailedToLoginEventHandler) },
            { EventType.UserLoggedIn, typeof(UserLoggedInEventHandler) }
        };

        private readonly IServiceProvider _serviceProvider;

        public EventFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IEventHandler GetEventHandler(EventType eventType)
        {
            if (_eventHandlers.TryGetValue(eventType, out var handlerType))
            {
                var handler = _serviceProvider.GetService(handlerType) as IEventHandler;
                if (handler != null)
                {
                    return handler;
                }
                else
                {
                    throw new InvalidOperationException($"No service found for event handler type {handlerType.Name}.");
                }
            }

            throw new NotImplementedException($"Event type {eventType} is not implemented.");
        }
    }
}
