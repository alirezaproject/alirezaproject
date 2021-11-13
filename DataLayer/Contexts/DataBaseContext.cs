using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Services.Interfaces;
using DataLayer.Entities.Common;
using DataLayer.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public class DataBaseContext : IdentityDataBaseContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)   
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<User>(b =>
            {
                b.HasMany<IdentityUserRole<int>>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
                b.ToTable("Users");
            });
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");

            builder.Entity<Role>(b =>
            {
                b.HasKey(r => r.Id);
                b.HasIndex(r => r.NormalizedName).HasDatabaseName("RoleNameIndex").IsUnique();
                b.ToTable("Roles");
                b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

                b.Property(u => u.Name).HasMaxLength(256);
                b.Property(u => u.NormalizedName).HasMaxLength(256);

                b.HasMany<IdentityUserRole<int>>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
                b.HasMany<IdentityRoleClaim<int>>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            });

            builder.Entity<IdentityRoleClaim<int>>(b =>
            {
                b.HasKey(rc => rc.Id);
                b.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserRole<int>>(b =>
            {
                b.HasKey(r => new { r.UserId, r.RoleId });
                b.ToTable("UserRoles");
            });


            builder.Entity<User>().HasQueryFilter(s => !s.IsRemoved);




            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }


            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute), true).Length <= 0) continue;
                builder.Entity(entityType.Name).Property<DateTime>("InsertTime");
                builder.Entity(entityType.Name).Property<DateTime?>("UpdateTime");
                builder.Entity(entityType.Name).Property<DateTime?>("RemoveTime");
                builder.Entity(entityType.Name).Property<bool>("IsRemoved");
            }

            

            base.OnModelCreating(builder);
            

        }



        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)

        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(p => p.State == EntityState.Modified ||
                p.State == EntityState.Added ||
                p.State == EntityState.Deleted
                );
            foreach (var item in modifiedEntries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());


                var inserted = entityType.FindProperty("InsertTime");
                var updated = entityType.FindProperty("UpdateTime");
                var removeTime = entityType.FindProperty("RemoveTime");
                var isRemoved = entityType.FindProperty("IsRemoved");
                if (item.State == EntityState.Added && inserted != null)
                {
                    item.Property("InsertTime").CurrentValue = DateTime.Now;
                }
                if (item.State == EntityState.Modified && updated != null)
                {
                    item.Property("UpdateTime").CurrentValue = DateTime.Now;
                }

                if (item.State != EntityState.Deleted || removeTime == null || isRemoved == null) continue;
                item.Property("RemoveTime").CurrentValue = DateTime.Now;
                item.Property("IsRemoved").CurrentValue = true;
                item.State = EntityState.Modified;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}