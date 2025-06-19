namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            TsmAccountDecleration = new ToolStripMenuItem();
            TsmExpenseAccountDeclaration = new ToolStripMenuItem();
            TsmDepartmentDecliration = new ToolStripMenuItem();
            TsmAccounts = new ToolStripMenuItem();
            TsmAccountStatement = new ToolStripMenuItem();
            TsmReceipt = new ToolStripMenuItem();
            TsmCashReceipt = new ToolStripMenuItem();
            TsmPaymentReceipt = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            toolStripContainer2 = new ToolStripContainer();
            menuStrip1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStripContainer2.TopToolStripPanel.SuspendLayout();
            toolStripContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsmAccountDecleration, TsmAccounts, TsmReceipt });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1156, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TsmAccountDecleration
            // 
            TsmAccountDecleration.DropDownItems.AddRange(new ToolStripItem[] { TsmExpenseAccountDeclaration, TsmDepartmentDecliration });
            TsmAccountDecleration.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point,  0);
            TsmAccountDecleration.Name = "TsmAccountDecleration";
            TsmAccountDecleration.Size = new Size(137, 27);
            TsmAccountDecleration.Text = "تعريف حسابات";
            // 
            // TsmExpenseAccountDeclaration
            // 
            TsmExpenseAccountDeclaration.Name = "TsmExpenseAccountDeclaration";
            TsmExpenseAccountDeclaration.Size = new Size(198, 28);
            TsmExpenseAccountDeclaration.Text = "حساب مصروف";
            TsmExpenseAccountDeclaration.Click +=  TsmExpenseAccountDeclaration_Click ;
            // 
            // TsmDepartmentDecliration
            // 
            TsmDepartmentDecliration.Name = "TsmDepartmentDecliration";
            TsmDepartmentDecliration.Size = new Size(198, 28);
            TsmDepartmentDecliration.Text = "شقة";
            // 
            // TsmAccounts
            // 
            TsmAccounts.DropDownItems.AddRange(new ToolStripItem[] { TsmAccountStatement });
            TsmAccounts.Font = new Font("Tahoma", 14.25F);
            TsmAccounts.Name = "TsmAccounts";
            TsmAccounts.Size = new Size(87, 27);
            TsmAccounts.Text = "حسابات";
            // 
            // TsmAccountStatement
            // 
            TsmAccountStatement.Name = "TsmAccountStatement";
            TsmAccountStatement.Size = new Size(186, 28);
            TsmAccountStatement.Text = "كشف حساب";
            // 
            // TsmReceipt
            // 
            TsmReceipt.DropDownItems.AddRange(new ToolStripItem[] { TsmCashReceipt, TsmPaymentReceipt });
            TsmReceipt.Font = new Font("Tahoma", 14.25F);
            TsmReceipt.Name = "TsmReceipt";
            TsmReceipt.Size = new Size(110, 27);
            TsmReceipt.Text = "حركة نقدية";
            // 
            // TsmCashReceipt
            // 
            TsmCashReceipt.Name = "TsmCashReceipt";
            TsmCashReceipt.Size = new Size(181, 28);
            TsmCashReceipt.Text = "تحصيل نقدية";
            // 
            // TsmPaymentReceipt
            // 
            TsmPaymentReceipt.Name = "TsmPaymentReceipt";
            TsmPaymentReceipt.Size = new Size(181, 28);
            TsmPaymentReceipt.Text = "دفع نقدية";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(1156, 570);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1156, 595);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            toolStripContainer2.ContentPanel.Size = new Size(1156, 564);
            toolStripContainer2.Dock = DockStyle.Fill;
            toolStripContainer2.Location = new Point(0, 0);
            toolStripContainer2.Name = "toolStripContainer2";
            toolStripContainer2.Size = new Size(1156, 595);
            toolStripContainer2.TabIndex = 2;
            toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            toolStripContainer2.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  20,   34,   92);
            ClientSize = new Size(1156, 595);
            Controls.Add(toolStripContainer2);
            Controls.Add(toolStripContainer1);
            Icon = (Icon) resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الرئيسية";
            WindowState = FormWindowState.Maximized;
            FormClosed +=  MainForm_FormClosed ;
            Load +=  MainForm_Load ;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer2.TopToolStripPanel.PerformLayout();
            toolStripContainer2.ResumeLayout(false);
            toolStripContainer2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TsmAccountDecleration;
        private ToolStripMenuItem TsmExpenseAccountDeclaration;
        private ToolStripMenuItem TsmDepartmentDecliration;
        private ToolStripMenuItem TsmAccounts;
        private ToolStripMenuItem TsmReceipt;
        private ToolStripMenuItem TsmCashReceipt;
        private ToolStripMenuItem TsmPaymentReceipt;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem TsmAccountStatement;
        private ToolStripContainer toolStripContainer2;
    }
}
