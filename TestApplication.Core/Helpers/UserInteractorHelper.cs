using TestApplication.Data.Models;

namespace TestApplication.Core.Helpers
{
    public static class UserInteractorHelper
    {
        public static List<int> GetSelectedSectorCodes(IList<Sector> allSectors, ICollection<UserSector>? userSectors)
        {
            if (allSectors == null || userSectors == null)
            {
                return new List<int>();
            }

            return (from userSector in userSectors
                    let code = allSectors.FirstOrDefault(x => x.Id == userSector.SectorId).SectorCode
                    select code).ToList();
        }

        public static ICollection<UserSector> MapToUserSector(IList<Sector> allSectors, List<int> selectedSectorsCode)
        {
            var selectedSectors = selectedSectorsCode.Select(code => allSectors?.FirstOrDefault(x => x.SectorCode == code)).ToList();

            return selectedSectors.Select(sector => new UserSector
            {
                SectorId = sector.Id
            }).ToList();
        }

    }
}
