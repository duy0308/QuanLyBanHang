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
using QuanLy_Model.Nhanvien;
using QuanLy_Model;

namespace QuanLy.FormNhanVien
{
    public partial class frmNhanVienLV : Form
    {
        public int rowindex;
        public frmNhanVienLV()
        {
            InitializeComponent();
        }

        private void frmNhanVienLV_Load(object sender, EventArgs e)
        {
            loadNVLV();
        }
        private void loadNVLV()
        {
            try
            {
                BSNhanVien bs = new BSNhanVien();
                List<NhanVienLV> ds = bs.getNhanVienLV();
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrNhanVienLV.Rows.Add(i + 1, ds[i].MaNV, ds[i].TenNV, ds[i].SLHD, ds[i].TongTien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadNVBYID()
        {
            try
            {
                BSNhanVien bs = new BSNhanVien();
                List<NhanVien> ds = bs.getAllNhanVienByID(dtgrNhanVienLV.Rows[rowindex].Cells[1].Value.ToString());
                for (int i = 0; i < ds.Count; i++)
                {
                    if(dtgrNhanVienLV.Rows[rowindex].Cells[1].Value.ToString()==ds[i].MaNV.ToString())
                    MessageBox.Show(" Mã: " + ds[i].MaNV + "\n Tên: " + ds[i].HoTen + "\n SDT: " + ds[i].SDT + "\n NQL: " + ds[i].MaNQL + "\n Gian Hàng: " + ds[i].MaGH, "Thông tin!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgrNhanVienLV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            rowindex = e.RowIndex;
            loadNVBYID();
        }
    }
}
