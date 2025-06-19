

using DAL.Domain;

namespace WinForms
{
    public partial class AccountsFrom : Form
    {
        List<Account> accounts = [];
        public AccountsFrom()
        {
            InitializeComponent();
            ShowDataGrid();
        }

        void ShowDataGrid()
        {
            DtMain.DataSource = accounts;
            ChangeColumnsConfigration();
            LabTotalCount.Text = accounts.Count.ToString();
            LabTotalBalances.Text = accounts.Sum(acc => acc.GetBalance()).ToString();
        }
        void ChangeColumnsConfigration()
        {
            if (DtMain.Columns.Contains("Id")) DtMain.Columns["Id"].Visible = false;
            if (DtMain.Columns.Contains("SerialNumber")) DtMain.Columns["SerialNumber"].HeaderText = "الرقم التسلسلي";
            if (DtMain.Columns.Contains("Balance")) DtMain.Columns["Balance"].HeaderText = "اجمالي الحساب";
            if (DtMain.Columns.Contains("Name")) DtMain.Columns["Name"].HeaderText = "الاسم";
            if (DtMain.Columns.Contains("Address")) DtMain.Columns["Address"].HeaderText = "العنوان";
            if (DtMain.Columns.Contains("Description")) DtMain.Columns["Description"].HeaderText = "الملاحظات";
            if (DtMain.Columns.Contains("AdditionalInfo")) DtMain.Columns["AdditionalInfo"].HeaderText = "ملاحظات اضافية";
            //if(DtMain.Columns.Contains("Receipts")) DtMain.Columns["Receipts"].Visible = false;
            if (DtMain.Columns.Contains("CreatedAt")) DtMain.Columns["CreatedAt"].HeaderText = "تاريخ الانشاء";
        }
    }
}
