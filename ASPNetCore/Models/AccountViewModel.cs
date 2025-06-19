using DAL.Domain;
using DAL.Statics;
using System.ComponentModel.DataAnnotations;

namespace ASPNetCore.Models
{
    public enum AccountType
    {
        [Display(Name = "حساب")]
        Account,
        [Display(Name = "شقة")]
        Department,
    }
    public class AccountViewModel : Account
    {
        [Display(Name = "عدد السكان في الوحدة")]
        public int? NumberOfPeople { get; set; }
        [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
        public AccountType Type { get; set; }
        public AccountViewModel(Account account)
        {
            updateProps(account);
            Type = AccountType.Account;
        }

        public AccountViewModel(Department department)
        {
            updateProps(department);
            this.NumberOfPeople = department.NumberOfPeople;
            Type = AccountType.Department;
        }
        static public IEnumerable<AccountViewModel> ToAccountViewModel(IEnumerable<Department> departments)
        {
            IEnumerable<AccountViewModel> ViewAccounts = departments.Select(d => new AccountViewModel(d));
            return ViewAccounts;
        }
        static public IEnumerable<AccountViewModel> ToAccountViewModel(IEnumerable<Account> accounts)
        {
            IEnumerable<AccountViewModel> ViewAccounts = accounts.Select(d => new AccountViewModel(d));
            return ViewAccounts;
        }

        private void updateProps(Account account)
        {
            this.Id = account.Id;
            this.SerialNumber = account.SerialNumber;
            this.Name = account.Name;
            this.Address = account.Address;
            this.Description = account.Description;
            this.AdditionalInfo = account.AdditionalInfo;
            this.CreatedAt = account.CreatedAt;
            this.Credit = account.Credit;
            this.Debit = account.Debit;
            this.Receipts = account.Receipts;
        }
    }

}
