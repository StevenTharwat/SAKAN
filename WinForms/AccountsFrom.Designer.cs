namespace WinForms
{
    partial class AccountsFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            panel1 = new Panel();
            DtMain = new DataGridView();
            pnlActions = new Panel();
            LabTotalBalances = new Label();
            label5 = new Label();
            LabTotalCount = new Label();
            label3 = new Label();
            pnlFilter = new Panel();
            BtnFilter = new Button();
            btnAdd = new Button();
            dtpTo = new DateTimePicker();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            label1 = new Label();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) DtMain ).BeginInit();
            pnlActions.SuspendLayout();
            pnlFilter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.WhiteSmoke;
            pnlMain.Controls.Add(panel1);
            pnlMain.Controls.Add(pnlActions);
            pnlMain.Controls.Add(pnlFilter);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1050, 525);
            pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DtMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(203, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 8, 9, 8);
            panel1.Size = new Size(847, 492);
            panel1.TabIndex = 3;
            // 
            // DtMain
            // 
            DtMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            DtMain.BorderStyle = BorderStyle.None;
            DtMain.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DtMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DtMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DtMain.DefaultCellStyle = dataGridViewCellStyle2;
            DtMain.Dock = DockStyle.Fill;
            DtMain.Location = new Point(9, 8);
            DtMain.Name = "DtMain";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DtMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DtMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtMain.Size = new Size(829, 476);
            DtMain.TabIndex = 0;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.Controls.Add(LabTotalBalances);
            pnlActions.Controls.Add(label5);
            pnlActions.Controls.Add(LabTotalCount);
            pnlActions.Controls.Add(label3);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(203, 492);
            pnlActions.Margin = new Padding(3, 2, 3, 2);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(847, 33);
            pnlActions.TabIndex = 2;
            // 
            // LabTotalBalances
            // 
            LabTotalBalances.AutoSize = true;
            LabTotalBalances.Dock = DockStyle.Right;
            LabTotalBalances.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            LabTotalBalances.ForeColor = Color.Purple;
            LabTotalBalances.Location = new Point(488, 0);
            LabTotalBalances.Name = "LabTotalBalances";
            LabTotalBalances.Size = new Size(25, 30);
            LabTotalBalances.TabIndex = 3;
            LabTotalBalances.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label5.Location = new Point(513, 0);
            label5.Name = "label5";
            label5.Size = new Size(192, 25);
            label5.TabIndex = 2;
            label5.Text = "اجمالي رصيد الحسابات:";
            // 
            // LabTotalCount
            // 
            LabTotalCount.AutoSize = true;
            LabTotalCount.Dock = DockStyle.Right;
            LabTotalCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            LabTotalCount.ForeColor = Color.Purple;
            LabTotalCount.Location = new Point(705, 0);
            LabTotalCount.Name = "LabTotalCount";
            LabTotalCount.Size = new Size(25, 30);
            LabTotalCount.TabIndex = 1;
            LabTotalCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label3.Location = new Point(730, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 0;
            label3.Text = "اجمالي العدد:";
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.WhiteSmoke;
            pnlFilter.Controls.Add(BtnFilter);
            pnlFilter.Controls.Add(btnAdd);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(label2);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(label1);
            pnlFilter.Controls.Add(lblTitle);
            pnlFilter.Dock = DockStyle.Left;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Margin = new Padding(3, 2, 3, 2);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(203, 525);
            pnlFilter.TabIndex = 1;
            // 
            // BtnFilter
            // 
            BtnFilter.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point,  0);
            BtnFilter.Location = new Point(14, 177);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(176, 39);
            BtnFilter.TabIndex = 5;
            BtnFilter.Text = "تطبيق";
            BtnFilter.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(203, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "اضافة حساب جديد";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dtpTo
            // 
            dtpTo.CalendarFont = new Font("Segoe UI", 9F);
            dtpTo.Font = new Font("Segoe UI", 12F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(14, 130);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.RightToLeftLayout = true;
            dtpTo.Size = new Size(176, 29);
            dtpTo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(  20,   34,   92);
            label2.Location = new Point(123, 106);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 3;
            label2.Text = "الي تاريخ";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarFont = new Font("Segoe UI", 9F);
            dtpFrom.Font = new Font("Segoe UI", 12F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(14, 71);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.RightToLeftLayout = true;
            dtpFrom.Size = new Size(176, 29);
            dtpFrom.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(  20,   34,   92);
            label1.Location = new Point(125, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 1;
            label1.Text = "من تاريخ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(  20,   34,   92);
            lblTitle.Location = new Point(51, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(103, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "لوحة التحكم";
            lblTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // AccountsFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 525);
            Controls.Add(pnlMain);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 460);
            Name = "AccountsFrom";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الحسابات";
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ( (System.ComponentModel.ISupportInitialize) DtMain ).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlFilter;
        private Label lblTitle;
        private Panel pnlActions;
        private DateTimePicker dtpFrom;
        private Label label1;
        private DateTimePicker dtpTo;
        private Label label2;
        private Panel panel1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridView DtMain;
        private Button btnAdd;
        private Button BtnFilter;
        private Label LabTotalCount;
        private Label label3;
        private Label LabTotalBalances;
        private Label label5;
    }
}