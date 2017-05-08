using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using QuanLy_Model;
using QuanLy_Bus;

namespace QuanLy.UC_Control
{
    public partial class UC_DoanhThuThang : UserControl
    {
        public int tongthu;
        private int rowindex;

        private List<DoanhThu> ds = null;
        public UC_DoanhThuThang()
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

        private void load()
        {
            removedtgr(dtgrDoanhThuThang);
            try
            {
                BSDoanhThu bs = new BSDoanhThu();
                if (cbbNam.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập năm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cbbThang.Text == "All")
                    ds = bs.getDoanhThu("", cbbNam.Text);
                else
                    ds = bs.getDoanhThu(cbbThang.Text, cbbNam.Text);
                if (ds.Count == 0)
                {
                    MessageBox.Show("Tháng " + cbbThang.Text + " năm " + cbbNam.Text + " không có giao dịch!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrDoanhThuThang.Rows.Add(i + 1, ds[i].thang, ds[i].tongtien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadDtngay()
        {
            removedtgr(dtgrDoanhThuNgay);
            try
            {
                BSDoanhThuNgay bs = new BSDoanhThuNgay();
                List<DoanhThuNgay> ds1 = bs.getDoanhThu(ds[rowindex].thang, ds[rowindex].nam);
                for (int i = 0; i < ds1.Count; i++)
                {
                    dtgrDoanhThuNgay.Rows.Add(i+1,ds1[i].ngay,ds1[i].tongtien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tongthu1()
        {
            if (cbbNam.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                BSDoanhThu bs = new BSDoanhThu();
                List<DoanhThu> ds = bs.getDoanhThu("", cbbNam.Text);
                for (int i = 0; i < ds.Count; i++)
                {
                    tongthu = tongthu + ds[i].tongtien;
                }
                lbTongThu.Text = "Tổng thu năm " + cbbNam.Text + " là: " + tongthu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            removedtgr(dtgrDoanhThuNgay);
            tongthu1();
            load();
        }
        private void removedtgr(DataGridView dt)
        {
            if (dt.Rows.Count == -1)
                return;
            for (int i = dt.Rows.Count; i > 0; i--)
            {
                dt.Rows.RemoveAt(i - 1);
            }
        }
        private void dtgrDoanhThuThang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            rowindex = e.RowIndex;
            loadDtngay();
        }
    }
}
