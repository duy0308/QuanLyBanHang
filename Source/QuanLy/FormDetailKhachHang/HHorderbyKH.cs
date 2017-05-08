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
using QuanLy_Model.Khachhang;

namespace QuanLy.FormDetailKhachHang
{
    public partial class HHorderbyKH : Form
    {
        public string makh;
        public HHorderbyKH()
        {
            InitializeComponent();
        }

        private void HHorderbyKH_Load(object sender, EventArgs e)
        {
            loadHH();
        }
        private void loadHH()
        {
            try
            {
                BSKhachHang bs = new BSKhachHang();
                List<HangHoaSL> ds = bs.getHHKhachHang(makh);
                for (int i = 0; i < ds.Count; i++)
                {
                    dataGridView1.Rows.Add(i + 1, ds[i].TenHH, ds[i].SLHH);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int i = e.RowIndex;
            MessageBox.Show("Tên Hàng Hóa:" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n Số Lượng Đã Mua: " + dataGridView1.Rows[i].Cells[2].Value.ToString(),"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
