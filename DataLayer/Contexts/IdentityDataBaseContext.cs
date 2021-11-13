using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataLayer.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataLayer.Contexts
{
    public abstract class IdentityDataBaseContext : IdentityDbContext<User,Role,int>
    {
        protected IdentityDataBaseContext(DbContextOptions options)
            : base(options)
        {

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