using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseAccountingSystem.Abstractions
{
    public interface IDbRepository<T> where T:class, IDbEntity
    {
        IQueryable<T> AllItems { get; }
        DbContext Context { get; }
        Task<List<T>> ToListAsync();
        Task<bool> AddItemAsync(T item);
        Task<int> AddItemsAsync(IEnumerable<T> items);
        Task<bool> ChangeItemAsync(T item);
        Task<bool> DeleteItemAsync(int id);
        Task<T> GetItemAsync(int id);
        Task<int> SaveChangesAsync();
    }
}
