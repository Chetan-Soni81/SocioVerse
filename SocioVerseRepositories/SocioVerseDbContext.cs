using Microsoft.EntityFrameworkCore;
using SocioVerseModels.User;

namespace SocioVerseRepositories
{
    public class SocioVerseDbContext : DbContext
    {
        public SocioVerseDbContext(DbContextOptions<SocioVerseDbContext> options) : base (options) {

        }

        public virtual DbSet<UserModel> Users { get; set; }
        public virtual DbSet<UserEmailModel> UserEmails { get; set; }
        public virtual DbSet<UserMobileModel> UserMobiles { get; set; }
        public virtual DbSet<UserCredentialModel> UserCredentials { get; set; }
        public virtual DbSet<UserProfileModel> UserProfiles { get; set; }
    }
}