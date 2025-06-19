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
    }
}
