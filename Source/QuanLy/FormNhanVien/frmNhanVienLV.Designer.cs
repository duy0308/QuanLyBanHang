namespace QuanLy.FormNhanVien
{
    partial class frmNhanVienLV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVienLV));
            this.dtgrNhanVienLV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluonghoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNhanVienLV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrNhanVienLV
            // 
            this.dtgrNhanVienLV.AllowUserToAddRows = false;
            this.dtgrNhanVienLV.AllowUserToDeleteRows = false;
            this.dtgrNhanVienLV.AllowUserToResizeColumns = false;
            this.dtgrNhanVienLV.AllowUserToResizeRows = false;
            this.dtgrNhanVienLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrNhanVienLV.BackgroundColor = System.Drawing.Color.White;
            this.dtgrNhanVienLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrNhanVienLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.TenNV,
            this.Soluonghoadon,
            this.Tongtien});
            this.dtgrNhanVienLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrNhanVienLV.Location = new System.Drawing.Point(0, 0);
            this.dtgrNhanVienLV.MultiSelect = false;
            this.dtgrNhanVienLV.Name = "dtgrNhanVienLV";
            this.dtgrNhanVienLV.ReadOnly = true;
            this.dtgrNhanVienLV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrNhanVienLV.Size = new System.Drawing.Size(551, 273);
            this.dtgrNhanVienLV.TabIndex = 0;
            this.dtgrNhanVienLV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrNhanVienLV_CellClick);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 35;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // Soluonghoadon
            // 
            this.Soluonghoadon.HeaderText = "Số lượng HD bán";
            this.Soluonghoadon.Name = "Soluonghoadon";
            this.Soluonghoadon.ReadOnly = true;
            // 
            // Tongtien
            // 
            this.Tongtien.HeaderText = "Tổng thu";
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.ReadOnly = true;
            // 
            // frmNhanVienLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 273);
            this.Controls.Add(this.dtgrNhanVienLV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanVienLV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kết Quả Công Việc";
            this.Load += new System.EventHandler(this.frmNhanVienLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNhanVienLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrNhanVienLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluonghoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
    }
}