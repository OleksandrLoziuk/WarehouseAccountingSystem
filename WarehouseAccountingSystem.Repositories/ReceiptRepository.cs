using System.Linq;
using WarehouseAccountingSystem.AppContext;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Generic;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Repositories
{
    public class ReceiptRepository : DbRepository<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<Product> Products => Context.Set<Product>();
    }
}
