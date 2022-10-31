namespace TestApplication.Data.Models
{
    public class Sector
    {
        public int Id { get; set; }
        public int SectorCode { get; set; }
        public int SectorParentCode { get; set; }
        public string SectorName { get; set; }

        public virtual ICollection<UserSector>? UserSector { get; set; }
    }
}
