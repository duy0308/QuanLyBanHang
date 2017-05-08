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
using QuanLy_Model.Khachhang;

namespace QuanLy.FormDetailKhachHang
{
    public partial class frmKhachHang : Form
    {
        private int rowindex;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void loadHDKH()
        {
            try
            {
                BSKhachHang bs = new BSKhachHang();
                List<KhachHangHD> ds = bs.getHDKhachHang();
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrHoatDongKH.Rows.Add(i + 1, ds[i].MaKH, ds[i].HoTen, ds[i].SLHD, ds[i].SLMH, ds[i].TongTien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadHDKH();
        }
        private void chitiettoolShip_Click(object sender, EventArgs e)
        {
            FormDetailKhachHang.frmHdKH frm = new frmHdKH();
            frm.makh = dtgrHoatDongKH.Rows[rowindex].Cells[1].Value.ToString();
            frm.ShowDialog();
        }

        private void dtgrHoatDongKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetailKhachHang.HHorderbyKH frm = new HHorderbyKH();
            frm.makh = dtgrHoatDongKH.Rows[rowindex].Cells[1].Value.ToString();
            frm.ShowDialog();
        }
        private void loadKHByID()
        {
            try
            {
                List<KhachHang> ds = null;
                BSKhachHang bs = new BSKhachHang();
                ds = bs.getKhachHangByID(dtgrHoatDongKH.Rows[rowindex].Cells[1].Value.ToString());
                MessageBox.Show(" Mã KH: " + ds[0].MaKH.ToString() + "\n Tên KH: " + ds[0].HoTen.ToString() + "\n Địa Chỉ: " + ds[0].DiaChi.ToString() + "\n SDT: " + ds[0].SDT.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dtgrHoatDongKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1)
                return;
            rowindex = e.RowIndex;
            loadKHByID();
        }
    }
}
