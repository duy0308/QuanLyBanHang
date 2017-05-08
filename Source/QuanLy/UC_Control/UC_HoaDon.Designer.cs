namespace QuanLy.UC_Control
{
    partial class UC_HoaDon
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
            this.dtgrHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dtgrHoaDonSelectBy = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHoaDonSelectBy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrHoaDon
            // 
            this.dtgrHoaDon.AllowUserToAddRows = false;
            this.dtgrHoaDon.AllowUserToDeleteRows = false;
            this.dtgrHoaDon.AllowUserToResizeRows = false;
            this.dtgrHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtgrHoaDon.ColumnHeadersHeight = 40;
            this.dtgrHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAHD,
            this.NGAYLAP,
            this.TONGTIEN,
            this.MANV,
            this.MAKH,
            this.ChiTiet});
            this.dtgrHoaDon.Location = new System.Drawing.Point(30, 211);
            this.dtgrHoaDon.MultiSelect = false;
            this.dtgrHoaDon.Name = "dtgrHoaDon";
            this.dtgrHoaDon.ReadOnly = true;
            this.dtgrHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrHoaDon.Size = new System.Drawing.Size(779, 223);
            this.dtgrHoaDon.TabIndex = 0;
            this.dtgrHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHoaDon_CellClick);
            this.dtgrHoaDon.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHoaDon_CellContentDoubleClick);
            this.dtgrHoaDon.DoubleClick += new System.EventHandler(this.dtgrHoaDon_DoubleClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 35;
            // 
            // MAHD
            // 
            this.MAHD.HeaderText = "Mã HD";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.HeaderText = "Ngày Lập";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi Tiết HD";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            this.ChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtgrHoaDonSelectBy
            // 
            this.dtgrHoaDonSelectBy.BackgroundColor = System.Drawing.Color.White;
            this.dtgrHoaDonSelectBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHoaDonSelectBy.Location = new System.Drawing.Point(343, 39);
            this.dtgrHoaDonSelectBy.Name = "dtgrHoaDonSelectBy";
            this.dtgrHoaDonSelectBy.Size = new System.Drawing.Size(466, 148);
            this.dtgrHoaDonSelectBy.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Location = new System.Drawing.Point(32, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(18, 104);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 31);
            this.btTimKiem.TabIndex = 8;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(197, 111);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(75, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(107, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(75, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tháng";
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(137, 70);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(45, 21);
            this.cbbNam.TabIndex = 3;
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(137, 30);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(45, 21);
            this.cbbThang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số HD theo";
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(197, 30);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 61);
            this.btChon.TabIndex = 0;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Hóa Đơn";
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrHoaDonSelectBy);
            this.Controls.Add(this.dtgrHoaDon);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(838, 447);
            this.Load += new System.EventHandler(this.UC_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHoaDonSelectBy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewLinkColumn ChiTiet;
        private System.Windows.Forms.DataGridView dtgrHoaDonSelectBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.Label label1;
    }
}
