using System.ComponentModel.DataAnnotations.Schema;

namespace SocioVerseModels.User 
{
    [Table("tbl_UserProfiles")]
    public class UserProfileModel {
        public int UserProfileID { get; set; }
        public int UserID { get; set; }
        public string? ProfilePicture { get; set; }
        public string? CoverPicture { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual UserModel? User { get; set; }
    }
}