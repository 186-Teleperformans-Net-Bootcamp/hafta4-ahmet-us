using Microsoft.EntityFrameworkCore;

namespace SocialNetworkCodeFirst.Data
{
    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext(DbContextOptions<SocialNetworkDbContext> options) : base(options)
        {

        }

        public DbSet<GroupProfile> GroupProfiles { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PrivateMessage> PrivateMessages { get; set; }
        public DbSet<PublicMessage> PublicMessages { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

    }
}
