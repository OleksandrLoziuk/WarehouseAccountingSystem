using System.Linq;
using WarehouseAccountingSystem.Abstractions;
using WarehouseAccountingSystem.Entities;

namespace WarehouseAccountingSystem.Repositories.Interfaces
{
    public interface IBalanceRepository:IDbRepository<Balance>
    {
        IQueryable<Product> Products { get; }
    }
}
