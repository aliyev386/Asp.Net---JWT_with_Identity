using JwtWithIdentity.Models.Entities.Concretes;

namespace JwtWithIdentity.Repositories.Abstracts.Interfaces.Userr
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByUsernameAsync(string username);
        Task<User> GetByEmailAsync(string email);
    }
}
