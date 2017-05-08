using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_Bus;
using QuanLy_Model;

namespace QuanLy.FormDetailKhachHang
{
    public partial class frmHdKH : Form
    {
        private int rowindex;
        public string makh;
        public frmHdKH()
        {
            InitializeComponent();
        }
        public void loadHoaDon()
        {
            
            try
            {
                BSHoaDon bs = new BSHoaDon();
                List<HoaDon> ds = bs.getHoaDonByID(makh);
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrHdKH.Rows.Add(1 + i, ds[i].MaHD, ds[i].NgayLap, ds[i].MaNV, ds[i].TongTien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmHdKH_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void dtgrHdKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            rowindex = e.RowIndex;
            FormDetail.frmChiTietHD frm = new FormDetail.frmChiTietHD();
            frm.mahd = dtgrHdKH.Rows[rowindex].Cells[1].Value.ToString();
            frm.ShowDialog();
        }
    }
}
