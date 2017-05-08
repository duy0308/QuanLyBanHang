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

namespace QuanLy.FormDetailKhachHang
{
    public partial class frmtimkiem : Form
    {
        public frmtimkiem()
        {
            InitializeComponent();
        }
        public void loadKH()
        {
            try
            {
                BSKhachHang bs = new BSKhachHang();
                List<KhachHang> ds = bs.getAllKhachhang();
                for (int i = 0; i < ds.Count; i++)
                {
                    dataGridView1.Rows.Add(i + 1, ds[i].MaKH, ds[i].HoTen, ds[i].DiaChi, ds[i].SDT, ds[i].SoDuTK, ds[i].SoNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadKH1()
        {
            if (dataGridView1.Rows.Count == -1) return;
            else
            {
                for (int i = dataGridView1.Rows.Count - 1; i > -1; i--)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            try
            {
                BSKhachHang bs = new BSKhachHang();
                KhachHang kh = new KhachHang();
                kh.MaKH = "";
                kh.HoTen = txtHoTen.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SDT = txtSDT.Text;
                try
                {
                    kh.SoDuTK = Int32.Parse(txtSoDuTK.Text);
                    kh.SoNo = Int32.Parse(txtSoNo.Text);
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Ô số nợ hoặc số dư tk đã nhập sai định dạng");
                }
                List<KhachHang> ds = bs.searchKhachHang(kh);
                for (int i = 0; i < ds.Count; i++)
                {
                    dataGridView1.Rows.Add(i + 1, ds[i].MaKH, ds[i].HoTen, ds[i].DiaChi, ds[i].SDT, ds[i].SoDuTK, ds[i].SoNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void searchKhachHang()
        {
            int a, b;
            try
            {
                a = Int32.Parse(txtSoDuTK.Text);
                b = Int32.Parse(txtSoNo.Text);

                BSKhachHang bs = new BSKhachHang();
                List<KhachHang> ds = bs.getAllKhachhang();
                List<KhachHang> ds1 = new List<KhachHang>();
                removerow();
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].HoTen.Contains(txtHoTen.Text) == true && ds[i].DiaChi.Contains(txtDiaChi.Text) == true && ds[i].SDT.Contains(txtSDT.Text) == true && (ds[i].SoDuTK > a || ds[i].SoDuTK == a) && (ds[i].SoNo > b || ds[i].SoNo == b))
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKH = ds[i].MaKH;
                        kh.HoTen = ds[i].HoTen;
                        kh.DiaChi = ds[i].DiaChi;
                        kh.SDT = ds[i].SDT;
                        kh.SoDuTK = ds[i].SoDuTK;
                        kh.SoNo = ds[i].SoNo;
                        ds1.Add(kh);
                    }
                }
                for (int i = 0; i < ds1.Count; i++)
                {
                    dataGridView1.Rows.Add(i + 1, ds1[i].MaKH, ds1[i].HoTen, ds1[i].DiaChi, ds1[i].SDT, ds1[i].SoDuTK, ds1[i].SoNo);
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show("khong de trong so du va so no");
            }
        }
        //private void addnewrow(KhachHang kh,int stt)
        //{
        //    DataGridViewRow row = new DataGridViewRow();
        //    row.CreateCells(dataGridView1);
        //    row.Cells[0].Value = stt;
        //    row.Cells[1].Value = kh.MaKH.ToString();
        //    row.Cells[2].Value = kh.HoTen.ToString();
        //    row.Cells[3].Value = kh.DiaChi.ToString();
        //    row.Cells[4].Value = kh.SDT.ToString();
        //    row.Cells[5].Value = kh.SoDuTK.ToString();
        //    row.Cells[6].Value = kh.SoNo.ToString();
        //    dataGridView1.Rows.Add(row);
        //}
        private void removerow()
        {
            if (dataGridView1.Rows.Count == -1)
                return;
            for (int i = dataGridView1.Rows.Count-1; i > -1; i--)
            {
                dataGridView1.Rows.RemoveAt(i);
            }
        }
        public void setkh()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSoDuTK.Text = "0";
            txtSoNo.Text = "0";
        }

        private void frmtimkiem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setkh();
            removerow();
            loadKH();
        }

        private void frmtimkiem_Load(object sender, EventArgs e)
        {
            loadKH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadKH1();
        }
    }
}
