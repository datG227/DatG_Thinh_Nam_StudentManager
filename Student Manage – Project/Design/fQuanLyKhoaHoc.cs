using DocumentFormat.OpenXml.Wordprocessing;
using Student_Manage___Project.Design;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Manage___Project.GUI
{
    public partial class fQuanLyKhoaHoc : Form
    {
        class KhoaHoc
        {
            public int ID { get; set; }
            public string MaKhoa { get; set; }
            public int NamNhapHoc { get; set; }
        }

        private readonly List<KhoaHoc> dsKhoaHoc = new List<KhoaHoc>();

        private void RefreshGrid()
        {
            dgvQuanLyKhoaHoc.Rows.Clear();

            foreach (var kh in dsKhoaHoc)
            {
                dgvQuanLyKhoaHoc.Rows.Add(kh.ID, kh.MaKhoa, kh.NamNhapHoc);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtNamNhapHoc.Text))
            {
                MessageBox.Show("Không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("ID phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            if (dsKhoaHoc.Any(x => x.ID == id))
            {
                MessageBox.Show("ID đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if (!int.TryParse(txtNamNhapHoc.Text, out int namNhap))
            {
                MessageBox.Show("Năm nhập học phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dsKhoaHoc.Add(new KhoaHoc
            {
                ID = id,
                MaKhoa = txtMaKhoa.Text.Trim(),
                NamNhapHoc = namNhap
            });

            RefreshGrid();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyKhoaHoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("ID phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var kh = dsKhoaHoc.FirstOrDefault(x => x.ID == id);

            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNamNhapHoc.Text, out int namNhap))
            {
                MessageBox.Show("Năm nhập học phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            kh.MaKhoa = txtMaKhoa.Text.Trim();
            kh.NamNhapHoc = namNhap;

            RefreshGrid();
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyKhoaHoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

     
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa dòng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
                return;

        
            int id = Convert.ToInt32(txtID.Text);
            dsKhoaHoc.RemoveAll(x => x.ID == id);

            RefreshGrid();
            BtnLamMoi_Click(null, null);

            MessageBox.Show("Đã xóa thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaKhoa.Clear();
            txtNamNhapHoc.Clear();

            dgvQuanLyKhoaHoc.ClearSelection();
        }
        
        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyThongTin f = new fQuanLyThongTin();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }

      
        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoaHoc f = new fQuanLyKhoaHoc();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }

      
        private void quảnLýNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyNganh f = new fQuanLyNganh();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }

    
        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }

       
        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }

        
        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSinhVien f = new fSinhVien();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
            this.Hide();
        }

public fQuanLyKhoaHoc()
{
    InitializeComponent();

   
    quảnLýThôngTinToolStripMenuItem.Click += quảnLýThôngTinToolStripMenuItem_Click;
    quảnLýKhóaHọcToolStripMenuItem.Click += quảnLýKhóaHọcToolStripMenuItem_Click;
    quảnLýNgànhToolStripMenuItem.Click += quảnLýNgànhToolStripMenuItem_Click;
    quảnLýMônHọcToolStripMenuItem.Click += quảnLýMônHọcToolStripMenuItem_Click;
    quảnLýKhoaToolStripMenuItem.Click += quảnLýKhoaToolStripMenuItem_Click;
    quảnLýĐiểmToolStripMenuItem.Click += quảnLýĐiểmToolStripMenuItem_Click;
   

           
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;

            dgvQuanLyKhoaHoc.CellClick += dgvQuanLyKhoaHoc_CellClick;
            dgvQuanLyKhoaHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuanLyKhoaHoc.MultiSelect = false;
        }

        private void dgvQuanLyKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvQuanLyKhoaHoc.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value.ToString();
            txtMaKhoa.Text = row.Cells[1].Value.ToString();
            txtNamNhapHoc.Text = row.Cells[2].Value.ToString();

         
        }

        private void pnlQuanLyKhoaHoc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
