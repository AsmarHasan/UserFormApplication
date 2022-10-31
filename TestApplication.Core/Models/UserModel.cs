namespace TestApplication.Core.Models
{
    public class UserModel
    {
        public string? Name { get; set; }
        public string? SessionId { get; set; }
        public bool AgreedToTerms { get; set; }
        public List<int>? SelectedSectorCodes { get; set; }
    }
}
