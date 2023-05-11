namespace QLLH_ThayCao
{
    partial class Main_frm
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_frm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýKhóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhóaToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem,
            this.quảnLýGiảngViênToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýKhóaToolStripMenuItem
            // 
            this.quảnLýKhóaToolStripMenuItem.Name = "quảnLýKhóaToolStripMenuItem";
            this.quảnLýKhóaToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.quảnLýKhóaToolStripMenuItem.Text = "Quản lý Khóa học ";
            this.quảnLýKhóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhóaToolStripMenuItem_Click);
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý Lớp học";
            // 
            // quảnLýGiảngViênToolStripMenuItem
            // 
            this.quảnLýGiảngViênToolStripMenuItem.Name = "quảnLýGiảngViênToolStripMenuItem";
            this.quảnLýGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.quảnLýGiảngViênToolStripMenuItem.Text = "Quản lý Giảng viên";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý Sinh viên";
            // 
            // Main_pnl
            // 
            this.Main_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_pnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main_pnl.Location = new System.Drawing.Point(0, 26);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(800, 412);
            this.Main_pnl.TabIndex = 1;
            this.Main_pnl.Resize += new System.EventHandler(this.Main_pnl_Resize);
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_pnl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_frm";
            this.Text = "Hệ thống quản lý Khóa Học - Thầy Cáo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.Panel Main_pnl;
    }
}

