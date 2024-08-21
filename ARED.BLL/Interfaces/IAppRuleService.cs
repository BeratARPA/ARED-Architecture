using ARED.Core.Models;
using System.Linq.Expressions;

namespace ARED.BLL.Interfaces
{
    public interface IAppRuleService
    {
        Task<IEnumerable<AppRule>> GetAllAppRulesAsync(Expression<Func<AppRule, bool>> filter = null);      
    }
}
