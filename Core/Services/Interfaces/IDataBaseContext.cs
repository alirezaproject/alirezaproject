using System.Threading;
using System.Threading.Tasks;

namespace Core.Services.Interfaces
{
    public interface IDataBaseContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
    }
}