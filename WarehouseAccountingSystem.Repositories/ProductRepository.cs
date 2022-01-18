using System.Linq;
using WarehouseAccountingSystem.AppContext;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Generic;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Repositories
{
    public class ProductRepository : DbRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
        public IQueryable<Color> Colors => Context.Set<Color>();
        public IQueryable<Category> Categories => Context.Set<Category>();
    }
}
