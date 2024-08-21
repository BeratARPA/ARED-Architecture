using ARED.Core.Models;
using ARED.Entities.Enums;

namespace ARED.Core.Data
{
    public class DataSeed
    {
        private readonly AREDContext _context;

        public DataSeed(AREDContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            // Veritabanı oluşturulmuş mu, kontrol et
            _context.Database.EnsureCreated();

            // Eğer veriler varsa, veri ekleme işlemini atla
            if (_context.AppActions.Any() ||
                _context.AppRules.Any() ||
                _context.RuleActionMaps.Any() ||
                _context.Users.Any())
            {
                return; // Veriler zaten var, veri eklemesine gerek yok
            }

            // Kullanıcı ekle
            _context.Users.AddRange(
                new User { Name = "Admin", Password = "1234" }
            );

            // Action ekle
            _context.AppActions.AddRange(             
                new AppAction { Name = "LoginWelcomeMessage", Type = ActionType.ShowPopup, Properties = "{ \"Title\": \"Hello\", \"Message\": \"Welcome\",\"ButtonType\":0,\"Icon\":8 }" },
                new AppAction { Name = "CloseApp", Type = ActionType.CloseTheApplication, Properties = null }
            );

            // Rule ekle
            _context.AppRules.AddRange(
                new AppRule { Name = "UserLoginRule", Type = EventType.UserLoggedIn },
                new AppRule { Name = "UserFailedToLoginRule", Type = EventType.UserFailedToLogin }
            );

            // RuleActionMap ekle
            _context.RuleActionMaps.AddRange(
                new RuleActionMap { AppRuleId = 1, AppActionId = 1, SortOrder = 1 },
                new RuleActionMap { AppRuleId = 2, AppActionId = 2, SortOrder = 2 }
            );

            _context.SaveChanges();
        }
    }
}
