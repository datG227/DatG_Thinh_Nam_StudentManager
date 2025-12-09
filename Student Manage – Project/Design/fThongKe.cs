using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Manage___Project
{
    public partial class fThongKe : Form
    {
        private List<Student> ds;

        // Constructor có danh sách
        public fThongKe(List<Student> danhSach)
        {
            InitializeComponent();
            ds = danhSach;

            LoadCombobox();
            CapNhatToanBo(ds);
        }

        // ------------------------
        // LOAD COMBOBOX
        // ------------------------
        private void LoadCombobox()
        {
            cboLop.Items.Clear();
            cboLop.Items.Add("Tất cả");

            var listLop = ds.Select(s => s.Lop).Distinct().ToList();
            foreach (var lop in listLop)
                cboLop.Items.Add(lop);

            cboLop.SelectedIndex = 0;

            lblHocLuc.Items.Clear();
            lblHocLuc.Items.Add("Tất cả");
            lblHocLuc.Items.Add("Xuất sắc");
            lblHocLuc.Items.Add("Giỏi");
            lblHocLuc.Items.Add("Khá");
            lblHocLuc.Items.Add("Trung bình");
            lblHocLuc.Items.Add("Yếu");
            lblHocLuc.Items.Add("Kém");

            lblHocLuc.SelectedIndex = 0;
        }

        // ------------------------
        // CẬP NHẬT SỐ LIỆU
        // ------------------------
        private void CapNhatSoLieu(List<Student> list)
        {
            lblTongSV_0.Text = list.Count.ToString();

            lblTongSvDat_0.Text = list.Count(s =>
             s.HocLuc == "Xuất sắc" ||
                 s.HocLuc == "Giỏi" ||
                    s.HocLuc == "Khá" ||
                        s.HocLuc == "Trung bình"
                            ).ToString();

            lblTongSvKoDat_0.Text = list.Count(s =>
                s.HocLuc == "Yếu" ||
                s.HocLuc == "Kém"
            ).ToString();

        }

        // ------------------------
        // VẼ BIỂU ĐỒ
        // ------------------------
        private void VeBieuDo(List<Student> list)
        {
            chart1.Series.Clear();
            Series sr = new Series("Học lực");
            sr.ChartType = SeriesChartType.Column;
            sr.IsValueShownAsLabel = true;
            chart1.Series.Add(sr);

            string[] hocLucArr = { "Xuất sắc", "Giỏi", "Khá", "Trung bình", "Yếu", "Kém" };

            foreach (var hl in hocLucArr)
                sr.Points.AddXY(hl, list.Count(s => s.HocLuc == hl));
        }

        // ------------------------
        // LỌC DỮ LIỆU
        // ------------------------
        private List<Student> Loc()
        {
            var list = ds;

            if (cboLop.SelectedIndex > 0)
            {
                string lop = cboLop.SelectedItem.ToString();
                list = list.Where(s => s.Lop == lop).ToList();
            }

            if (lblHocLuc.SelectedIndex > 0)
            {
                string hl = lblHocLuc.SelectedItem.ToString();
                list = list.Where(s => s.HocLuc == hl).ToList();
            }

            return list;
        }

        // ------------------------
        // CẬP NHẬT TẤT CẢ
        // ------------------------
        private void CapNhatToanBo(List<Student> list)
        {
            CapNhatSoLieu(list);
            VeBieuDo(list);
        }

        // ------------------------
        // NÚT CẬP NHẬT
        // ------------------------
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var list = Loc();
            CapNhatToanBo(list);
        }

        // ------------------------
        // NÚT ĐÓNG
        // ------------------------
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------
        // XUẤT EXCEL
        // ------------------------
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel Workbook (*.xlsx)|*.xlsx";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.AddWorksheet("ThongKe");

                    ws.Cell(1, 1).Value = "THỐNG KÊ SINH VIÊN";

                    ws.Cell(3, 1).Value = "Tổng sinh viên";
                    ws.Cell(3, 2).Value = lblTongSV_0.Text;

                    ws.Cell(4, 1).Value = "Giỏi";
                    ws.Cell(4, 2).Value = label11.Text;

                    ws.Cell(5, 1).Value = "Khá";
                    ws.Cell(5, 2).Value = lblKha_0.Text;

                    ws.Cell(6, 1).Value = "Trung bình";
                    ws.Cell(6, 2).Value = lblTrungBinh_0.Text;

                    ws.Cell(7, 1).Value = "Yếu";
                    ws.Cell(7, 2).Value = lblYeu_0.Text;

                    ws.Cell(8, 1).Value = "Kém";
                    ws.Cell(8, 2).Value = lblKem_0.Text;

                    wb.SaveAs(sf.FileName);
                }

                MessageBox.Show("Xuất Excel thành công!");
            }
        }

        private void fThongKe_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void lblLocHocLuc_Click(object sender, EventArgs e)
        {

        }

        private void lblLocLop_Click(object sender, EventArgs e)
        {

        }

        private void lblTongSV_Click(object sender, EventArgs e)
        {

        }

        private void lblTongSvDat_Click(object sender, EventArgs e)
        {

        }

        private void lblTongSvKoDat_Click(object sender, EventArgs e)
        {

        }

        private void lblGioi_Click(object sender, EventArgs e)
        {

        }

        private void lblKha_Click(object sender, EventArgs e)
        {

        }

        private void lblTrungBinh_Click(object sender, EventArgs e)
        {

        }

        private void lblKem_Click(object sender, EventArgs e)
        {

        }

        private void lblYeu_Click(object sender, EventArgs e)
        {

        }
    }
}
