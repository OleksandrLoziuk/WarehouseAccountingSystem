using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Controllers
{
    public class BalanceController : Controller
    {
        private readonly IBalanceRepository _repository;

        public BalanceController(IBalanceRepository repository)
        {
            _repository = repository;
        }

        // GET: Balance
        public async Task<IActionResult> Index()
        {
            var data = await _repository.AllItems.Include(product => product.Product).ToListAsync();
            return View(data);
        }

        // GET: Balance/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _repository.AllItems.Include(product => product.Product).FirstOrDefaultAsync(x => x.Id == id.Value);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }
    }
}
