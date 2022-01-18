using System.Linq;
using WarehouseAccountingSystem.AppContext;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Generic;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Repositories
{
    public class BalanceRepository : DbRepository<Balance>, IBalanceRepository
    {
        public BalanceRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<Product> Products => Context.Set<Product>();
    }
}
