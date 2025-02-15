namespace SocioVerseModels.User {
    public class UserCredentialModel {
        public int UserCredID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}