using ARED.BLL.Interfaces;
using ARED.BLL.Managers;
using ARED.BLL.Services;
using ARED.Entities.Enums;
using ARED.UI.Services;
using ARED.UI.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ARED.UI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private readonly IUserService _userService;
        private readonly AppRuleManager _appRuleManager;
        public MainViewModel(IUserService userService, AppRuleManager appRuleManager)
        {
            _userService = userService;
            _appRuleManager = appRuleManager;
        }

        public async Task LoginAsync()
        {
            var user = await _userService.GetUserAsync(x => x.Password == _password);
            if (user != null)
            {
                GlobalVariables.Navigator.Navigate(typeof(NavigationUserControl));
                await _appRuleManager.ExecuteAppRulesForEventAsync(EventType.UserLoggedIn);
            }
            else
                await _appRuleManager.ExecuteAppRulesForEventAsync(EventType.UserFailedToLogin);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
