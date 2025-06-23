using DAL.Data;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class ReceiptManager : Manager<Receipt>
    {
        private readonly Context _context;
        public ReceiptManager(Context context) : base(context) { _context = context; }
        public override async Task AddAsync(Receipt entity)
        {
            Account account = await GetAccount(entity);
            account.AddRecipt(entity);
            await base.AddAsync(entity);
        }

        public async Task DeleteAsync(Receipt entity)
        {
            Account account = await GetAccount(entity);
            account.DeleteRecipt(entity.Id);
            base.Delete(entity);
        }
        public override async Task UpdateAsync(int id, Receipt entity)
        {
            Account account = await GetAccount(entity);
            account.UpdateRecipt(entity);
            //await base.UpdateAsync(id, entity);
        }


        private async Task<Account> GetAccount(Receipt entity)
        {
            Account account = await _context.Accounts.Include(a => a.Receipts).FirstOrDefaultAsync(a => a.Id == entity.AccountId);
            if (account == null)
                throw new ArgumentException("The specified account does not exist.");

            return account;
        }
    }
}
