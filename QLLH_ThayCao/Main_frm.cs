using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLH_ThayCao
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // code khi click quan ly khoa hoc
            QuanLyKhoaHoc_frm f = new QuanLyKhoaHoc_frm();
            f.TopLevel = false;
            Main_pnl.Controls.Add(f);
            f.Show();
            
            
        }

        private void Main_pnl_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if( f.Name == "QuanLyKhoaHoc_frm")
                {
                    f.Width = Main_pnl.Width;
                    f.Height = Main_pnl.Height;
                }
            }
        }
    }
}
