using WarehouseAccountingSystem.AppContext;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Generic;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Repositories
{
    public class CategoryRepository : DbRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
