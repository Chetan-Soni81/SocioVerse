namespace SocioVerseModels.User
{
    public class UserMobileModel
    {
        public int UserMobileID { get; set; }
        public int UserID { get; set; }
        public string Mobile { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}