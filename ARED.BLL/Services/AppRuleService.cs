using ARED.BLL.Interfaces;
using ARED.Core.Data;
using ARED.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ARED.BLL.Services
{
    public class AppRuleService : IAppRuleService
    {
        private readonly AREDContext _context;

        public AppRuleService(AREDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppRule>> GetAllAppRulesAsync(Expression<Func<AppRule, bool>> filter = null)
        {
            return await _context.AppRules.Where(filter).ToListAsync();
        }      
    }
}
