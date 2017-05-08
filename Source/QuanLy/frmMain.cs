using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class frmMain : Form
    {
        private int a;
        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private void setVis1()
        {
            quảnLýToolStripMenuItem.Visible = false;
            tooltripLogIn.Visible = false;
        }
        private void setVis2()
        {
            quảnLýToolStripMenuItem.Visible = false;
            quảnLýHóaĐơnToolStripMenuItem.Visible = false;
            tooltripLogIn.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            a = frmLogIn.IndexLog();
            if (a == 2)
                setVis2();
            this.Show();
            
        }
        private void addNewTab(string strTabName, UserControl ucContent)
        {
            foreach (TabPage tabpage in tabControl.TabPages)
            {
                if (tabpage.Text == strTabName)
                {
                    tabControl.SelectedTab = tabpage;
                    return;
                }
            }
            SupperTabControl newTabPanel = new SupperTabControl();
            TabPage newTabPage = new TabPage();
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = strTabName;
            newTabPanel.Size = new System.Drawing.Size(tabControl.Width, tabControl.Height);
            newTabPanel.TabIndex = 2;
            newTabPanel.Tag = newTabPage;

            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22324);
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(ucContent);

            tabControl.TabPages.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Control.UC_NhapHang ucnhaphang = new UC_Control.UC_NhapHang();
            addNewTab("Nhập Hàng", ucnhaphang);
        }

        private void tooltripLogIn_Click(object sender, EventArgs e)
        {
            //frmPhanQuyen frm = new frmPhanQuyen();
            //frm.ShowDialog();
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Control.UC_HangHoa uchanghoa = new UC_Control.UC_HangHoa();
            addNewTab("Hàng Hóa", uchanghoa);
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Control.UC_BanHang ucbanhang = new UC_Control.UC_BanHang();
            addNewTab("Bán Hàng", ucbanhang);
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Control.UC_KhachHang uckhachhang = new UC_Control.UC_KhachHang();
            addNewTab("Khách Hàng", uckhachhang);
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Control.UC_HoaDon uchoadon = new UC_Control.UC_HoaDon();
            addNewTab("Danh sách Hóa Đơn", uchoadon);
        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetailKhachHang.frmKhachHang frmkh = new FormDetailKhachHang.frmKhachHang();
            frmkh.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDetailKhachHang.frmtimkiem frm = new FormDetailKhachHang.frmtimkiem();
            frm.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_Control.UC_NhanVien ucnhanvien = new UC_Control.UC_NhanVien();
            addNewTab("Danh Sách Nhân Viên", ucnhanvien);
        }

        private void làmViệcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNhanVien.frmNhanVienLV frm = new FormNhanVien.frmNhanVienLV();
            frm.ShowDialog();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Control.UC_DoanhThuThang ucdoanhthu = new UC_Control.UC_DoanhThuThang();
            addNewTab("Chi Tiết Doanh Thu", ucdoanhthu);
        }

        private void hanghoatoolship_Click(object sender, EventArgs e)
        {
            FormDetailHangHoa.frmHangHoaSL frm = new FormDetailHangHoa.frmHangHoaSL();
            frm.ShowDialog();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass frm = new ChangePass();
            frm.StartPosition = this.StartPosition;
            frm.ShowDialog();
        }
    }
}
