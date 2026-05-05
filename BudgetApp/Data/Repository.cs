using BudgetApp.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BudgetApp.Data;

internal sealed class Repository<T> : IRepository<T> where T : class
{
    private readonly BudgetDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(BudgetDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ObservableCollection<T>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
