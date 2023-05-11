namespace QLLH_ThayCao
{
    partial class QuanLyKhoaHoc_frm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Xoa_but = new System.Windows.Forms.Button();
            this.Sua_but = new System.Windows.Forms.Button();
            this.Them_but = new System.Windows.Forms.Button();
            this.SoBuoiLyThuyet_txt = new System.Windows.Forms.TextBox();
            this.SoBuoiThucHanh_txt = new System.Windows.Forms.TextBox();
            this.KinhPhi_txt = new System.Windows.Forms.TextBox();
            this.GioiHanGiangVien_txt = new System.Windows.Forms.TextBox();
            this.GioiHanSinhVien_txt = new System.Windows.Forms.TextBox();
            this.ThoiGian_txt = new System.Windows.Forms.TextBox();
            this.TenKhoaHoc_txt = new System.Windows.Forms.TextBox();
            this.MaKhoaHoc_txt = new System.Windows.Forms.TextBox();
            this.SoBuoiLyThuyet_lbl = new System.Windows.Forms.Label();
            this.BuoiThucHanh_lbl = new System.Windows.Forms.Label();
            this.KinhPhi_lbl = new System.Windows.Forms.Label();
            this.GioiHanGiangVien_lbl = new System.Windows.Forms.Label();
            this.GioiHanSinhVien_lbl = new System.Windows.Forms.Label();
            this.ThoiGian_lbl = new System.Windows.Forms.Label();
            this.TenKhoaHoc_lbl = new System.Windows.Forms.Label();
            this.MaKhoaHoc_lbl = new System.Windows.Forms.Label();
            this.DanhSachKhoaHoc_dgv = new System.Windows.Forms.DataGridView();
            this.LamMoi_ = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhoaHoc_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.LamMoi_);
            this.splitContainer1.Panel1.Controls.Add(this.Xoa_but);
            this.splitContainer1.Panel1.Controls.Add(this.Sua_but);
            this.splitContainer1.Panel1.Controls.Add(this.Them_but);
            this.splitContainer1.Panel1.Controls.Add(this.SoBuoiLyThuyet_txt);
            this.splitContainer1.Panel1.Controls.Add(this.SoBuoiThucHanh_txt);
            this.splitContainer1.Panel1.Controls.Add(this.KinhPhi_txt);
            this.splitContainer1.Panel1.Controls.Add(this.GioiHanGiangVien_txt);
            this.splitContainer1.Panel1.Controls.Add(this.GioiHanSinhVien_txt);
            this.splitContainer1.Panel1.Controls.Add(this.ThoiGian_txt);
            this.splitContainer1.Panel1.Controls.Add(this.TenKhoaHoc_txt);
            this.splitContainer1.Panel1.Controls.Add(this.MaKhoaHoc_txt);
            this.splitContainer1.Panel1.Controls.Add(this.SoBuoiLyThuyet_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.BuoiThucHanh_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.KinhPhi_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.GioiHanGiangVien_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.GioiHanSinhVien_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.ThoiGian_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.TenKhoaHoc_lbl);
            this.splitContainer1.Panel1.Controls.Add(this.MaKhoaHoc_lbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DanhSachKhoaHoc_dgv);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 736);
            this.splitContainer1.SplitterDistance = 549;
            this.splitContainer1.TabIndex = 0;
            // 
            // Xoa_but
            // 
            this.Xoa_but.Location = new System.Drawing.Point(338, 610);
            this.Xoa_but.Name = "Xoa_but";
            this.Xoa_but.Size = new System.Drawing.Size(133, 45);
            this.Xoa_but.TabIndex = 2;
            this.Xoa_but.Text = "Xóa";
            this.Xoa_but.UseVisualStyleBackColor = true;
            // 
            // Sua_but
            // 
            this.Sua_but.Location = new System.Drawing.Point(338, 567);
            this.Sua_but.Name = "Sua_but";
            this.Sua_but.Size = new System.Drawing.Size(133, 37);
            this.Sua_but.TabIndex = 2;
            this.Sua_but.Text = "Sửa";
            this.Sua_but.UseVisualStyleBackColor = true;
            this.Sua_but.Click += new System.EventHandler(this.Sua_but_Click);
            // 
            // Them_but
            // 
            this.Them_but.Location = new System.Drawing.Point(338, 520);
            this.Them_but.Name = "Them_but";
            this.Them_but.Size = new System.Drawing.Size(133, 41);
            this.Them_but.TabIndex = 2;
            this.Them_but.Text = "Thêm";
            this.Them_but.UseVisualStyleBackColor = true;
            this.Them_but.Click += new System.EventHandler(this.Them_but_Click);
            // 
            // SoBuoiLyThuyet_txt
            // 
            this.SoBuoiLyThuyet_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoBuoiLyThuyet_txt.Location = new System.Drawing.Point(187, 422);
            this.SoBuoiLyThuyet_txt.Name = "SoBuoiLyThuyet_txt";
            this.SoBuoiLyThuyet_txt.Size = new System.Drawing.Size(361, 22);
            this.SoBuoiLyThuyet_txt.TabIndex = 1;
            // 
            // SoBuoiThucHanh_txt
            // 
            this.SoBuoiThucHanh_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoBuoiThucHanh_txt.Location = new System.Drawing.Point(187, 361);
            this.SoBuoiThucHanh_txt.Name = "SoBuoiThucHanh_txt";
            this.SoBuoiThucHanh_txt.Size = new System.Drawing.Size(361, 22);
            this.SoBuoiThucHanh_txt.TabIndex = 1;
            // 
            // KinhPhi_txt
            // 
            this.KinhPhi_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KinhPhi_txt.Location = new System.Drawing.Point(187, 304);
            this.KinhPhi_txt.Name = "KinhPhi_txt";
            this.KinhPhi_txt.Size = new System.Drawing.Size(361, 22);
            this.KinhPhi_txt.TabIndex = 1;
            // 
            // GioiHanGiangVien_txt
            // 
            this.GioiHanGiangVien_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GioiHanGiangVien_txt.Location = new System.Drawing.Point(187, 249);
            this.GioiHanGiangVien_txt.Name = "GioiHanGiangVien_txt";
            this.GioiHanGiangVien_txt.Size = new System.Drawing.Size(361, 22);
            this.GioiHanGiangVien_txt.TabIndex = 1;
            // 
            // GioiHanSinhVien_txt
            // 
            this.GioiHanSinhVien_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GioiHanSinhVien_txt.Location = new System.Drawing.Point(187, 190);
            this.GioiHanSinhVien_txt.Name = "GioiHanSinhVien_txt";
            this.GioiHanSinhVien_txt.Size = new System.Drawing.Size(361, 22);
            this.GioiHanSinhVien_txt.TabIndex = 1;
            // 
            // ThoiGian_txt
            // 
            this.ThoiGian_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThoiGian_txt.Location = new System.Drawing.Point(187, 137);
            this.ThoiGian_txt.Name = "ThoiGian_txt";
            this.ThoiGian_txt.Size = new System.Drawing.Size(361, 22);
            this.ThoiGian_txt.TabIndex = 1;
            // 
            // TenKhoaHoc_txt
            // 
            this.TenKhoaHoc_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TenKhoaHoc_txt.Location = new System.Drawing.Point(187, 86);
            this.TenKhoaHoc_txt.Name = "TenKhoaHoc_txt";
            this.TenKhoaHoc_txt.Size = new System.Drawing.Size(361, 22);
            this.TenKhoaHoc_txt.TabIndex = 1;
            // 
            // MaKhoaHoc_txt
            // 
            this.MaKhoaHoc_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaKhoaHoc_txt.Location = new System.Drawing.Point(187, 33);
            this.MaKhoaHoc_txt.Name = "MaKhoaHoc_txt";
            this.MaKhoaHoc_txt.Size = new System.Drawing.Size(361, 22);
            this.MaKhoaHoc_txt.TabIndex = 1;
            // 
            // SoBuoiLyThuyet_lbl
            // 
            this.SoBuoiLyThuyet_lbl.AutoSize = true;
            this.SoBuoiLyThuyet_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBuoiLyThuyet_lbl.Location = new System.Drawing.Point(17, 422);
            this.SoBuoiLyThuyet_lbl.Name = "SoBuoiLyThuyet_lbl";
            this.SoBuoiLyThuyet_lbl.Size = new System.Drawing.Size(146, 20);
            this.SoBuoiLyThuyet_lbl.TabIndex = 0;
            this.SoBuoiLyThuyet_lbl.Text = "Số Buổi Lý Thuyết";
            // 
            // BuoiThucHanh_lbl
            // 
            this.BuoiThucHanh_lbl.AutoSize = true;
            this.BuoiThucHanh_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuoiThucHanh_lbl.Location = new System.Drawing.Point(17, 361);
            this.BuoiThucHanh_lbl.Name = "BuoiThucHanh_lbl";
            this.BuoiThucHanh_lbl.Size = new System.Drawing.Size(155, 20);
            this.BuoiThucHanh_lbl.TabIndex = 0;
            this.BuoiThucHanh_lbl.Text = "Số Buổi Thực Hành";
            // 
            // KinhPhi_lbl
            // 
            this.KinhPhi_lbl.AutoSize = true;
            this.KinhPhi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KinhPhi_lbl.Location = new System.Drawing.Point(17, 306);
            this.KinhPhi_lbl.Name = "KinhPhi_lbl";
            this.KinhPhi_lbl.Size = new System.Drawing.Size(151, 20);
            this.KinhPhi_lbl.TabIndex = 0;
            this.KinhPhi_lbl.Text = "Kinh Phí Đóng Góp";
            // 
            // GioiHanGiangVien_lbl
            // 
            this.GioiHanGiangVien_lbl.AutoSize = true;
            this.GioiHanGiangVien_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiHanGiangVien_lbl.Location = new System.Drawing.Point(17, 251);
            this.GioiHanGiangVien_lbl.Name = "GioiHanGiangVien_lbl";
            this.GioiHanGiangVien_lbl.Size = new System.Drawing.Size(162, 20);
            this.GioiHanGiangVien_lbl.TabIndex = 0;
            this.GioiHanGiangVien_lbl.Text = "Giới Hạn Giảng Viên";
            // 
            // GioiHanSinhVien_lbl
            // 
            this.GioiHanSinhVien_lbl.AutoSize = true;
            this.GioiHanSinhVien_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiHanSinhVien_lbl.Location = new System.Drawing.Point(17, 192);
            this.GioiHanSinhVien_lbl.Name = "GioiHanSinhVien_lbl";
            this.GioiHanSinhVien_lbl.Size = new System.Drawing.Size(151, 20);
            this.GioiHanSinhVien_lbl.TabIndex = 0;
            this.GioiHanSinhVien_lbl.Text = "Giới Hạn Sinh Viên";
            // 
            // ThoiGian_lbl
            // 
            this.ThoiGian_lbl.AutoSize = true;
            this.ThoiGian_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiGian_lbl.Location = new System.Drawing.Point(17, 139);
            this.ThoiGian_lbl.Name = "ThoiGian_lbl";
            this.ThoiGian_lbl.Size = new System.Drawing.Size(81, 20);
            this.ThoiGian_lbl.TabIndex = 0;
            this.ThoiGian_lbl.Text = "Thời Gian";
            // 
            // TenKhoaHoc_lbl
            // 
            this.TenKhoaHoc_lbl.AutoSize = true;
            this.TenKhoaHoc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhoaHoc_lbl.Location = new System.Drawing.Point(17, 88);
            this.TenKhoaHoc_lbl.Name = "TenKhoaHoc_lbl";
            this.TenKhoaHoc_lbl.Size = new System.Drawing.Size(116, 20);
            this.TenKhoaHoc_lbl.TabIndex = 0;
            this.TenKhoaHoc_lbl.Text = "Tên Khóa Học";
            // 
            // MaKhoaHoc_lbl
            // 
            this.MaKhoaHoc_lbl.AutoSize = true;
            this.MaKhoaHoc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhoaHoc_lbl.Location = new System.Drawing.Point(17, 33);
            this.MaKhoaHoc_lbl.Name = "MaKhoaHoc_lbl";
            this.MaKhoaHoc_lbl.Size = new System.Drawing.Size(111, 20);
            this.MaKhoaHoc_lbl.TabIndex = 0;
            this.MaKhoaHoc_lbl.Text = "Mã Khóa Học";
            // 
            // DanhSachKhoaHoc_dgv
            // 
            this.DanhSachKhoaHoc_dgv.AllowUserToAddRows = false;
            this.DanhSachKhoaHoc_dgv.AllowUserToDeleteRows = false;
            this.DanhSachKhoaHoc_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DanhSachKhoaHoc_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachKhoaHoc_dgv.Location = new System.Drawing.Point(3, 0);
            this.DanhSachKhoaHoc_dgv.Name = "DanhSachKhoaHoc_dgv";
            this.DanhSachKhoaHoc_dgv.RowHeadersWidth = 51;
            this.DanhSachKhoaHoc_dgv.RowTemplate.Height = 24;
            this.DanhSachKhoaHoc_dgv.Size = new System.Drawing.Size(681, 733);
            this.DanhSachKhoaHoc_dgv.TabIndex = 0;
            this.DanhSachKhoaHoc_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LamMoi_
            // 
            this.LamMoi_.Location = new System.Drawing.Point(91, 520);
            this.LamMoi_.Name = "LamMoi_";
            this.LamMoi_.Size = new System.Drawing.Size(128, 41);
            this.LamMoi_.TabIndex = 3;
            this.LamMoi_.Text = "Làm Mới";
            this.LamMoi_.UseVisualStyleBackColor = true;
            this.LamMoi_.Click += new System.EventHandler(this.LamMoi__Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(91, 480);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // QuanLyKhoaHoc_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1240, 736);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyKhoaHoc_frm";
            this.Text = "QuanLyKhoaHoc_frm";
            this.Load += new System.EventHandler(this.QuanLyKhoaHoc_frm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhoaHoc_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox GioiHanGiangVien_txt;
        private System.Windows.Forms.TextBox GioiHanSinhVien_txt;
        private System.Windows.Forms.TextBox ThoiGian_txt;
        private System.Windows.Forms.TextBox TenKhoaHoc_txt;
        private System.Windows.Forms.TextBox MaKhoaHoc_txt;
        private System.Windows.Forms.Label GioiHanGiangVien_lbl;
        private System.Windows.Forms.Label GioiHanSinhVien_lbl;
        private System.Windows.Forms.Label ThoiGian_lbl;
        private System.Windows.Forms.Label TenKhoaHoc_lbl;
        private System.Windows.Forms.Label MaKhoaHoc_lbl;
        private System.Windows.Forms.Button Xoa_but;
        private System.Windows.Forms.Button Sua_but;
        private System.Windows.Forms.Button Them_but;
        private System.Windows.Forms.DataGridView DanhSachKhoaHoc_dgv;
        private System.Windows.Forms.TextBox SoBuoiLyThuyet_txt;
        private System.Windows.Forms.TextBox SoBuoiThucHanh_txt;
        private System.Windows.Forms.TextBox KinhPhi_txt;
        private System.Windows.Forms.Label SoBuoiLyThuyet_lbl;
        private System.Windows.Forms.Label BuoiThucHanh_lbl;
        private System.Windows.Forms.Label KinhPhi_lbl;
        private System.Windows.Forms.Button LamMoi_;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}