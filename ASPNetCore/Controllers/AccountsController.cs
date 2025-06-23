using BLL;
using DAL.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ManagersUOW _managers;

        public AccountsController(ManagersUOW managers)
        {
            _managers = managers;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            var accounts = await _managers.Accounts.GetAllAsync();
            return View(accounts);
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _managers.Accounts.GetAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }
            var receipts = await _managers.Receipts.GetAllAsync(r => r.AccountId == id.Value);
            ViewBag.AccountId = id.Value;
            ViewBag.receipts = receipts;

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Account account)
        {
            if (ModelState.IsValid)
            {
                await _managers.Accounts.AddAsync(account);
                await _managers.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _managers.Accounts.GetByIdAsync((int) id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _managers.Accounts.UpdateAsync(id, account);
                    await _managers.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!( await AccountExists(account.Id) ))
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
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _managers.Accounts
                .GetAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _managers.Accounts.GetByIdAsync(id);
            if (account != null)
            {
                _managers.Accounts.Delete(account);
            }

            await _managers.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AccountExists(int id)
        {
            var accounts = await _managers.Accounts.GetAllAsync(a => a.Id == id);
            return accounts.Count() > 0;
        }
    }
}
