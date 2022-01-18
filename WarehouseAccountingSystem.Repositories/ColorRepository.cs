using WarehouseAccountingSystem.AppContext;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Generic;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Repositories
{
    public class ColorRepository : DbRepository<Color>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
