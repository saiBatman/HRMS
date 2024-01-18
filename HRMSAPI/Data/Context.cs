using HRMSAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRMSAPI.Data
{
    public class Context : IdentityDbContext<User>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Override default AspNet Identity table names
            modelBuilder.Entity<User>(entity => { entity.ToTable(schema: "Users", name: "Information"); });
            //modelBuilder.Entity<IdentityUser>(entity => { entity.ToTable(schema: "Users", name: "Information"); });
            modelBuilder.Entity<IdentityRole>(entity => { entity.ToTable(schema: "Users", name: "Roles"); });
            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable(schema: "Users", name: "UsersRoles"); });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable(schema: "Users", name: "UserClaims"); });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable(schema: "Users", name: "Logins"); });
            modelBuilder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable(schema: "Users", name: "UserTokens"); });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable(schema: "Users", name: "RoleClaims"); });
        }

        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
