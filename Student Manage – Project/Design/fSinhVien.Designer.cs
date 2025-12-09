namespace Student_Manage___Project.GUI
{
    partial class fSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblDiemTK = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtDiemTK = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblHanhKiem = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboHanhKiem = new System.Windows.Forms.ComboBox();
            this.pnlNhapLieu = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtHocLuc = new System.Windows.Forms.TextBox();
            this.lblHocLuc = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.pnlNhapLieu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaSV,
            this.ColTenSV,
            this.ColLop,
            this.ColDiemTK,
            this.ColDiemThi,
            this.ColDiemTB,
            this.ColHocLuc,
            this.ColHanhKiem});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 312);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 30;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1467, 501);
            this.dgvSinhVien.TabIndex = 4;
            this.dgvSinhVien.TabStop = false;
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MaxInputLength = 255;
            this.ColSTT.MinimumWidth = 8;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            this.ColSTT.Width = 70;
            // 
            // ColMaSV
            // 
            this.ColMaSV.HeaderText = "MÃ SV";
            this.ColMaSV.MaxInputLength = 255;
            this.ColMaSV.MinimumWidth = 8;
            this.ColMaSV.Name = "ColMaSV";
            this.ColMaSV.ReadOnly = true;
            this.ColMaSV.Width = 130;
            // 
            // ColTenSV
            // 
            this.ColTenSV.HeaderText = "TÊN SV";
            this.ColTenSV.MaxInputLength = 255;
            this.ColTenSV.MinimumWidth = 8;
            this.ColTenSV.Name = "ColTenSV";
            this.ColTenSV.ReadOnly = true;
            this.ColTenSV.Width = 140;
            // 
            // ColLop
            // 
            this.ColLop.HeaderText = "LỚP";
            this.ColLop.MaxInputLength = 255;
            this.ColLop.MinimumWidth = 8;
            this.ColLop.Name = "ColLop";
            this.ColLop.ReadOnly = true;
            this.ColLop.Width = 120;
            // 
            // ColDiemTK
            // 
            this.ColDiemTK.HeaderText = "ĐIỂM THƯỜNG KÌ";
            this.ColDiemTK.MaxInputLength = 255;
            this.ColDiemTK.MinimumWidth = 8;
            this.ColDiemTK.Name = "ColDiemTK";
            this.ColDiemTK.ReadOnly = true;
            this.ColDiemTK.Width = 250;
            // 
            // ColDiemThi
            // 
            this.ColDiemThi.HeaderText = "ĐIỂM THI";
            this.ColDiemThi.MaxInputLength = 255;
            this.ColDiemThi.MinimumWidth = 8;
            this.ColDiemThi.Name = "ColDiemThi";
            this.ColDiemThi.ReadOnly = true;
            this.ColDiemThi.Width = 155;
            // 
            // ColDiemTB
            // 
            this.ColDiemTB.HeaderText = "ĐIỂM TRUNG BÌNH";
            this.ColDiemTB.MaxInputLength = 255;
            this.ColDiemTB.MinimumWidth = 8;
            this.ColDiemTB.Name = "ColDiemTB";
            this.ColDiemTB.ReadOnly = true;
            this.ColDiemTB.Width = 260;
            // 
            // ColHocLuc
            // 
            this.ColHocLuc.HeaderText = "HỌC LỰC";
            this.ColHocLuc.MaxInputLength = 255;
            this.ColHocLuc.MinimumWidth = 8;
            this.ColHocLuc.Name = "ColHocLuc";
            this.ColHocLuc.ReadOnly = true;
            this.ColHocLuc.Width = 155;
            // 
            // ColHanhKiem
            // 
            this.ColHanhKiem.HeaderText = "HẠNH KIỂM";
            this.ColHanhKiem.MaxInputLength = 255;
            this.ColHanhKiem.MinimumWidth = 8;
            this.ColHanhKiem.Name = "ColHanhKiem";
            this.ColHanhKiem.ReadOnly = true;
            this.ColHanhKiem.Width = 185;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(488, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 37);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(602, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 37);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1006, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 37);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(340, 88);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(142, 27);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(202, 88);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(57, 27);
            this.lblSTT.TabIndex = 2;
            this.lblSTT.Text = "STT:";
            // 
            // lblDiemTK
            // 
            this.lblDiemTK.AutoSize = true;
            this.lblDiemTK.Location = new System.Drawing.Point(202, 148);
            this.lblDiemTK.Name = "lblDiemTK";
            this.lblDiemTK.Size = new System.Drawing.Size(168, 27);
            this.lblDiemTK.TabIndex = 2;
            this.lblDiemTK.Text = "Điểm thường kì:";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(607, 148);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(106, 27);
            this.lblDiemTB.TabIndex = 2;
            this.lblDiemTB.Text = "Điểm TB:";
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(437, 148);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(101, 27);
            this.lblDiemThi.TabIndex = 2;
            this.lblDiemThi.Text = "Điểm thi:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(659, 88);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(147, 27);
            this.lblTenSV.TabIndex = 4;
            this.lblTenSV.Text = "Tên sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(488, 85);
            this.txtMaSV.MaxLength = 255;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(165, 35);
            this.txtMaSV.TabIndex = 8;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(265, 85);
            this.txtSTT.MaxLength = 255;
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(69, 35);
            this.txtSTT.TabIndex = 8;
            // 
            // txtDiemTK
            // 
            this.txtDiemTK.Location = new System.Drawing.Point(376, 145);
            this.txtDiemTK.MaxLength = 255;
            this.txtDiemTK.Name = "txtDiemTK";
            this.txtDiemTK.Size = new System.Drawing.Size(55, 35);
            this.txtDiemTK.TabIndex = 8;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(812, 84);
            this.txtTenSV.MaxLength = 255;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(241, 35);
            this.txtTenSV.TabIndex = 9;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(1059, 88);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(58, 27);
            this.lblLop.TabIndex = 17;
            this.lblLop.Text = "Lớp:";
            // 
            // lblHanhKiem
            // 
            this.lblHanhKiem.AutoSize = true;
            this.lblHanhKiem.Location = new System.Drawing.Point(1013, 148);
            this.lblHanhKiem.Name = "lblHanhKiem";
            this.lblHanhKiem.Size = new System.Drawing.Size(123, 27);
            this.lblHanhKiem.TabIndex = 17;
            this.lblHanhKiem.Text = "Hạnh kiểm:";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(1123, 85);
            this.txtLop.MaxLength = 255;
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(170, 35);
            this.txtLop.TabIndex = 18;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(716, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 37);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboHanhKiem
            // 
            this.cboHanhKiem.FormattingEnabled = true;
            this.cboHanhKiem.Location = new System.Drawing.Point(1142, 145);
            this.cboHanhKiem.Name = "cboHanhKiem";
            this.cboHanhKiem.Size = new System.Drawing.Size(151, 35);
            this.cboHanhKiem.TabIndex = 33;
            // 
            // pnlNhapLieu
            // 
            this.pnlNhapLieu.Controls.Add(this.txtTimKiem);
            this.pnlNhapLieu.Controls.Add(this.cboHanhKiem);
            this.pnlNhapLieu.Controls.Add(this.btnXoa);
            this.pnlNhapLieu.Controls.Add(this.txtLop);
            this.pnlNhapLieu.Controls.Add(this.lblHanhKiem);
            this.pnlNhapLieu.Controls.Add(this.lblLop);
            this.pnlNhapLieu.Controls.Add(this.txtTenSV);
            this.pnlNhapLieu.Controls.Add(this.txtDiemTB);
            this.pnlNhapLieu.Controls.Add(this.txtDiemThi);
            this.pnlNhapLieu.Controls.Add(this.txtDiemTK);
            this.pnlNhapLieu.Controls.Add(this.txtHocLuc);
            this.pnlNhapLieu.Controls.Add(this.txtSTT);
            this.pnlNhapLieu.Controls.Add(this.txtMaSV);
            this.pnlNhapLieu.Controls.Add(this.lblTenSV);
            this.pnlNhapLieu.Controls.Add(this.lblDiemThi);
            this.pnlNhapLieu.Controls.Add(this.lblHocLuc);
            this.pnlNhapLieu.Controls.Add(this.lblDiemTB);
            this.pnlNhapLieu.Controls.Add(this.lblDiemTK);
            this.pnlNhapLieu.Controls.Add(this.lblSTT);
            this.pnlNhapLieu.Controls.Add(this.lblMaSV);
            this.pnlNhapLieu.Controls.Add(this.btnThongKe);
            this.pnlNhapLieu.Controls.Add(this.btnLamMoi);
            this.pnlNhapLieu.Controls.Add(this.btnTimKiem);
            this.pnlNhapLieu.Controls.Add(this.btnSua);
            this.pnlNhapLieu.Controls.Add(this.btnSapXep);
            this.pnlNhapLieu.Controls.Add(this.btnMoFile);
            this.pnlNhapLieu.Controls.Add(this.btnLuuFile);
            this.pnlNhapLieu.Controls.Add(this.btnThem);
            this.pnlNhapLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhapLieu.Location = new System.Drawing.Point(0, 33);
            this.pnlNhapLieu.Name = "pnlNhapLieu";
            this.pnlNhapLieu.Size = new System.Drawing.Size(1467, 279);
            this.pnlNhapLieu.TabIndex = 3;
            this.pnlNhapLieu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNhapLieu_Paint);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1134, 25);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(274, 35);
            this.txtTimKiem.TabIndex = 34;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(719, 145);
            this.txtDiemTB.MaxLength = 255;
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(57, 35);
            this.txtDiemTB.TabIndex = 8;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(544, 145);
            this.txtDiemThi.MaxLength = 255;
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(57, 35);
            this.txtDiemThi.TabIndex = 8;
            // 
            // txtHocLuc
            // 
            this.txtHocLuc.Location = new System.Drawing.Point(882, 145);
            this.txtHocLuc.MaxLength = 255;
            this.txtHocLuc.Name = "txtHocLuc";
            this.txtHocLuc.Size = new System.Drawing.Size(125, 35);
            this.txtHocLuc.TabIndex = 8;
            // 
            // lblHocLuc
            // 
            this.lblHocLuc.AutoSize = true;
            this.lblHocLuc.Location = new System.Drawing.Point(782, 148);
            this.lblHocLuc.Name = "lblHocLuc";
            this.lblHocLuc.Size = new System.Drawing.Size(94, 27);
            this.lblHocLuc.TabIndex = 2;
            this.lblHocLuc.Text = "Học lực:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(349, 25);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 37);
            this.btnThongKe.TabIndex = 32;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(830, 207);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 37);
            this.btnLamMoi.TabIndex = 32;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(1076, 236);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(127, 41);
            this.btnSapXep.TabIndex = 32;
            this.btnSapXep.Text = "Sắp xếp ↑↓";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(199, 25);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(122, 37);
            this.btnMoFile.TabIndex = 32;
            this.btnMoFile.Text = "Mở file";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Location = new System.Drawing.Point(48, 25);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(122, 37);
            this.btnLuuFile.TabIndex = 32;
            this.btnLuuFile.Text = "Lưu file";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1467, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinToolStripMenuItem,
            this.quảnLýKhoaToolStripMenuItem,
            this.quảnLýNgànhToolStripMenuItem,
            this.quảnLýKhóaHọcToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.quảnLýToolStripMenuItem1});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản lý thông tin";
            this.quảnLýThôngTinToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThôngTinToolStripMenuItem_Click);
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa";
            this.quảnLýKhoaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoaToolStripMenuItem_Click);
            // 
            // quảnLýNgànhToolStripMenuItem
            // 
            this.quảnLýNgànhToolStripMenuItem.Name = "quảnLýNgànhToolStripMenuItem";
            this.quảnLýNgànhToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.quảnLýNgànhToolStripMenuItem.Text = "Quản lý ngành";
            this.quảnLýNgànhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgànhToolStripMenuItem_Click);
            // 
            // quảnLýKhóaHọcToolStripMenuItem
            // 
            this.quảnLýKhóaHọcToolStripMenuItem.Name = "quảnLýKhóaHọcToolStripMenuItem";
            this.quảnLýKhóaHọcToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.quảnLýKhóaHọcToolStripMenuItem.Text = "Quản lý khóa học";
            this.quảnLýKhóaHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhóaHọcToolStripMenuItem_Click);
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            this.quảnLýLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(253, 34);
            this.quảnLýToolStripMenuItem1.Text = "Quản lý môn học";
            this.quảnLýToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýToolStripMenuItem1_Click);
            // 
            // fSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 813);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fSinhVien";
            this.Text = "Quản Lý Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblDiemTK;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtDiemTK;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblHanhKiem;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboHanhKiem;
        private System.Windows.Forms.Panel pnlNhapLieu;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnMoFile;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtHocLuc;
        private System.Windows.Forms.Label lblHocLuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHanhKiem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
    }
}