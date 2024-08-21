using ARED.Core.Models;
using System.Linq.Expressions;

namespace ARED.BLL.Interfaces
{
    public interface IUserService
    {   
        Task<User> GetUserAsync(Expression<Func<User, bool>> filter = null);
    }
}
