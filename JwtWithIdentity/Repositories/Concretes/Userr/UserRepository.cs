using JwtWithIdentity.Datas;
using JwtWithIdentity.Models.Entities.Concretes;
using JwtWithIdentity.Repositories.Abstracts.Common;
using JwtWithIdentity.Repositories.Abstracts.Interfaces;
using JwtWithIdentity.Repositories.Abstracts.Interfaces.Userr;
using Microsoft.EntityFrameworkCore;

namespace JwtWithIdentity.Repositories.Concretes.Userr
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
