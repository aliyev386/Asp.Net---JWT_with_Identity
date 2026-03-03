using JwtWithIdentity.Datas;
using JwtWithIdentity.Models.Entities.Common;
using JwtWithIdentity.Repositories.Abstracts.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JwtWithIdentity.Repositories.Abstracts.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        protected readonly AppDbContext _context;
        protected DbSet<T> _table;

        public GenericRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _table = _context.Set<T>();
        }
    }
}
