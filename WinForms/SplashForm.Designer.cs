﻿namespace WinForms
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            pictureBox1 = new PictureBox();
            ( (System.ComponentModel.ISupportInitialize) pictureBox1 ).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image) resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(780, 224);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  20,   34,   92);
            ClientSize = new Size(1000, 500);
            Controls.Add(pictureBox1);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAKAN";
            Load +=  SplashForm_Load ;
            ( (System.ComponentModel.ISupportInitialize) pictureBox1 ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
    }
}