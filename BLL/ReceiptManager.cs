using DAL.Data;
using DAL.Domain;

namespace BLL
{
    public class ReceiptManager : Manager<Receipt>
    {
        private readonly Context _context;
        public ReceiptManager(Context context) : base(context) { _context = context; }
        //public override Task Add(Receipt entity)
        //{
        //    return base.Add(entity);
        //}
    }
}
