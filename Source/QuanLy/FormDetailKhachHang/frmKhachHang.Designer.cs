namespace QuanLy.FormDetailKhachHang
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.dtgrHoatDongKH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMenuSLHD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chitiettoolShip = new System.Windows.Forms.ToolStripMenuItem();
            this.SoLuongMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMenuSLHH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TongTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHoatDongKH)).BeginInit();
            this.ctxtMenuSLHD.SuspendLayout();
            this.ctxtMenuSLHH.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrHoatDongKH
            // 
            this.dtgrHoatDongKH.AllowUserToAddRows = false;
            this.dtgrHoatDongKH.AllowUserToDeleteRows = false;
            this.dtgrHoatDongKH.AllowUserToResizeColumns = false;
            this.dtgrHoatDongKH.AllowUserToResizeRows = false;
            this.dtgrHoatDongKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrHoatDongKH.BackgroundColor = System.Drawing.Color.White;
            this.dtgrHoatDongKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrHoatDongKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKH,
            this.TenKH,
            this.SoLuongHD,
            this.SoLuongMH,
            this.TongTienChi});
            this.dtgrHoatDongKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrHoatDongKH.Location = new System.Drawing.Point(0, 0);
            this.dtgrHoatDongKH.MultiSelect = false;
            this.dtgrHoatDongKH.Name = "dtgrHoatDongKH";
            this.dtgrHoatDongKH.ReadOnly = true;
            this.dtgrHoatDongKH.RowHeadersVisible = false;
            this.dtgrHoatDongKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrHoatDongKH.Size = new System.Drawing.Size(709, 348);
            this.dtgrHoatDongKH.StandardTab = true;
            this.dtgrHoatDongKH.TabIndex = 0;
            this.dtgrHoatDongKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrHoatDongKH_CellClick);
            this.dtgrHoatDongKH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgrHoatDongKH_CellMouseClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 35;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 80;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "HOTEN";
            this.TenKH.HeaderText = "Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SoLuongHD
            // 
            this.SoLuongHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuongHD.ContextMenuStrip = this.ctxtMenuSLHD;
            this.SoLuongHD.DataPropertyName = "SLHD";
            this.SoLuongHD.HeaderText = "Số Lượng HD";
            this.SoLuongHD.Name = "SoLuongHD";
            this.SoLuongHD.ReadOnly = true;
            this.SoLuongHD.Width = 80;
            // 
            // ctxtMenuSLHD
            // 
            this.ctxtMenuSLHD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chitiettoolShip});
            this.ctxtMenuSLHD.Name = "ctxtMenu";
            this.ctxtMenuSLHD.Size = new System.Drawing.Size(116, 26);
            // 
            // chitiettoolShip
            // 
            this.chitiettoolShip.Name = "chitiettoolShip";
            this.chitiettoolShip.Size = new System.Drawing.Size(115, 22);
            this.chitiettoolShip.Text = "Chi Tiết";
            this.chitiettoolShip.Click += new System.EventHandler(this.chitiettoolShip_Click);
            // 
            // SoLuongMH
            // 
            this.SoLuongMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuongMH.ContextMenuStrip = this.ctxtMenuSLHH;
            this.SoLuongMH.DataPropertyName = "SLMH";
            this.SoLuongMH.HeaderText = "Số Lượng Mặt Hàng Đã Mua";
            this.SoLuongMH.Name = "SoLuongMH";
            this.SoLuongMH.ReadOnly = true;
            this.SoLuongMH.Width = 90;
            // 
            // ctxtMenuSLHH
            // 
            this.ctxtMenuSLHH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem});
            this.ctxtMenuSLHH.Name = "ctxtMenuSLHH";
            this.ctxtMenuSLHH.Size = new System.Drawing.Size(116, 26);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.chiTiếtToolStripMenuItem.Text = "Chi Tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // TongTienChi
            // 
            this.TongTienChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TongTienChi.DataPropertyName = "TONGTIEN";
            this.TongTienChi.HeaderText = "Tổng Tiền Chi";
            this.TongTienChi.Name = "TongTienChi";
            this.TongTienChi.ReadOnly = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 348);
            this.Controls.Add(this.dtgrHoatDongKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(725, 387);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoạt Động Của Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrHoatDongKH)).EndInit();
            this.ctxtMenuSLHD.ResumeLayout(false);
            this.ctxtMenuSLHH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrHoatDongKH;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuSLHD;
        private System.Windows.Forms.ToolStripMenuItem chitiettoolShip;
        private System.Windows.Forms.ContextMenuStrip ctxtMenuSLHH;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienChi;
    }
}