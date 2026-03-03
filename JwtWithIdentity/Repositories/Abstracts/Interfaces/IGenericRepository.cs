using JwtWithIdentity.Models.Entities.Common;

namespace JwtWithIdentity.Repositories.Abstracts.Interfaces
{
    public interface IGenericRepository<T> where T : IBaseEntity, new()
    {

    }
}
