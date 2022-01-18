﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseAccountingSystem.Entities;
using WarehouseAccountingSystem.Repositories.Interfaces;

namespace WarehouseAccountingSystem.Controllers
{
    public class StringsOrderController : Controller
    {
        private readonly IStringsOrderRepository _repository;

        public StringsOrderController(IStringsOrderRepository repository)
        {
            _repository = repository;
        }

        // GET: StringsOrder
        public async Task<IActionResult> Index()
        {
            return View(await _repository.ToListAsync());
        }

        // GET: StringsOrder/Details/5
        public async Task<IActionResult> Details(int? id)
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

            return View(item);
        }

        // GET: StringsOrder/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StringsOrder/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderQuantity,OrderAmount,Id")] StringsOrder item)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddItemAsync(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: StringsOrder/Edit/5
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
            return View(item);
        }

        // POST: StringsOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderQuantity,OrderAmount,Id")] StringsOrder item)
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
            return View(item);
        }

        // GET: StringsOrder/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            return View(item);
        }

        // POST: StringsOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteItemAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
