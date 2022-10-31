using Microsoft.EntityFrameworkCore;
using TestApplication.Data.Models;

namespace TestApplication.Data.Repositories
{
    public class SectorRepository: BaseRepository, ISectorRepository
    {
        public SectorRepository(FormAppContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<Sector>> GetSectorsAsync()
        {
            return await FormAppContext.Sectors.AsNoTracking().ToListAsync();
        }
    }
}
