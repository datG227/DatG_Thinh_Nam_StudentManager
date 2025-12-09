using Student_Manage___Project.GUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Manage___Project.Design
{
    public partial class fQuanLyMonHoc : Form
    {
        class MonHoc
        {
            public int ID { get; set; }
            public string MaLop { get; set; }
            public string TenMon { get; set; }
            public string Khoa { get; set; }
            public int SoTinChi { get; set; }
            public int LyThuyet { get; set; }
            public int ThucHanh { get; set; }
        }

        List<MonHoc> danhSach = new List<MonHoc>();

        public fQuanLyMonHoc()
        {
            InitializeComponent();

         
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            dgvQuanLyMonHoc.CellClick += dgvQuanLyMonHoc_CellClick;

         

            quảnLýThôngTinToolStripMenuItem.Click += quảnLýThôngTinToolStripMenuItem_Click;
            quảnLýKhoaToolStripMenuItem.Click += quảnLýKhoaToolStripMenuItem_Click;
            quảnLýNgànhToolStripMenuItem.Click += quảnLýNgànhToolStripMenuItem_Click;
            quảnLýLớpToolStripMenuItem.Click += quảnLýLớpToolStripMenuItem_Click;
            quảnLýKhóaHọcToolStripMenuItem.Click += quảnLýKhóaHọcToolStripMenuItem_Click;
            quảnLýĐiểmToolStripMenuItem.Click += quảnLýĐiểmToolStripMenuItem_Click;

            LoadKhoa();
            LoadDataGridView();

            dgvQuanLyMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadKhoa()
        {
            cboKhoa.Items.Clear();
            cboKhoa.Items.Add("CNTT");
            cboKhoa.Items.Add("Kinh Tế");
            cboKhoa.Items.Add("Ngôn Ngữ");
            cboKhoa.Items.Add("Cơ Khí");
            cboKhoa.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            dgvQuanLyMonHoc.Rows.Clear();
            foreach (var mh in danhSach)
            {
                dgvQuanLyMonHoc.Rows.Add(mh.ID, mh.MaLop, mh.TenMon, mh.Khoa, mh.SoTinChi, mh.LyThuyet, mh.ThucHanh);
            }
        }

        private void ClearAll()
        {
            txtID.Clear();
            txtMaLop.Clear();
            txtTenMon.Clear();
            numericUDTinChi.Value = 0;
            numericUDLyThuyet.Value = 0;
            numericUDThucHanh.Value = 0;
            cboKhoa.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("ID phải là số!", "Lỗi");
                return;
            }

            if (danhSach.Exists(x => x.ID == id))
            {
                MessageBox.Show("ID đã tồn tại!", "Lỗi");
                return;
            }

            MonHoc mh = new MonHoc
            {
                ID = id,
                MaLop = txtMaLop.Text,
                TenMon = txtTenMon.Text,
                Khoa = cboKhoa.Text,
                SoTinChi = (int)numericUDTinChi.Value,
                LyThuyet = (int)numericUDLyThuyet.Value,
                ThucHanh = (int)numericUDThucHanh.Value
            };

            danhSach.Add(mh);
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("ID phải là số!", "Lỗi");
                return;
            }

            MonHoc mh = danhSach.Find(x => x.ID == id);
            if (mh == null)
            {
                MessageBox.Show("Không tìm thấy môn học!", "Lỗi");
                return;
            }

            mh.MaLop = txtMaLop.Text;
            mh.TenMon = txtTenMon.Text;
            mh.Khoa = cboKhoa.Text;
            mh.SoTinChi = (int)numericUDTinChi.Value;
            mh.LyThuyet = (int)numericUDLyThuyet.Value;
            mh.ThucHanh = (int)numericUDThucHanh.Value;

            LoadDataGridView();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
  
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo)
                == DialogResult.No) return;

            MonHoc mh = danhSach.Find(x => x.ID == id);
            if (mh != null)
            {
                danhSach.Remove(mh);
                LoadDataGridView();
                ClearAll();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dgvQuanLyMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvQuanLyMonHoc.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value.ToString();
            txtMaLop.Text = row.Cells[1].Value.ToString();
            txtTenMon.Text = row.Cells[2].Value.ToString();
            cboKhoa.Text = row.Cells[3].Value.ToString();
            numericUDTinChi.Value = Convert.ToInt32(row.Cells[4].Value);
            numericUDLyThuyet.Value = Convert.ToInt32(row.Cells[5].Value);
            numericUDThucHanh.Value = Convert.ToInt32(row.Cells[6].Value);
        }

      
        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fQuanLyThongTin().Show();
            this.Hide();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fQuanLyKhoa().Show();
            this.Hide();
        }

        private void quảnLýNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fQuanLyNganh().Show();
            this.Hide();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fQuanLyLop().Show();
            this.Hide();
        }

        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fQuanLyKhoaHoc().Show();
            this.Hide();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fSinhVien().Show();
            this.Hide();
        }

     
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
            this.Close();
        }

        private void pnlQuanLyMonHoc_Paint(object sender, PaintEventArgs e)
        {
          
        }

        
    }
}
