using TestApplication.Core.Helpers;
using TestApplication.Core.Models;
using TestApplication.Data.Repositories;

namespace TestApplication.Core.Interactors
{
    public class SectorInteractor : ISectorInteractor
    {
        public readonly ISectorRepository _sectorRepository;

        public SectorInteractor(ISectorRepository sectorRepository)
        {
            _sectorRepository = sectorRepository ?? throw new ArgumentNullException(nameof(sectorRepository));
        }

        public async Task<List<SectorModel>> GetSectors(List<int>? selectedSectorCodes)
        {
            var sectors = await _sectorRepository.GetSectorsAsync();

            var sectorsWithSubSectors = new List<SectorModel>();

            if (sectors.Count == 0)
            {
                return sectorsWithSubSectors;
            }

            sectorsWithSubSectors.AddRange(SectorInteractorHelper.GetSubSectors(sectors, 0, selectedSectorCodes));

            return sectorsWithSubSectors;
        }
    }
}
