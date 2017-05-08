using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_Bus;
using QuanLy_Model;
using QuanLy.FormDetail;
using System.Drawing.Drawing2D;

namespace QuanLy.UC_Control
{
    public partial class UC_HoaDon : UserControl
    {
        private int rowindex = 0;
        public UC_HoaDon()
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

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        public void loadHoaDon()
        {
            try
            {
                BSHoaDon bs = new BSHoaDon();
                List<HoaDon> ds =bs.getAllHoaDon();
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrHoaDon.Rows.Add(1 + i, ds[i].MaHD, ds[i].NgayLap, ds[i].TongTien, ds[i].MaNV, ds[i].MaKH, "Chi Tiết");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgrHoaDon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietHD fr = new frmChiTietHD();
            fr.mahd = dtgrHoaDon.Rows[rowindex].Cells["MAHD"].Value.ToString();
            fr.ShowDialog();
        }

        private void dtgrHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            rowindex = e.RowIndex;
        }

        private void dtgrHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn suất ra file ExCel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                Export_Excel.ExportDataGridViewTo_Excel12(dtgrHoaDon);
        }
      
    }
}
