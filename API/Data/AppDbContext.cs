
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int,
        IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Policy> Policies { get; set; }
        public DbSet<SubPolicy> SubPolices { get; set; }
        public DbSet<AuditTrail> AuditTrails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            builder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(r => r.Roles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            builder.Entity<Policy>()
                .HasIndex(p => p.Code)
                .IsUnique();
            builder.Entity<SubPolicy>()
                .HasIndex(sp => sp.Code)
                .IsUnique();
        }
    }
}