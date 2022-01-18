using WarehouseAccountingSystem.AppContext;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Generic;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Repositories
{
    public class StringsOrderRepository : DbRepository<StringsOrder>, IStringsOrderRepository
    {
        public StringsOrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
