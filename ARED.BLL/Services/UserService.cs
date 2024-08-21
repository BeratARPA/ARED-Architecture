using ARED.BLL.Interfaces;
using ARED.Core.Data;
using ARED.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace ARED.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly AREDContext _context;

        public UserService(AREDContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(Expression<Func<User, bool>> filter = null)
        {
            return await _context.Users.Where(filter).FirstOrDefaultAsync();
        }
    }
}
