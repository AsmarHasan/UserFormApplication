using TestApplication.Data.Models;

namespace TestApplication.Data.Repositories
{
    public interface ISectorRepository
    {
        Task<IList<Sector>> GetSectorsAsync();
    }
}
