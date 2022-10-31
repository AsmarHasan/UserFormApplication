using TestApplication.Core.Models;

namespace TestApplication.Core.Interactors
{
    public interface IUserInteractor
    {
        Task SaveUserData(UserModel userData);

        Task<UserModel?> GetUserData(string sessionId);
    }
}
