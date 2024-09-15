using Identity_SampleProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_SampleProject.IdentityContext
{
    public class IdentityDatabaseContext : IdentityDbContext<User>
    {
        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().Property(p=> p.Initials).HasMaxLength(100);

            //seed base role
            SeedRoles(builder);

            builder.HasDefaultSchema("identity");
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                 new IdentityRole() {  Name = "SuperAdmin", ConcurrencyStamp = "10", NormalizedName = "SuperAdmin"},
                 new IdentityRole() {  Name = "Admin", ConcurrencyStamp = "11", NormalizedName = "Admin"},
                 new IdentityRole() {  Name = "User", ConcurrencyStamp = "12", NormalizedName = "User"}
                );
        }
    }
}
