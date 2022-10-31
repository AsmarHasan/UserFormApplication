using TestApplication.Core.Models;

namespace TestApplication.Core.Interactors
{
    public interface ISectorInteractor
    {
        Task<List<SectorModel>> GetSectors(List<int>? selectedSectorCodes);
    }
}
