namespace QuanLy.UC_Control
{
    partial class UC_DoanhThuThang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgrDoanhThuNgay = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrDoanhThuThang = new System.Windows.Forms.DataGridView();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.btChon = new System.Windows.Forms.Button();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDoanhThuNgay)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrDoanhThuNgay
            // 
            this.dtgrDoanhThuNgay.AllowUserToAddRows = false;
            this.dtgrDoanhThuNgay.AllowUserToDeleteRows = false;
            this.dtgrDoanhThuNgay.AllowUserToResizeColumns = false;
            this.dtgrDoanhThuNgay.AllowUserToResizeRows = false;
            this.dtgrDoanhThuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrDoanhThuNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrDoanhThuNgay.BackgroundColor = System.Drawing.Color.White;
            this.dtgrDoanhThuNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDoanhThuNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ngay,
            this.TongTien});
            this.dtgrDoanhThuNgay.GridColor = System.Drawing.Color.White;
            this.dtgrDoanhThuNgay.Location = new System.Drawing.Point(13, 228);
            this.dtgrDoanhThuNgay.MultiSelect = false;
            this.dtgrDoanhThuNgay.Name = "dtgrDoanhThuNgay";
            this.dtgrDoanhThuNgay.ReadOnly = true;
            this.dtgrDoanhThuNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrDoanhThuNgay.Size = new System.Drawing.Size(771, 229);
            this.dtgrDoanhThuNgay.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbTongThu);
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục";
            // 
            // dtgrDoanhThuThang
            // 
            this.dtgrDoanhThuThang.AllowUserToAddRows = false;
            this.dtgrDoanhThuThang.AllowUserToDeleteRows = false;
            this.dtgrDoanhThuThang.AllowUserToResizeColumns = false;
            this.dtgrDoanhThuThang.AllowUserToResizeRows = false;
            this.dtgrDoanhThuThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrDoanhThuThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrDoanhThuThang.BackgroundColor = System.Drawing.Color.White;
            this.dtgrDoanhThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDoanhThuThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.Thang,
            this.TongTienThang});
            this.dtgrDoanhThuThang.Location = new System.Drawing.Point(232, 30);
            this.dtgrDoanhThuThang.MultiSelect = false;
            this.dtgrDoanhThuThang.Name = "dtgrDoanhThuThang";
            this.dtgrDoanhThuThang.ReadOnly = true;
            this.dtgrDoanhThuThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrDoanhThuThang.Size = new System.Drawing.Size(552, 161);
            this.dtgrDoanhThuThang.TabIndex = 2;
            this.dtgrDoanhThuThang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrDoanhThuThang_CellClick);
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.Ivory;
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "All"});
            this.cbbThang.Location = new System.Drawing.Point(72, 24);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 21);
            this.cbbThang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(72, 64);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(121, 21);
            this.cbbNam.TabIndex = 3;
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(72, 95);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 30);
            this.btChon.TabIndex = 4;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // TongTienThang
            // 
            this.TongTienThang.HeaderText = "Tổng Tiền";
            this.TongTienThang.Name = "TongTienThang";
            this.TongTienThang.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("VNIThufapfan", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chi Tiết";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("VNIThufapfan", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doanh Thu Các Tháng";
            // 
            // lbTongThu
            // 
            this.lbTongThu.AutoSize = true;
            this.lbTongThu.Location = new System.Drawing.Point(69, 138);
            this.lbTongThu.Name = "lbTongThu";
            this.lbTongThu.Size = new System.Drawing.Size(29, 13);
            this.lbTongThu.TabIndex = 5;
            this.lbTongThu.Text = "Năm";
            // 
            // UC_DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgrDoanhThuThang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrDoanhThuNgay);
            this.Name = "UC_DoanhThuThang";
            this.Size = new System.Drawing.Size(800, 471);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDoanhThuNgay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDoanhThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrDoanhThuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.DataGridView dtgrDoanhThuThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTongThu;
    }
}
