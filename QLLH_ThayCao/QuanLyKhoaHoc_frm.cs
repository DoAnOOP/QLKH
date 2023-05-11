using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLH_ThayCao
{
    public partial class QuanLyKhoaHoc_frm : Form
    {
        
        DataClasses1DataContext dc1 = new DataClasses1DataContext();
        public QuanLyKhoaHoc_frm()
        {
            InitializeComponent();
        }
        private void loaddata_4_DSKH()
        {
            var dskh = dc1.tbl_KhoaHocs.ToList();
            DanhSachKhoaHoc_dgv.DataSource = dskh;
        }
        private void QuanLyKhoaHoc_frm_Load(object sender, EventArgs e)
        {
            // DataClasses1DataContext dc1 = new DataClasses1DataContext();
            var dskh = dc1.tbl_KhoaHocs;
            DanhSachKhoaHoc_dgv.DataSource = dskh;
        }     
        private void Them_but_Click(object sender, EventArgs e)
        {
            try { 

            // Xu ly Su Kien click nut Them
            // lấy dữ liệu từ các textbox
            /* string MaKhoaHoc = MaKhoaHoc_txt.Text;*/
            tbl_KhoaHoc newObj = new tbl_KhoaHoc();
            newObj.MaKhoaHoc = MaKhoaHoc_txt.Text;
            newObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
            newObj.ThoiGian = ThoiGian_txt.Text;
            newObj.GioiHanSinhVien = int.Parse(GioiHanGiangVien_txt.Text);
            newObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_txt.Text);
            newObj.KinhPhiDongGop = Convert.ToInt32(KinhPhi_txt.Text);
            newObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_txt.Text);
            newObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_txt.Text);
            dc1.tbl_KhoaHocs.InsertOnSubmit(newObj);
            dc1.SubmitChanges();              
            MessageBox.Show("Them Khoa Hoc Thanh Cong!");
                /*        newObj = new tbl_KhoaHoc();
                        BindingSource source = new BindingSource();
                        source.DataSource = newObj;
                        DanhSachKhoaHoc_dgv.DataSource = source;
                         Cập nhật dữ liệu  
                        source.ResetBindings(false);*/
            loaddata_4_DSKH();            
            }
            catch (Exception ex)
                {
                MessageBox.Show("Them Khoa Hoc Khong Thanh Cong");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            DataGridViewRow row = new DataGridViewRow();
            row = DanhSachKhoaHoc_dgv.Rows[e.RowIndex];
            MaKhoaHoc_txt.Text = row.Cells["MaKhoaHoc"].Value.ToString();
            MaKhoaHoc_txt.ReadOnly = true;
            TenKhoaHoc_txt.Text = row.Cells["TenKhoaHoc"].Value.ToString();
            ThoiGian_txt.Text = Convert.ToString(row.Cells["ThoiGian"].Value);
            GioiHanSinhVien_txt.Text =Convert.ToString(row.Cells["GioiHanSinhVien"].Value);
            GioiHanGiangVien_txt.Text = Convert.ToString(row.Cells["GioiHanGiangVien"].Value); ;
            // nếu kinh phí = NULL => lỗi.
            KinhPhi_txt.Text = Convert.ToString(row.Cells["KinhPhiDongGop"].Value);
            SoBuoiLyThuyet_txt.Text = Convert.ToString(row.Cells["SoBuoiLyThuyet"].Value);
            SoBuoiThucHanh_txt.Text = Convert.ToString(row.Cells["SoBuoiThucHanh"].Value);
            }
            catch(Exception ex) 
            { if (KinhPhi_txt.Text == null)
                    KinhPhi_txt.Text = "0";
                throw ex;
            }
        }

        private void Sua_but_Click(object sender, EventArgs e)
        {

            //code luu tru thong tin khoa hoc theo du lieu da chinh sua
            var mkh = MaKhoaHoc_txt.Text;
            var editObj = dc1.tbl_KhoaHocs.Where(o => o.MaKhoaHoc.Equals(mkh)).FirstOrDefault();
            editObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
            editObj.TenKhoaHoc = TenKhoaHoc_txt.Text;
            editObj.ThoiGian = ThoiGian_txt.Text;
            editObj.GioiHanSinhVien = int.Parse(GioiHanGiangVien_txt.Text);
            editObj.GioiHanGiangVien = Convert.ToInt32(GioiHanGiangVien_txt.Text);
            editObj.KinhPhiDongGop = Convert.ToInt32(KinhPhi_txt.Text);
            editObj.SoBuoiLyThuyet = Convert.ToInt32(SoBuoiLyThuyet_txt.Text);
            editObj.SoBuoiThucHanh = Convert.ToInt32(SoBuoiThucHanh_txt.Text);
            dc1.SubmitChanges();
            MaKhoaHoc_txt.ReadOnly = false;
            MessageBox.Show("Đã Sửa Thành Công!");
            loaddata_4_DSKH();

        }

        private void LamMoi__Click(object sender, EventArgs e)
        {
            MaKhoaHoc_txt.Text = "";
            TenKhoaHoc_txt.Text = "";
            ThoiGian_txt.Text = "";
            GioiHanSinhVien_txt.Text = "";
            GioiHanGiangVien_txt.Text = "";
            KinhPhi_txt.Text = "";
            SoBuoiLyThuyet_txt.Text = "";
            SoBuoiThucHanh_txt.Text = "";
        }
    }
    
}
