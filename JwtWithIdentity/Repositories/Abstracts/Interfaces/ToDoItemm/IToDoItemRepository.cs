using JwtWithIdentity.Models.Entities.Concretes;

namespace JwtWithIdentity.Repositories.Abstracts.Interfaces.ToDoItemm
{
    public interface IToDoItemRepository
    {
        Task<ToDoItem> GetByTitleAsync(string title);
        Task<ToDoItem> GetByTitleAndUserIdAsync(string title, string userId);
    }
}
