using ARED.Core.Models;

namespace ARED.BLL.Interfaces
{
    public interface IAppActionService
    {     
        Task<AppAction> GetAppActionByIdAsync(int id);    
    }
}
