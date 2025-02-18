namespace SocioVerseModels.User {
    public class UserEmailModel
    {
        public long UserEmailID { get; set; }
        public long UserID { get; set; }
        public string Email { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual UserModel? User { get; set; }
    }
}