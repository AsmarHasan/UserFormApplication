using TestApplication.Core.Models;
using TestApplication.Data.Models;

namespace TestApplication.Core.Helpers
{
    public static class SectorInteractorHelper
    {
        public static List<SectorModel> GetSubSectors(IList<Sector> sectors, int selectorParentCode, List<int>? selectedSectorCodes)
        {
            var subSectors = sectors.Where(x => x.SectorParentCode == selectorParentCode)?.ToList();

            if (subSectors == null || subSectors.Count == 0)
            {
                return new List<SectorModel>();
            }

            return subSectors.Select(x => new SectorModel
            {
                Code = x.SectorCode,
                Name = x.SectorName,
                Selected = selectedSectorCodes != null && selectedSectorCodes.Count > 0 && selectedSectorCodes.Contains(x.SectorCode),
                SubSectors = GetSubSectors(sectors, x.SectorCode, selectedSectorCodes)
            }).ToList();
        }
    }
}
