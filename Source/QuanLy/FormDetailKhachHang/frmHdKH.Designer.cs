namespace QuanLy.FormDetailKhachHang
{
    partial class frmHdKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHdKH));
            this.dtgrHdKH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHdKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrHdKH
            // 
            this.dtgrHdKH.AllowUserToAddRows = false;
            this.dtgrHdKH.AllowUserToDeleteRows = false;
            this.dtgrHdKH.AllowUserToResizeRows = false;
            this.dtgrHdKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrHdKH.BackgroundColor = System.Drawing.Color.White;
            this.dtgrHdKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHdKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHD,
            this.NgayLap,
            this.MaNV,
            this.TongTien});
            this.dtgrHdKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrHdKH.Location = new System.Drawing.Point(0, 0);
            this.dtgrHdKH.MultiSelect = false;
            this.dtgrHdKH.Name = "dtgrHdKH";
            this.dtgrHdKH.ReadOnly = true;
            this.dtgrHdKH.RowHeadersVisible = false;
            this.dtgrHdKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrHdKH.Size = new System.Drawing.Size(562, 263);
            this.dtgrHdKH.TabIndex = 0;
            this.dtgrHdKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHdKH_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 35;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // frmHdKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 263);
            this.Controls.Add(this.dtgrHdKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(578, 302);
            this.MinimumSize = new System.Drawing.Size(578, 302);
            this.Name = "frmHdKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết";
            this.Load += new System.EventHandler(this.frmHdKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHdKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrHdKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}