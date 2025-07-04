﻿using DAL.Data;

namespace BLL
{
    public class ManagersUOW
    {
        private readonly Context _context;
        public AccountManager Accounts;
        public ReceiptManager Receipts;
        public ManagersUOW(Context context)
        {
            _context = context;
            Accounts = new(_context);
            Receipts = new(_context);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
