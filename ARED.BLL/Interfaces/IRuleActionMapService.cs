using ARED.Core.Models;
using System.Linq.Expressions;

namespace ARED.BLL.Interfaces
{
    public interface IRuleActionMapService
    {
        Task<IEnumerable<RuleActionMap>> GetAllRuleActionMapsAsync(Expression<Func<RuleActionMap, bool>> filter = null);       
    }
}
