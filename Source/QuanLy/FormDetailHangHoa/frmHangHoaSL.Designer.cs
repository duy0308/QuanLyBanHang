namespace QuanLy.FormDetailHangHoa
{
    partial class frmHangHoaSL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoaSL));
            this.dtgrThongKeHH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrThongKeHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrThongKeHH
            // 
            this.dtgrThongKeHH.AllowUserToAddRows = false;
            this.dtgrThongKeHH.AllowUserToDeleteRows = false;
            this.dtgrThongKeHH.AllowUserToResizeColumns = false;
            this.dtgrThongKeHH.AllowUserToResizeRows = false;
            this.dtgrThongKeHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrThongKeHH.BackgroundColor = System.Drawing.Color.White;
            this.dtgrThongKeHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrThongKeHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHh,
            this.Soluong,
            this.DONVITTINH});
            this.dtgrThongKeHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrThongKeHH.Location = new System.Drawing.Point(0, 0);
            this.dtgrThongKeHH.MultiSelect = false;
            this.dtgrThongKeHH.Name = "dtgrThongKeHH";
            this.dtgrThongKeHH.ReadOnly = true;
            this.dtgrThongKeHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrThongKeHH.Size = new System.Drawing.Size(556, 282);
            this.dtgrThongKeHH.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaHh
            // 
            this.MaHh.HeaderText = "TenHH";
            this.MaHh.Name = "MaHh";
            this.MaHh.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // DONVITTINH
            // 
            this.DONVITTINH.HeaderText = "DVT";
            this.DONVITTINH.Name = "DONVITTINH";
            this.DONVITTINH.ReadOnly = true;
            // 
            // frmHangHoaSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 282);
            this.Controls.Add(this.dtgrThongKeHH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(572, 321);
            this.MinimumSize = new System.Drawing.Size(572, 321);
            this.Name = "frmHangHoaSL";
            this.Text = "Danh Sách Hàng Hóa Đã Bán";
            this.Load += new System.EventHandler(this.frmHangHoaSL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrThongKeHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrThongKeHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITTINH;
    }
}