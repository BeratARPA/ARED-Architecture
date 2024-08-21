using ARED.BLL.Actions;
using ARED.BLL.EventHandlers;
using ARED.BLL.Factories;
using ARED.BLL.Interfaces;
using ARED.BLL.Managers;
using ARED.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ARED.BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserService>();

            services.AddSingleton<IAppRuleService, AppRuleService>();
            services.AddSingleton<AppRuleManager>();

            services.AddSingleton<IAppActionService, AppActionService>();

            services.AddSingleton<IRuleActionMapService, RuleActionMapService>();
      
            services.AddSingleton<EventFactory>();
            services.AddSingleton<ActionFactory>();

            services.AddTransient<CloseTheApplicationAction>();
            services.AddTransient<LoginUserAction>();
            services.AddTransient<ShowPopupAction>();

            services.AddTransient<UserLoggedInEventHandler>();
            services.AddTransient<PopupDisplayedEventHandler>();
            services.AddTransient<UserFailedToLoginEventHandler>();

            return services;
        }
    }
}
