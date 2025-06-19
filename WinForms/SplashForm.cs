using Timer = System.Windows.Forms.Timer;

namespace WinForms
{
    public partial class SplashForm : Form
    {
        private readonly Timer timer = new();
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            new MainForm().Show();
            this.Close();
        }
    }
}
