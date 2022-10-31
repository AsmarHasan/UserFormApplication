namespace TestApplication.Data.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public bool AgreedToTerms { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? SessionID { get; set; }

        public virtual ICollection<UserSector>? UserSector { get; set; }
    }
}
