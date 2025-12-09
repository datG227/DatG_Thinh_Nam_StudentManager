namespace Student_Manage___Project
{
    partial class fThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTongSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblGioi = new System.Windows.Forms.Label();
            this.lblKha = new System.Windows.Forms.Label();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblYeu = new System.Windows.Forms.Label();
            this.lblKem = new System.Windows.Forms.Label();
            this.lblLocLop = new System.Windows.Forms.Label();
            this.lblLocHocLuc = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblHocLuc = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTongSvDat = new System.Windows.Forms.Label();
            this.lblTongSvKoDat = new System.Windows.Forms.Label();
            this.lblTongSvKoDat_0 = new System.Windows.Forms.Label();
            this.lblTongSV_0 = new System.Windows.Forms.Label();
            this.lblTongSvDat_0 = new System.Windows.Forms.Label();
            this.lblYeu_0 = new System.Windows.Forms.Label();
            this.lblKem_0 = new System.Windows.Forms.Label();
            this.lblTrungBinh_0 = new System.Windows.Forms.Label();
            this.lblKha_0 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongSV
            // 
            this.lblTongSV.AutoSize = true;
            this.lblTongSV.Location = new System.Drawing.Point(50, 90);
            this.lblTongSV.Name = "lblTongSV";
            this.lblTongSV.Size = new System.Drawing.Size(159, 27);
            this.lblTongSV.TabIndex = 1;
            this.lblTongSV.Text = "Tổng sinh viên:";
            this.lblTongSV.Click += new System.EventHandler(this.lblTongSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(386, 199);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(117, 46);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblGioi
            // 
            this.lblGioi.AutoSize = true;
            this.lblGioi.Location = new System.Drawing.Point(221, 144);
            this.lblGioi.Name = "lblGioi";
            this.lblGioi.Size = new System.Drawing.Size(65, 27);
            this.lblGioi.TabIndex = 1;
            this.lblGioi.Text = "Giỏi: ";
            this.lblGioi.Click += new System.EventHandler(this.lblGioi_Click);
            // 
            // lblKha
            // 
            this.lblKha.AutoSize = true;
            this.lblKha.Location = new System.Drawing.Point(351, 144);
            this.lblKha.Name = "lblKha";
            this.lblKha.Size = new System.Drawing.Size(58, 27);
            this.lblKha.TabIndex = 1;
            this.lblKha.Text = "Khá:";
            this.lblKha.Click += new System.EventHandler(this.lblKha_Click);
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Location = new System.Drawing.Point(474, 144);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(122, 27);
            this.lblTrungBinh.TabIndex = 1;
            this.lblTrungBinh.Text = "Trung bình:";
            this.lblTrungBinh.Click += new System.EventHandler(this.lblTrungBinh_Click);
            // 
            // lblYeu
            // 
            this.lblYeu.AutoSize = true;
            this.lblYeu.Location = new System.Drawing.Point(789, 144);
            this.lblYeu.Name = "lblYeu";
            this.lblYeu.Size = new System.Drawing.Size(58, 27);
            this.lblYeu.TabIndex = 1;
            this.lblYeu.Text = "Yếu:";
            this.lblYeu.Click += new System.EventHandler(this.lblYeu_Click);
            // 
            // lblKem
            // 
            this.lblKem.AutoSize = true;
            this.lblKem.Location = new System.Drawing.Point(663, 144);
            this.lblKem.Name = "lblKem";
            this.lblKem.Size = new System.Drawing.Size(64, 27);
            this.lblKem.TabIndex = 1;
            this.lblKem.Text = "Kém:";
            this.lblKem.Click += new System.EventHandler(this.lblKem_Click);
            // 
            // lblLocLop
            // 
            this.lblLocLop.AutoSize = true;
            this.lblLocLop.Location = new System.Drawing.Point(53, 36);
            this.lblLocLop.Name = "lblLocLop";
            this.lblLocLop.Size = new System.Drawing.Size(141, 27);
            this.lblLocLop.TabIndex = 1;
            this.lblLocLop.Text = "Lọc theo lớp:";
            this.lblLocLop.Click += new System.EventHandler(this.lblLocLop_Click);
            // 
            // lblLocHocLuc
            // 
            this.lblLocHocLuc.AutoSize = true;
            this.lblLocHocLuc.Location = new System.Drawing.Point(364, 36);
            this.lblLocHocLuc.Name = "lblLocHocLuc";
            this.lblLocHocLuc.Size = new System.Drawing.Size(181, 27);
            this.lblLocHocLuc.TabIndex = 1;
            this.lblLocHocLuc.Text = "Lọc theo học lực:";
            this.lblLocHocLuc.Click += new System.EventHandler(this.lblLocHocLuc_Click);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(200, 33);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(158, 35);
            this.cboLop.TabIndex = 6;
            // 
            // lblHocLuc
            // 
            this.lblHocLuc.FormattingEnabled = true;
            this.lblHocLuc.Location = new System.Drawing.Point(551, 33);
            this.lblHocLuc.Name = "lblHocLuc";
            this.lblHocLuc.Size = new System.Drawing.Size(151, 35);
            this.lblHocLuc.TabIndex = 7;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(263, 199);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 46);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(509, 199);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(128, 46);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 264);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(911, 424);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // lblTongSvDat
            // 
            this.lblTongSvDat.AutoSize = true;
            this.lblTongSvDat.Location = new System.Drawing.Point(304, 90);
            this.lblTongSvDat.Name = "lblTongSvDat";
            this.lblTongSvDat.Size = new System.Drawing.Size(195, 27);
            this.lblTongSvDat.TabIndex = 1;
            this.lblTongSvDat.Text = "Tổng sinh viên đạt:";
            this.lblTongSvDat.Click += new System.EventHandler(this.lblTongSvDat_Click);
            // 
            // lblTongSvKoDat
            // 
            this.lblTongSvKoDat.AutoSize = true;
            this.lblTongSvKoDat.Location = new System.Drawing.Point(587, 90);
            this.lblTongSvKoDat.Name = "lblTongSvKoDat";
            this.lblTongSvKoDat.Size = new System.Drawing.Size(260, 27);
            this.lblTongSvKoDat.TabIndex = 1;
            this.lblTongSvKoDat.Text = "Tổng sinh viên không đạt:";
            this.lblTongSvKoDat.Click += new System.EventHandler(this.lblTongSvKoDat_Click);
            // 
            // lblTongSvKoDat_0
            // 
            this.lblTongSvKoDat_0.AutoSize = true;
            this.lblTongSvKoDat_0.Location = new System.Drawing.Point(846, 90);
            this.lblTongSvKoDat_0.Name = "lblTongSvKoDat_0";
            this.lblTongSvKoDat_0.Size = new System.Drawing.Size(24, 27);
            this.lblTongSvKoDat_0.TabIndex = 9;
            this.lblTongSvKoDat_0.Text = "0";
            this.lblTongSvKoDat_0.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTongSV_0
            // 
            this.lblTongSV_0.AutoSize = true;
            this.lblTongSV_0.Location = new System.Drawing.Point(207, 90);
            this.lblTongSV_0.Name = "lblTongSV_0";
            this.lblTongSV_0.Size = new System.Drawing.Size(24, 27);
            this.lblTongSV_0.TabIndex = 9;
            this.lblTongSV_0.Text = "0";
            // 
            // lblTongSvDat_0
            // 
            this.lblTongSvDat_0.AutoSize = true;
            this.lblTongSvDat_0.Location = new System.Drawing.Point(497, 90);
            this.lblTongSvDat_0.Name = "lblTongSvDat_0";
            this.lblTongSvDat_0.Size = new System.Drawing.Size(24, 27);
            this.lblTongSvDat_0.TabIndex = 9;
            this.lblTongSvDat_0.Text = "0";
            this.lblTongSvDat_0.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblYeu_0
            // 
            this.lblYeu_0.AutoSize = true;
            this.lblYeu_0.Location = new System.Drawing.Point(846, 144);
            this.lblYeu_0.Name = "lblYeu_0";
            this.lblYeu_0.Size = new System.Drawing.Size(24, 27);
            this.lblYeu_0.TabIndex = 9;
            this.lblYeu_0.Text = "0";
            this.lblYeu_0.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKem_0
            // 
            this.lblKem_0.AutoSize = true;
            this.lblKem_0.Location = new System.Drawing.Point(726, 144);
            this.lblKem_0.Name = "lblKem_0";
            this.lblKem_0.Size = new System.Drawing.Size(24, 27);
            this.lblKem_0.TabIndex = 9;
            this.lblKem_0.Text = "0";
            this.lblKem_0.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTrungBinh_0
            // 
            this.lblTrungBinh_0.AutoSize = true;
            this.lblTrungBinh_0.Location = new System.Drawing.Point(594, 144);
            this.lblTrungBinh_0.Name = "lblTrungBinh_0";
            this.lblTrungBinh_0.Size = new System.Drawing.Size(24, 27);
            this.lblTrungBinh_0.TabIndex = 9;
            this.lblTrungBinh_0.Text = "0";
            this.lblTrungBinh_0.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKha_0
            // 
            this.lblKha_0.AutoSize = true;
            this.lblKha_0.Location = new System.Drawing.Point(407, 144);
            this.lblKha_0.Name = "lblKha_0";
            this.lblKha_0.Size = new System.Drawing.Size(24, 27);
            this.lblKha_0.TabIndex = 9;
            this.lblKha_0.Text = "0";
            this.lblKha_0.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 27);
            this.label11.TabIndex = 9;
            this.label11.Text = "0";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xuất sắc: ";
            this.label1.Click += new System.EventHandler(this.lblGioi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 1;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 690);
            this.Controls.Add(this.lblTongSV_0);
            this.Controls.Add(this.lblTongSvDat_0);
            this.Controls.Add(this.lblYeu_0);
            this.Controls.Add(this.lblKem_0);
            this.Controls.Add(this.lblTrungBinh_0);
            this.Controls.Add(this.lblKha_0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTongSvKoDat_0);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblHocLuc);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKem);
            this.Controls.Add(this.lblYeu);
            this.Controls.Add(this.lblTrungBinh);
            this.Controls.Add(this.lblKha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGioi);
            this.Controls.Add(this.lblLocHocLuc);
            this.Controls.Add(this.lblLocLop);
            this.Controls.Add(this.lblTongSvKoDat);
            this.Controls.Add(this.lblTongSvDat);
            this.Controls.Add(this.lblTongSV);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.fThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTongSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblGioi;
        private System.Windows.Forms.Label lblKha;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblYeu;
        private System.Windows.Forms.Label lblKem;
        private System.Windows.Forms.Label lblLocLop;
        private System.Windows.Forms.Label lblLocHocLuc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox lblHocLuc;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTongSvDat;
        private System.Windows.Forms.Label lblTongSvKoDat;
        private System.Windows.Forms.Label lblTongSvKoDat_0;
        private System.Windows.Forms.Label lblTongSV_0;
        private System.Windows.Forms.Label lblTongSvDat_0;
        private System.Windows.Forms.Label lblYeu_0;
        private System.Windows.Forms.Label lblKem_0;
        private System.Windows.Forms.Label lblTrungBinh_0;
        private System.Windows.Forms.Label lblKha_0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}