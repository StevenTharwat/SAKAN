using ASPNetCore.Models;
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
            var accounts = await _managers.Accounts.GetAll();
            return View($"AccountViews/{nameof(Index)}", AccountViewModel.ToAccountViewModel(accounts));
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _managers.Accounts.Get(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View($"AccountViews/{nameof(Details)}", new AccountViewModel(account));
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View($"AccountViews/{nameof(Create)}");
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
                await _managers.Accounts.Add(account);
                await _managers.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View($"AccountViews/{nameof(Create)}", new AccountViewModel(account));
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _managers.Accounts.GetById((int) id);
            if (account == null)
            {
                return NotFound();
            }
            return View($"AccountViews/{nameof(Edit)}", new AccountViewModel(account));
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
                    await _managers.Accounts.Update(id, account);
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
            return View($"AccountViews/{nameof(Edit)}", new AccountViewModel(account));
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _managers.Accounts
                .Get(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View($"AccountViews/{nameof(Delete)}", new AccountViewModel(account));
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _managers.Accounts.GetById(id);
            if (account != null)
            {
                _managers.Accounts.Delete(account);
            }

            await _managers.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AccountExists(int id)
        {
            var accounts = await _managers.Accounts.GetAll(a => a.Id == id);
            return accounts.Count() > 0;
        }
    }
}
