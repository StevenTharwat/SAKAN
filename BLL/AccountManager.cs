using DAL.Data;
using DAL.Domain;

namespace BLL
{
    public class AccountManager : Manager<Account>
    {
        private readonly Context _context;
        public AccountManager(Context context) : base(context)
        {
            _context = context;
        }
        public override void Delete(Account entity)
        {
            var receipts = _context.Receipts.Where(r => r.AccountId == entity.Id).ToList();
            foreach (var receipt in receipts)
            {
                receipt.IsDeleted = true;
            }
            base.Delete(entity);
        }
    }
}
