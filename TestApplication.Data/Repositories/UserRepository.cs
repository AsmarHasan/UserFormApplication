using Microsoft.EntityFrameworkCore;
using TestApplication.Data.Models;

namespace TestApplication.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(FormAppContext dbContext) : base(dbContext) { }

        public async Task<List<UserSector>> GetUserSectorByUserIdAsync(int userId)
        {
            return await FormAppContext.UserSectors.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task RemoveUserSectorByUserIdAsync(int userId)
        {
            var allUserSectors = await GetUserSectorByUserIdAsync(userId);
            FormAppContext.UserSectors.RemoveRange(allUserSectors);
            await FormAppContext.SaveChangesAsync();
        }

        public async Task UpdateUserSectorAsync(int userId, ICollection<UserSector> newUserSectors)
        {
            await RemoveUserSectorByUserIdAsync(userId);
            await FormAppContext.UserSectors.AddRangeAsync(newUserSectors);
            await FormAppContext.SaveChangesAsync();
        }

        public async Task<bool> SaveUserAsync(User newUser)
        {
            if (newUser == null)
            {
                return false;
            }

            var existingUser = await FormAppContext.Users?.FirstOrDefaultAsync(x => x.SessionID == newUser.SessionID);

            if (existingUser != null)
            {
                foreach (var sector in newUser.UserSector)
                {
                    sector.UserId = existingUser.Id;
                }
                await UpdateUserSectorAsync(existingUser.Id, newUser.UserSector);
                existingUser.Name = newUser.Name;
                existingUser.UpdatedAt = DateTime.UtcNow;
            }
            else
            {
                var time = DateTime.UtcNow;
                newUser.AddedAt = time;
                newUser.UpdatedAt = time;
                FormAppContext.Users.Add(newUser);
            }

            return await FormAppContext.SaveChangesAsync() > 0;
        }

        public async Task<User> GetUserAsync(string sessionId)
        {
            if (sessionId == null)
            {
                return new User();
            }
            return await FormAppContext.Users?.Include(x => x.UserSector)?.FirstOrDefaultAsync(x => x.SessionID == sessionId);
        }
    }
}
