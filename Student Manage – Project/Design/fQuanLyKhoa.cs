using Student_Manage___Project.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student_Manage___Project.Design
{
    public partial class fQuanLyKhoa : Form
    {
        class Khoa
        {
            public int ID { get; set; }
            public string MaKhoa { get; set; }
            public string TenKhoa { get; set; }
        }

        private readonly List<Khoa> dsKhoa = new List<Khoa>();

        public fQuanLyKhoa()
        {
            InitializeComponent();

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvQuanLyKhoa.CellClick += dgvQuanLyKhoa_CellClick;

            
            quảnThôngTinToolStripMenuItem.Click += (s, e) =>
            {
                new fQuanLyThongTin().Show();
                this.Hide();
            };

            quảnLýNgànhToolStripMenuItem.Click += (s, e) =>
            {
                new fQuanLyNganh().Show();
                this.Hide();
            };

            quảnLýKhóaHọcToolStripMenuItem.Click += (s, e) =>
            {
                new fQuanLyKhoaHoc().Show();
                this.Hide();
            };

      
            quảnLýKhoaToolStripMenuItem.Click += (s, e) =>
            {
                new fQuanLyLop().Show();
                this.Hide();
            };

            quảnLýMônHọcToolStripMenuItem.Click += (s, e) =>
            {
                new fQuanLyMonHoc().Show();
                this.Hide();
            };

            quảnLýĐiểmToolStripMenuItem.Click += (s, e) =>
            {
                new fSinhVien().Show();
                this.Hide();
            };
        }
            

        
        private void RefreshGrid()
        {
            dgvQuanLyKhoa.Rows.Clear();
            foreach (var k in dsKhoa)
            {
                dgvQuanLyKhoa.Rows.Add(k.ID, k.MaKhoa, k.TenKhoa);
            }
            dgvQuanLyKhoa.ClearSelection();
        }

        
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi");
                return;
            }

            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("ID phải là số!", "Lỗi");
                return;
            }

            if (dsKhoa.Any(k => k.ID == id))
            {
                MessageBox.Show("ID đã tồn tại!", "Lỗi");
                return;
            }

            dsKhoa.Add(new Khoa()
            {
                ID = id,
                MaKhoa = txtMaKhoa.Text.Trim(),
                TenKhoa = txtTenKhoa.Text.Trim()
            });

            RefreshGrid();
        }


        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng!", "Thông báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Không được bỏ trống!", "Lỗi");
                return;
            }

            int id = Convert.ToInt32(txtID.Text);
            Khoa k = dsKhoa.FirstOrDefault(x => x.ID == id);

            if (k != null)
            {
                k.MaKhoa = txtMaKhoa.Text.Trim();
                k.TenKhoa = txtTenKhoa.Text.Trim();
            }

            RefreshGrid();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng!", "Thông báo");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa khoa này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No) return;

            int id = Convert.ToInt32(txtID.Text);
            dsKhoa.RemoveAll(k => k.ID == id);

            RefreshGrid();
            BtnLamMoi_Click(null, null);
        }

       
        private void dgvQuanLyKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtID.Text = dgvQuanLyKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaKhoa.Text = dgvQuanLyKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTenKhoa.Text = dgvQuanLyKhoa.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

       
        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            dgvQuanLyKhoa.ClearSelection();
        }

        private void pnlQuanLyKhoa_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void fQuanLyKhoa_Load(object sender, EventArgs e) { }
        private void quảnLýĐiểmThiSinhViênToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýNgànhToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void btnThem_Click(object sender, EventArgs e) { }
        private void btnSua_Click(object sender, EventArgs e) { }
        private void btnXoa_Click(object sender, EventArgs e) { }
        private void btnTimKiem_Click(object sender, EventArgs e) { }
        private void btnSapXep_Click(object sender, EventArgs e) { }
        private void btnLuuFile_Click(object sender, EventArgs e) { }
        private void btnMoFile_Click(object sender, EventArgs e) { }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void pnlNhapLieu_Paint(object sender, PaintEventArgs e) { }
        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e) { }
    }
}
