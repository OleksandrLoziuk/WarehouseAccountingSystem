using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly IReceiptRepository _repository;
        private readonly IProductRepository _productRepository;
        private readonly IBalanceRepository _balanceRepository;
        public ReceiptController(IReceiptRepository repository, IProductRepository productRepository, IBalanceRepository balanceRepository)
        {
            _repository = repository;
            _productRepository = productRepository;
            _balanceRepository = balanceRepository;
        }

        // GET: Receipt
        public async Task<IActionResult> Index()
        {
            var data = await _repository.AllItems.Include(product => product.Product).ToListAsync();
            return View(data);
        }

        // GET: Receipt/Details/5
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

        // GET: Receipt/Create
        public IActionResult Create()
        {
            ViewData["Products"] = new SelectList(_repository.Products, "Id", "ProductName");
            return View();
        }

        // POST: Receipt/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReceiptQuantity,ReceiptAmount,ReceiptDate,Id,ProductId")] Receipt item)
        {
            if (ModelState.IsValid)
            {
                var itemP = await _productRepository.GetItemAsync(item.ProductId);
                item.ReceiptAmount = item.ReceiptQuantity * itemP.Cost;
                item.ReceiptDate = DateTime.Now;
                await _repository.AddItemAsync(item);

                var itemB = await _balanceRepository.AllItems.Include(product => product.Product).FirstOrDefaultAsync(x => x.Id == itemP.Id);
                if (itemB != null)
                {
                    itemB.Quantity += item.ReceiptQuantity;
                    itemB.Amount += item.ReceiptAmount;
                    await _balanceRepository.SaveChangesAsync();
                }
                else
                {
                    itemB = new Balance();
                    itemB.ProductId = itemP.Id;
                    itemB.Amount = item.ReceiptAmount;
                    itemB.Quantity = item.ReceiptQuantity;
                    await _balanceRepository.AddItemAsync(itemB);
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["Products"] = new SelectList(_repository.Products, "Id", "ProductName", item.ProductId);
            return View(item);
        }
        // GET: Receipt/Delete/5
        public async Task<IActionResult> Delete(int? id)
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
            await _repository.AllItems.Include(product => product.Product).FirstOrDefaultAsync(x => x.Id == id.Value);
            return View(item);
        }

        // POST: Receipt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _repository.AllItems.Include(product => product.Product).FirstOrDefaultAsync(x => x.Id == id);
            var itemB = await _balanceRepository.AllItems.Include(product => product.Product).FirstOrDefaultAsync(x => x.Id == item.ProductId);
            itemB.Quantity -= item.ReceiptQuantity;
            itemB.Amount -= item.ReceiptAmount;
            await _repository.DeleteItemAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
