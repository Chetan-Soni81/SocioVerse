
namespace SocioVerseModels.User
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}