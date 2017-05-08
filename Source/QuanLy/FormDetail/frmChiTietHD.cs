using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_Model;
using QuanLy_Bus;

namespace QuanLy.FormDetail
{
    public partial class frmChiTietHD : Form
    {
        public string mahd;
        public frmChiTietHD()
        {
            InitializeComponent();
        }
        private void loadChiTiet()
        {
            try
            {
                BSChiTietHD bs = new BSChiTietHD();
                List<ChiTietHoaDon> ds = bs.getChiTietByID(mahd);
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrChiTietHD.Rows.Add(i + 1,ds[i].MaHD,ds[i].MaHH, ds[i].SoLuong, ds[i].DVT, ds[i].DonGia, ds[i].ThanhTien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            loadChiTiet();
        }

        private void dtgrChiTietHD_DoubleClick(object sender, EventArgs e)
        {
            if((MessageBox.Show("Bạn có muốn suất ra file ExCel?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes)
            Export_Excel.ExportDataGridViewTo_Excel12(dtgrChiTietHD);
        }
    }
}
