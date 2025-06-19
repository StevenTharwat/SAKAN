using ASPNetCore.Models;
using BLL;
using DAL.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCore.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ManagersUOW _managers;

        public DepartmentsController(ManagersUOW managers)
        {
            _managers = managers;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            var departments = await _managers.Departments.GetAll();
            return View($"AccountViews/{nameof(Index)}", AccountViewModel.ToAccountViewModel(departments));
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Department = await _managers.Departments.Get(m => m.Id == id);
            if (Department == null)
            {
                return NotFound();
            }

            return View($"AccountViews/{nameof(Details)}", new AccountViewModel(Department));
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            return View($"AccountViews/{nameof(Create)}");
        }

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department Department)
        {
            if (ModelState.IsValid)
            {
                await _managers.Departments.Add(Department);
                await _managers.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View($"AccountViews/{nameof(Create)}", new AccountViewModel(Department));
        }

        // GET: Departments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Department = await _managers.Departments.GetById((int) id);
            if (Department == null)
            {
                return NotFound();
            }
            return View($"AccountViews/{nameof(Edit)}", new AccountViewModel(Department));
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Department Department)
        {
            if (id != Department.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _managers.Departments.Update(id, Department);
                    await _managers.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!( await DepartmentExists(Department.Id) ))
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
            return View($"AccountViews/{nameof(Edit)}", new AccountViewModel(Department));
        }

        // GET: Departments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Department = await _managers.Departments
                .Get(m => m.Id == id);
            if (Department == null)
            {
                return NotFound();
            }

            return View($"AccountViews/{nameof(Delete)}", new AccountViewModel(Department));
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Department = await _managers.Departments.GetById(id);
            if (Department != null)
            {
                _managers.Departments.Delete(Department);
            }

            await _managers.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> DepartmentExists(int id)
        {
            var Departments = await _managers.Departments.GetAll(a => a.Id == id);
            return Departments.Count() > 0;
        }
    }
}
