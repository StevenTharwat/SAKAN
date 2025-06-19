using DAL.Data;
using DAL.Domain;

namespace BLL
{
    public class DepartmentManager : Manager<Department>
    {
        private readonly Context _context;
        public DepartmentManager(Context context) : base(context)
        {
            _context = context;
        }
    }
}
