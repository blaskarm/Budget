using System.Collections.ObjectModel;

namespace BudgetApp.Abstractions;

public interface IRepository<T> where T : class
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
    Task<ObservableCollection<T>> Get();
    Task<T> GetById(int id);
}
