using Onion.Application.Interfaces.Repositories;
using Onion.Application.Interfaces.UnitOfWorks;
using Onion.Persistence.Context;
using Onion.Persistence.Repositories;

namespace Onion.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async ValueTask DisposeAsync() => await appDbContext.DisposeAsync();
        public int Save() => appDbContext.SaveChanges();
        public async Task<int> SaveAsync() => await appDbContext.SaveChangesAsync();
        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(appDbContext);
        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(appDbContext);
    }
}
