using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var data = await _repository.AllItems.Include(color => color.Color).Include(category => category.Category).ToListAsync();
            return View(data);
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _repository.AllItems.Include(product => product.Color).Include(product=>product.Category).FirstOrDefaultAsync(x => x.Id == id.Value);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["Colors"] = new SelectList(_repository.Colors, "Id", "ColorName");
            ViewData["Categories"] = new SelectList(_repository.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,Cost,Id,ColorId,CategoryId")] Product item)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddItemAsync(item);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Colors"] = new SelectList(_repository.Colors, "Id", "ColorName", item.ColorId);
            ViewData["Categories"] = new SelectList(_repository.Categories, "Id", "CategoryName", item.CategoryId);
            return View(item);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _repository.GetItemAsync(id.Value);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["Colors"] = new SelectList(_repository.Colors, "Id", "ColorName", item.ColorId);
            ViewData["Categories"] = new SelectList(_repository.Categories, "Id", "CategoryName", item.CategoryId);
            return View(item);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductName,Cost,Id,ColorId,CategoryId")] Product item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (!await _repository.ChangeItemAsync(item))
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Colors"] = new SelectList(_repository.Colors, "Id", "ColorName", item.ColorId);
            ViewData["Categories"] = new SelectList(_repository.Categories, "Id", "CategoryName", item.CategoryId);
            return View(item);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _repository.AllItems.Include(product => product.Color).Include(product => product.Category).FirstOrDefaultAsync(x => x.Id == id.Value);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteItemAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
