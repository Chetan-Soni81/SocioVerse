using System.ComponentModel.DataAnnotations.Schema;

namespace SocioVerseModels.User
{
    [Table("tbl_UserMobiles")]
    public class UserMobileModel
    {
        public int UserMobileID { get; set; }
        public int UserID { get; set; }
        public string Mobile { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual UserModel? User { get; set; }
    }
}