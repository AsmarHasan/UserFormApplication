using TestApplication.Data.Models;

namespace TestApplication.Data.Repositories
{
    public class BaseRepository
    {
        protected readonly FormAppContext FormAppContext;
        public BaseRepository(FormAppContext dbContext)
        {
            FormAppContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
