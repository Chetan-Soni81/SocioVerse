namespace SocioVerseModels.User {
    public class UserCredentialModel {
        public long UserCredID { get; set; }
        public long UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual UserModel? User { get; set; }
    }
}