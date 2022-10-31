using TestApplication.Data.Models;

namespace TestApplication.Data.Repositories
{
    public interface IUserRepository
    {
        Task<bool> SaveUserAsync(User user);
        Task<User> GetUserAsync(string sessionId);
    }
}
