namespace QuanLy.FormDetail
{
    partial class frmChiTietHD
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
            this.dtgrChiTietHD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrChiTietHD
            // 
            this.dtgrChiTietHD.AllowUserToAddRows = false;
            this.dtgrChiTietHD.AllowUserToDeleteRows = false;
            this.dtgrChiTietHD.AllowUserToResizeColumns = false;
            this.dtgrChiTietHD.AllowUserToResizeRows = false;
            this.dtgrChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dtgrChiTietHD.ColumnHeadersHeight = 40;
            this.dtgrChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAH,
            this.MAHH,
            this.SOLUONG,
            this.DONVITINH,
            this.DONGIA,
            this.THANHTIEN});
            this.dtgrChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrChiTietHD.GridColor = System.Drawing.Color.White;
            this.dtgrChiTietHD.Location = new System.Drawing.Point(0, 0);
            this.dtgrChiTietHD.MultiSelect = false;
            this.dtgrChiTietHD.Name = "dtgrChiTietHD";
            this.dtgrChiTietHD.ReadOnly = true;
            this.dtgrChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrChiTietHD.Size = new System.Drawing.Size(785, 251);
            this.dtgrChiTietHD.TabIndex = 0;
            this.dtgrChiTietHD.DoubleClick += new System.EventHandler(this.dtgrChiTietHD_DoubleClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MAH
            // 
            this.MAH.HeaderText = "Mã HD";
            this.MAH.Name = "MAH";
            this.MAH.ReadOnly = true;
            // 
            // MAHH
            // 
            this.MAHH.HeaderText = "Mã Hàng";
            this.MAHH.Name = "MAHH";
            this.MAHH.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONVITINH
            // 
            this.DONVITINH.HeaderText = "Đơn Vị Tính";
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // frmChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 251);
            this.Controls.Add(this.dtgrChiTietHD);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 290);
            this.MinimumSize = new System.Drawing.Size(801, 290);
            this.Name = "frmChiTietHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmChiTietHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrChiTietHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}