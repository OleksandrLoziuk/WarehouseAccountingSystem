using System.Linq;
using WarehouseAccountingSystem.Abstractions;
using WarehouseAccountingSystem.Entities;

namespace WarehouseAccountingSystem.Repositories.Interfaces
{
    public interface IReceiptRepository:IDbRepository<Receipt>
    {
        IQueryable<Product> Products { get; }
    }
}
