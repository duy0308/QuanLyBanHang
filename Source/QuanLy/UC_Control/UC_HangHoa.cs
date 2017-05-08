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
using System.Drawing.Drawing2D;

namespace QuanLy.UC_Control
{
    public partial class UC_HangHoa : UserControl
    {
        public static int IndexRow;
        public UC_HangHoa()
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
        private void UC_HangHoa_Load(object sender, EventArgs e)
        {
            loadHH();
            AnHien(false);
        }
        private void loadHH()
        {
            try
            {
                BSHangHoa bs = new BSHangHoa();
                List<HangHoa> ds = bs.getAllHangHoa();
                
                BSGianHang bsgh = new BSGianHang();
                List<GianHang> dsgh = bsgh.getGianHang();
                cbbGianHang.DataSource = dsgh;
                cbbGianHang.ValueMember = "MaGH";
                cbbGianHang.DisplayMember = "TenGH";
                for (int i = 0; i < ds.Count; i++)
                {
                    for (int j = 0; j < dsgh.Count; j++)
                    {
                        if (ds[i].MaGH.ToString() == dsgh[j].MaGH.ToString())
                            ds[i].MaGH = dsgh[j].TenGH.ToString();
                    }
                }
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrHangHoa.Rows.Add(i + 1, ds[i].MaHH, ds[i].TenHH, ds[i].Soluong, ds[i].GiaHH, ds[i].DVT, ds[i].NSX, ds[i].HSD, ds[i].MaGH);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// kiem tra xem hang hoa da co trong list chua
        /// </summary>
        /// <param name="tenhang">ten hang hoa</param>
        /// <returns>-1 neu khong co hang hoa trung</returns>
        private int KiemtraTrung(string tenhang)
        {
            for (int i = 0; i < dtgrHangHoa.Rows.Count; i++)
            {
                string rowTH = dtgrHangHoa[2, i].Value.ToString();
                if (rowTH.ToUpper() == tenhang.ToUpper())
                    return i;
            }
            return -1;
        }
        private void setTextNull()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtDVT.Text = "";
            txtHSD.Text = "";
            cbbGianHang.Text = "";
        }
        private void btThem_Click(object sender, EventArgs e)
        {         
            try
            {
                HangHoa hh = new HangHoa();
                hh.MaHH = txtMaHH.Text;
                hh.TenHH = txtTenHH.Text;
                hh.Soluong = Int32.Parse(txtSoLuong.Text);
                hh.GiaHH = Int32.Parse(txtGia.Text);
                hh.DVT = txtDVT.Text;
                hh.NSX = dateNSX.Text;
                hh.HSD = txtHSD.Text;
                hh.MaGH = cbbGianHang.SelectedValue.ToString();
                if (KiemtraTrung(hh.TenHH) != -1)
                {
                    MessageBox.Show("Đã có loại hàng hóa '" + hh.TenHH + "' trong danh sách. Không thể thêm mới!\n Xin vui lòng check lại dữ liệu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BSHangHoa bs = new BSHangHoa();
                    bool result = bs.insertHangHoa(hh);
                    if (result == true)
                    {
                        dtgrHangHoa.Rows.Add(dtgrHangHoa.Rows.Count + 1, hh.MaHH, hh.TenHH, hh.Soluong, hh.GiaHH, hh.DVT, hh.NSX, hh.HSD, hh.MaGH);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            setTextNull();
            AnHien(false);
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (IndexRow == -1)
            {
                setTextNull();
                return;
            }
            try
            {
                HangHoa hh = new HangHoa();
                BSHangHoa bs = new BSHangHoa();
                hh.MaHH = txtMaHH.Text;
                hh.TenHH = txtTenHH.Text;
                hh.Soluong = Int32.Parse(txtSoLuong.Text);
                hh.GiaHH = Int32.Parse(txtGia.Text);
                hh.DVT = txtDVT.Text;
                hh.NSX = dateNSX.Text;
                hh.HSD = txtHSD.Text;
                hh.MaGH = cbbGianHang.Text;
                if (KiemtraTrung(hh.TenHH) != -1)
                {
                    MessageBox.Show("Loại hàng hóa '" + hh.TenHH + "' đã có trong danh sách. Tên vừa sửa đổi bị trùng!\n Xin vui lòng check lại dữ liệu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    bool bl = bs.updateHangHoa(hh);
                    if (bl == true)
                    {
                        DataGridViewRow row = dtgrHangHoa.Rows[IndexRow];
                        row.Cells[0].Value = hh.MaHH;
                        row.Cells[1].Value = hh.TenHH;
                        row.Cells[2].Value = hh.Soluong;
                        row.Cells[3].Value = hh.GiaHH;
                        row.Cells[4].Value = hh.DVT;
                        row.Cells[5].Value = hh.NSX;
                        row.Cells[6].Value = hh.HSD;
                        row.Cells[7].Value = hh.MaGH;
                    }
                }
                AnHien(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setTextNull();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (IndexRow == -1)
            {
                setTextNull();
                return;
            }
            try
            {
                HangHoa hh = new HangHoa();
                BSHangHoa bs = new BSHangHoa();
                hh.MaHH = txtMaHH.Text;
                hh.TenHH = txtTenHH.Text;
                hh.Soluong = Int32.Parse(txtSoLuong.Text);
                hh.GiaHH = Int32.Parse(txtGia.Text);
                hh.DVT = txtDVT.Text;
                hh.NSX = dateNSX.Text;
                hh.HSD = txtHSD.Text;
                hh.MaGH = cbbGianHang.Text;
                bs.deleteHangHoa(hh.MaHH);
                if (bs.deleteHangHoa(hh.MaHH) == true)
                {
                    dtgrHangHoa.Rows.RemoveAt(IndexRow);
                    AnHien(false);
                    for (int i = IndexRow; i < dtgrHangHoa.Rows.Count; i++)
                    {
                        int c;
                        string s1 = dtgrHangHoa[0, i].Value.ToString();
                        int.TryParse(s1, out c);
                        c = c - 1;
                        dtgrHangHoa[0, i].Value = c;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            setTextNull();
        }
        private void AnHien(bool value)
        {
            txtMaHH.ReadOnly = txtDVT.ReadOnly = btSua.Enabled = btXoa.Enabled = value;
        }
        private void dtgrHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;
            if (IndexRow == -1)
                return;
            AnHien(true);
            DataGridViewRow row = dtgrHangHoa.Rows[IndexRow];
            try
            {
                txtMaHH.Text = row.Cells[1].Value.ToString();
                txtTenHH.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGia.Text = row.Cells[4].Value.ToString();
                txtDVT.Text = row.Cells[5].Value.ToString();
                dateNSX.Text = row.Cells[6].Value.ToString();
                txtHSD.Text = row.Cells[7].Value.ToString();
                cbbGianHang.Text = row.Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi " + ex.Message);
            }
        }

        private void UC_HangHoa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setTextNull();
            loadHH();
            AnHien(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn suất ra file ExCel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                Export_Excel.ExportDataGridViewTo_Excel12(dtgrHangHoa);
        }
    }
}
