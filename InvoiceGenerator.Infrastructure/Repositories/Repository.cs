using InvoiceGenerator.Domain.Base;
using InvoiceGenerator.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace InvoiceGenerator.Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : Entity
{
    protected readonly InvoiceGeneratorDbContext Context;
    
    public Repository(InvoiceGeneratorDbContext context)
    {
        Context = context;
    }
    
    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await Context.Set<TEntity>().AddAsync(entity, cancellationToken);
        await SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        Context.Set<TEntity>().Remove(entity);
        await SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        Context.Set<TEntity>().Update(entity);
        await SaveChangesAsync(cancellationToken);
    }

    public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await Context.Set<TEntity>().ToListAsync(cancellationToken);
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
       return await Context.SaveChangesAsync(cancellationToken);
    }
}