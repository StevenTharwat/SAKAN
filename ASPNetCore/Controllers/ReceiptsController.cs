using ASPNetCore.Models;
using BLL;
using DAL.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCore.Controllers
{
    public class ReceiptsController : Controller
    {
        private readonly ManagersUOW _managers;

        public ReceiptsController(ManagersUOW managers)
        {
            _managers = managers;
        }

        [HttpGet]
        public async Task<IActionResult> Create(CreateReceiptViewModel? errorModel = null, int AccountId = -1)
        {
            var accounts = await _managers.Accounts.GetAllAsync();
            ViewBag.Accounts = accounts; // Populate accounts dropdown

            if (errorModel?.Rows.Count > 0) //if errorModel != null
            {
                return View(errorModel);
            }

            var model = new CreateReceiptViewModel
            {
                Rows = [new ReceiptRowViewModel()] //create the first row by default
            };

            if (AccountId != -1)
            {
                var account = accounts.FirstOrDefault(a => a.Id == AccountId);
                if (account != null)
                {
                    model.AccountId = account.Id;
                    model.Type = account.Type;
                }
            }

            return View(model);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmCreate(CreateReceiptViewModel model)
        {
            var account = await _managers.Accounts.GetByIdAsync(model.AccountId);
            if (account == null)
            {
                ModelState.AddModelError("AccountId", "الحساب المحدد غير موجود.");
            }
            if (model.Rows.Count < 1)
            {
                ModelState.AddModelError("Rows", "يجب إضافة صف واحد على الأقل.");
            }
            if (model.Rows.Any(r => r.MoneyAmount < 0))
            {
                ModelState.AddModelError("Rows", "يجب أن تكون القيمة النقدية أكبر من الصفر.");
            }
            //if (model.Rows.Any(r => r.Type == ReceiptType.None))
            //{
            //    ModelState.AddModelError("Rows", "يجب تحديد نوع الحركة لكل صف.");
            //}
            if (model.CreatedAt > DateTime.Today)
            {
                ModelState.AddModelError("CreatedAt", "تاريخ الحركة لا يمكن أن يكون في المستقبل.");

            }
            if (ModelState.IsValid)
            {
                foreach (ReceiptRowViewModel row in model.Rows)
                {
                    var receipt = row.ToReceipt(model);
                    account.AddRecipt(receipt);
                }

                await _managers.Accounts.UpdateAsync(account.Id, account);
                await _managers.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return await Create(model);
        }

        // GET: Receipts
        public async Task<IActionResult> Index(int? accountId = null)
        {
            var receipts = await _managers.Receipts.GetAllAsync(includeProperties: "Account");
            if (accountId != null)
            {
                receipts = receipts.Where(r => r.AccountId == accountId);
                ViewBag.AccountId = accountId;
            }
            return View(receipts);
        }

        // GET: Receipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Receipt = await _managers.Receipts.GetAsync(includeProperties: "Account", filter: m => m.Id == id.Value);
            if (Receipt == null)
            {
                return NotFound();
            }

            return View(Receipt);
        }

        public async Task<ActionResult> Print(int? id)
        {
            var Receipt = await _managers.Receipts.GetAsync(includeProperties: "Account", filter: m => m.Id == id.Value);


            if (Receipt == null)
            {
                return NotFound();
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

            var Receipt = await _managers.Receipts.GetByIdAsync((int) id);
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
                    await _managers.Receipts.UpdateAsync(id, Receipt);
                    await _managers.SaveChangesAsync();
                }
                catch (Exception)
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

            var Receipt = await _managers.Receipts.GetAsync(includeProperties: "Account", filter: m => m.Id == id.Value);

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
            var Receipt = await _managers.Receipts.GetByIdAsync(id);
            if (Receipt != null)
            {
                await _managers.Receipts.DeleteAsync(Receipt);
            }

            await _managers.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ReceiptExists(int id)
        {
            var Receipts = await _managers.Receipts.GetAllAsync(a => a.Id == id);
            return Receipts.Count() > 0;
        }
    }
}


//public IActionResult AddRow([FromBody] CreateReceiptViewModel model)
//{
//    model.Rows.AddAsync(new ReceiptRowViewModel());
//    return PartialView("_ReceiptRow", model);
//}
// // GET: Receipts/Create
// public IActionResult Create()
// {
//     return View();
// }

// //POST: Receipts/Create
// //To protect from overposting attacks, enable the specific properties you want to bind to.
// //For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

//[HttpPost]
// [ValidateAntiForgeryToken]
// public async Task<IActionResult> Create(Receipt Receipt)
// {
//     if (ModelState.IsValid)
//     {
//         await _managers.Receipts.AddAsync(Receipt);
//         await _managers.SaveChangesAsync();
//         return RedirectToAction(nameof(Index));
//     }
//     return View(Receipt);
// }