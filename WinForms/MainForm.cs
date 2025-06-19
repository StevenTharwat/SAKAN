namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Dashboard
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TsmExpenseAccountDeclaration_Click(object sender, EventArgs e)
        {
            new AccountsFrom().Show();
        }
    }
}
