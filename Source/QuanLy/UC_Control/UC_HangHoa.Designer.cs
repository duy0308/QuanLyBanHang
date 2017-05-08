namespace QuanLy.UC_Control
{
    partial class UC_HangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbQLHH = new System.Windows.Forms.Label();
            this.grTTHH = new System.Windows.Forms.GroupBox();
            this.cbbGianHang = new System.Windows.Forms.ComboBox();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaHH = new System.Windows.Forms.Label();
            this.dtgrHangHoa = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grTTHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLHH
            // 
            this.lbQLHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQLHH.AutoSize = true;
            this.lbQLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLHH.Location = new System.Drawing.Point(339, 0);
            this.lbQLHH.Name = "lbQLHH";
            this.lbQLHH.Size = new System.Drawing.Size(172, 24);
            this.lbQLHH.TabIndex = 0;
            this.lbQLHH.Text = "Quản Lý Hàng Hóa";
            // 
            // grTTHH
            // 
            this.grTTHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grTTHH.BackColor = System.Drawing.Color.Transparent;
            this.grTTHH.Controls.Add(this.cbbGianHang);
            this.grTTHH.Controls.Add(this.dateNSX);
            this.grTTHH.Controls.Add(this.txtHSD);
            this.grTTHH.Controls.Add(this.label1);
            this.grTTHH.Controls.Add(this.label7);
            this.grTTHH.Controls.Add(this.txtDVT);
            this.grTTHH.Controls.Add(this.txtGia);
            this.grTTHH.Controls.Add(this.txtSoLuong);
            this.grTTHH.Controls.Add(this.txtTenHH);
            this.grTTHH.Controls.Add(this.txtMaHH);
            this.grTTHH.Controls.Add(this.label6);
            this.grTTHH.Controls.Add(this.label5);
            this.grTTHH.Controls.Add(this.label4);
            this.grTTHH.Controls.Add(this.label3);
            this.grTTHH.Controls.Add(this.label2);
            this.grTTHH.Controls.Add(this.lbMaHH);
            this.grTTHH.Location = new System.Drawing.Point(70, 34);
            this.grTTHH.Name = "grTTHH";
            this.grTTHH.Size = new System.Drawing.Size(710, 158);
            this.grTTHH.TabIndex = 1;
            this.grTTHH.TabStop = false;
            this.grTTHH.Text = "Thông Tin Hàng Hóa";
            // 
            // cbbGianHang
            // 
            this.cbbGianHang.FormattingEnabled = true;
            this.cbbGianHang.Location = new System.Drawing.Point(470, 129);
            this.cbbGianHang.Name = "cbbGianHang";
            this.cbbGianHang.Size = new System.Drawing.Size(194, 21);
            this.cbbGianHang.TabIndex = 29;
            // 
            // dateNSX
            // 
            this.dateNSX.CustomFormat = "MM/dd/yyyy";
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNSX.Location = new System.Drawing.Point(470, 69);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateNSX.Size = new System.Drawing.Size(194, 20);
            this.dateNSX.TabIndex = 28;
            // 
            // txtHSD
            // 
            this.txtHSD.Location = new System.Drawing.Point(470, 97);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Size = new System.Drawing.Size(194, 20);
            this.txtHSD.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gian Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "HSD";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(470, 33);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(194, 20);
            this.txtDVT.TabIndex = 22;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(141, 129);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(194, 20);
            this.txtGia.TabIndex = 21;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(141, 97);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(194, 20);
            this.txtSoLuong.TabIndex = 20;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(141, 65);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(194, 20);
            this.txtTenHH.TabIndex = 19;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(141, 33);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(194, 20);
            this.txtMaHH.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "NSX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // lbMaHH
            // 
            this.lbMaHH.AutoSize = true;
            this.lbMaHH.Location = new System.Drawing.Point(41, 37);
            this.lbMaHH.Name = "lbMaHH";
            this.lbMaHH.Size = new System.Drawing.Size(74, 13);
            this.lbMaHH.TabIndex = 12;
            this.lbMaHH.Text = "Mã Hàng Hóa";
            // 
            // dtgrHangHoa
            // 
            this.dtgrHangHoa.AllowUserToAddRows = false;
            this.dtgrHangHoa.AllowUserToDeleteRows = false;
            this.dtgrHangHoa.AllowUserToResizeRows = false;
            this.dtgrHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrHangHoa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHH,
            this.TenHH,
            this.SoLuong,
            this.DONGIA,
            this.DONVITINH,
            this.NSX,
            this.HSD,
            this.GIANHANG});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrHangHoa.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrHangHoa.Location = new System.Drawing.Point(19, 227);
            this.dtgrHangHoa.MultiSelect = false;
            this.dtgrHangHoa.Name = "dtgrHangHoa";
            this.dtgrHangHoa.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrHangHoa.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgrHangHoa.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgrHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrHangHoa.Size = new System.Drawing.Size(817, 214);
            this.dtgrHangHoa.TabIndex = 5;
            this.dtgrHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHangHoa_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 50;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaHH.DataPropertyName = "MAHH";
            this.MaHH.HeaderText = "Mã";
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            this.MaHH.Width = 70;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenHH.DataPropertyName = "TENHH";
            this.TenHH.HeaderText = "Tên Hàng Hóa";
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            this.TenHH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHH.Width = 144;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 70;
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DONGIA.DataPropertyName = "GIAHH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // DONVITINH
            // 
            this.DONVITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DONVITINH.DataPropertyName = "DVT";
            this.DONVITINH.HeaderText = "Đơn Vị Tính";
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.ReadOnly = true;
            this.DONVITINH.Width = 90;
            // 
            // NSX
            // 
            this.NSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NSX.DataPropertyName = "NSX";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NSX.DefaultCellStyle = dataGridViewCellStyle4;
            this.NSX.HeaderText = "NSX";
            this.NSX.Name = "NSX";
            this.NSX.ReadOnly = true;
            // 
            // HSD
            // 
            this.HSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.Name = "HSD";
            this.HSD.ReadOnly = true;
            // 
            // GIANHANG
            // 
            this.GIANHANG.DataPropertyName = "MAGH";
            this.GIANHANG.HeaderText = "Gian Hàng";
            this.GIANHANG.Name = "GIANHANG";
            this.GIANHANG.ReadOnly = true;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.Location = new System.Drawing.Point(299, 198);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSua.Location = new System.Drawing.Point(388, 198);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXoa.Location = new System.Drawing.Point(477, 198);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgrHangHoa);
            this.Controls.Add(this.grTTHH);
            this.Controls.Add(this.lbQLHH);
            this.Name = "UC_HangHoa";
            this.Size = new System.Drawing.Size(850, 454);
            this.Load += new System.EventHandler(this.UC_HangHoa_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UC_HangHoa_MouseDoubleClick);
            this.grTTHH.ResumeLayout(false);
            this.grTTHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLHH;
        private System.Windows.Forms.GroupBox grTTHH;
        private System.Windows.Forms.ComboBox cbbGianHang;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaHH;
        private System.Windows.Forms.DataGridView dtgrHangHoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHANG;
        private System.Windows.Forms.Button button1;
    }
}
