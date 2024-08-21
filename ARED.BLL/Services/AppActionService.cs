using ARED.BLL.Interfaces;
using ARED.Core.Data;
using ARED.Core.Models;

namespace ARED.BLL.Services
{
    public class AppActionService : IAppActionService
    {
        private readonly AREDContext _context;

        public AppActionService(AREDContext context)
        {
            _context = context;
        }     

        public async Task<AppAction> GetAppActionByIdAsync(int id)
        {
            return await _context.AppActions.FindAsync(id);
        }       
    }
}
