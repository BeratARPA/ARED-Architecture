using ARED.BLL.Interfaces;
using ARED.Core.Data;
using ARED.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ARED.BLL.Services
{
    public class RuleActionMapService : IRuleActionMapService
    {
        private readonly AREDContext _context;

        public RuleActionMapService(AREDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RuleActionMap>> GetAllRuleActionMapsAsync(Expression<Func<RuleActionMap, bool>> filter = null)
        {
            return await _context.RuleActionMaps.Where(filter).ToListAsync();
        }       
    }
}
