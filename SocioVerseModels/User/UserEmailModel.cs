namespace SocioVerseModels.User {
    public class UserEmailModel
    {
        public int UserEmailID { get; set; }
        public int UserID { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}