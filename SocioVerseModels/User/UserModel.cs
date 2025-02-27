
using System.ComponentModel.DataAnnotations.Schema;

namespace SocioVerseModels.User
{
    [Table("tbl_Users")]
    public class UserModel
    {
        public long UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual List<UserCredentialModel> UserCredentials { get; set; } = new List<UserCredentialModel>();
        public virtual List<UserEmailModel> UserEmails { get; set; } = new List<UserEmailModel>();

    }
}