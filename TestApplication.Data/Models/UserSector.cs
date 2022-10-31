namespace TestApplication.Data.Models
{
    public class UserSector
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SectorId { get; set; }

        public virtual User? User { get; set; }
        public virtual Sector? Sector { get; set; }
    }
}
