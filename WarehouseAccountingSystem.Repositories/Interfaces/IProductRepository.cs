using System.Linq;
using WarehouseAccountingSystem.Abstractions;
using WarehouseAccountingSystem.Entities;

namespace WarehouseAccountingSystem.Repositories.Interfaces
{
    public interface IProductRepository : IDbRepository<Product>
    {
        IQueryable<Color> Colors { get; }
        IQueryable<Category> Categories { get; }
    }
}
