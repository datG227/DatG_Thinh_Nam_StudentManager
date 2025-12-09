using DocumentFormat.OpenXml.Wordprocessing;
using Student_Manage___Project.GUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Manage___Project.Design
{
    public partial class fQuanLyLop : Form
    {
        public fQuanLyLop()
        {
            InitializeComponent();
            AddMenuEvents();
        }

     
        private void AddMenuEvents()
        {
            
            quảnLýThôngTinToolStripMenuItem.Click += QuảnLyThongTin_Click;
            quảnLýKhoaToolStripMenuItem.Click += QuanLyKhoa_Click;
            quảnLýNgànhToolStripMenuItem.Click += QuanLyNganh_Click;
            quảnLýKhóaHọcToolStripMenuItem.Click += QuanLyKhoaHoc_Click;
            quảnLíMônHọcToolStripMenuItem.Click += QuanLyMonHoc_Click;
            quảnLýĐiểmToolStripMenuItem.Click += QuanLyDiem_Click;
        }

      

        private void ĐăngXuất_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Hide();
                new fDangNhap().Show();
            }
        }

        private void QuảnLyThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fSinhVien().Show();
        }

        private void QuanLyKhoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fQuanLyKhoa().Show();
        }

        private void QuanLyNganh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fQuanLyNganh().Show();
        }

        private void QuanLyKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fQuanLyKhoaHoc().Show();
        }

        private void QuanLyMonHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fQuanLyMonHoc().Show();
        }

        private void QuanLyDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new fSinhVien().Show();
        }

    
        private void pnlQuanLyLop_Paint(object sender, PaintEventArgs e)
        {
            
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm lớp thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa lớp thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa lớp thành công!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            numericUDsLuong.Value = 0;
            cboKhoa.SelectedIndex = -1;
            cboNganh.SelectedIndex = -1;
            cboKhoaHoc.SelectedIndex = -1;
        }
    }
}
