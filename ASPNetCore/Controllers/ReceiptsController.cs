using BLL;
using DAL.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly ManagersUOW _managers;

        public ReceiptsController(ManagersUOW managers)
        {
            _managers = managers;
        }

        // GET: Receipts
        public async Task<IActionResult> Index()
        {
            return View(await _managers.Receipts.GetAll());
        }

        // GET: Receipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Receipt = await _managers.Receipts.Get(m => m.Id == id);
            if (Receipt == null)
            {
                return NotFound();
            }

            return View(Receipt);
        }

        // GET: Receipts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Receipts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Receipt Receipt)
        {
            if (ModelState.IsValid)
            {
                await _managers.Receipts.Add(Receipt);
                await _managers.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Receipt);
        }

        // GET: Receipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Receipt = await _managers.Receipts.GetById((int) id);
            if (Receipt == null)
            {
                return NotFound();
            }
            return View(Receipt);
        }

        // POST: Receipts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Receipt Receipt)
        {
            if (id != Receipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _managers.Receipts.Update(id, Receipt);
                    await _managers.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!( await ReceiptExists(Receipt.Id) ))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Receipt);
        }

        // GET: Receipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Receipt = await _managers.Receipts
                .Get(m => m.Id == id);
            if (Receipt == null)
            {
                return NotFound();
            }

            return View(Receipt);
        }

        // POST: Receipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Receipt = await _managers.Receipts.GetById(id);
            if (Receipt != null)
            {
                _managers.Receipts.Delete(Receipt);
            }

            await _managers.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ReceiptExists(int id)
        {
            var Receipts = await _managers.Receipts.GetAll(a => a.Id == id);
            return Receipts.Count() > 0;
        }
    }
}
