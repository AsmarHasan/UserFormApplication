namespace TestApplication.Core.Models
{
    public class SectorModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public List<SectorModel> SubSectors { get; set; }
        public bool Selected { get; set; } = false;
    }
}