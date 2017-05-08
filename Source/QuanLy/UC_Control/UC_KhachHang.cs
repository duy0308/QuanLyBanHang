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
using QuanLy_Model.SortKhachHang;

namespace QuanLy.UC_Control
{
    public partial class UC_KhachHang : UserControl
    {
        private int rowIndex = 0;
        public int soluongKH;
        public UC_KhachHang()
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
        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            loadKH();
            setnullText();
            AnHien(false);
        }
        /// <summary>
        /// load danh sach khach hang
        /// </summary>
        private void loadKH()
        {
            try
            {
                BSKhachHang bs = new BSKhachHang();
                List<KhachHang> ds = bs.getAllKhachhang();
                dtgrKhachHang.DataSource = ds;
                soluongKH = ds.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void setnullText()
        {
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtMaKH.Text = "";
            txtSDT.Text = "";
            txtSoduTK.Text = "0";
            txtSoNo.Text = "0";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int kiemtraMaKH(string makh)
        {
            if (makh.Replace(" ", "") == "")
                return -2;
            for (int i = 0; i < dtgrKhachHang.Rows.Count; i++)
            {
                if (makh == dtgrKhachHang.Rows[i].Cells[0].Value.ToString().Replace(" ", ""))
                {                   
                    return -1;
                }
            }
            return 1;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (kiemtraMaKH(txtMaKH.Text) == -1)
            {
                MessageBox.Show("Khách hàng đã tồn tại! Không thể thêm mới!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kiemtraMaKH(txtMaKH.Text) == -2)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachHang kh = new KhachHang();
            try
            {
                BSKhachHang bs = new BSKhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.HoTen = txtHoTen.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SDT = txtSDT.Text;
                try
                {
                    kh.SoDuTK = Int32.Parse(txtSoduTK.Text);
                }
                catch (Exception ax)
                {
                    MessageBox.Show("Số dư tài khoản không thể có kí tự chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    kh.SoNo = Int32.Parse(txtSoNo.Text);
                }
                catch (Exception ax)
                {
                    MessageBox.Show("Số nợ không thể có kí tự chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bs.insertKhachHang(kh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UC_KhachHang_Load(sender, e);
            setnullText();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            try
            {
                BSKhachHang bs = new BSKhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.HoTen = txtHoTen.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.SDT = txtSDT.Text;
                try
                {
                    kh.SoDuTK = Int32.Parse(txtSoduTK.Text);
                }
                catch (Exception ax)
                {
                    MessageBox.Show("Số dư tài khoản không thể có kí tự chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    kh.SoNo = Int32.Parse(txtSoNo.Text);
                }
                catch (Exception ax)
                {
                    MessageBox.Show("Số nợ không thể có kí tự chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bs.updateKhachHang(kh);
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UC_KhachHang_Load(sender, e);
            setnullText();
            AnHien(false);
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dtgrKhachHang.Rows[rowIndex];
                BSKhachHang bs = new BSKhachHang();
                bs.deleteKhachHang(row.Cells[0].Value.ToString());
                UC_KhachHang_Load(sender, e);
                setnullText();
                AnHien(false);
            }
        }
        private void dtgrKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex == -1)
                return;
            DataGridViewRow row =dtgrKhachHang.Rows[rowIndex];
            AnHien(true);
            try
            {
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtSoduTK.Text = row.Cells[4].Value.ToString();
                txtSoNo.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AnHien(bool Isshow)
        {
            txtMaKH.ReadOnly= btSua.Enabled = btXoa.Enabled = Isshow;
        }


        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbLoaiDM.Text == "Họ Tên")
            {
                try
                {
                    BSKhachHang bs = new BSKhachHang();
                    List<KhachHang> ds = bs.findKhachHang(cbbLoaiDM.SelectedIndex,txtNhapDM.Text);
                    dtgrKhachHang.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có khách hàng này!"+ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cbbLoaiDM.Text == "Số Điện Thoại")
            {
                try
                {
                    BSKhachHang bs = new BSKhachHang();
                    List<KhachHang> ds = bs.findKhachHang(cbbLoaiDM.SelectedIndex, txtNhapDM.Text);
                    dtgrKhachHang.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không có khách hàng có số điện thoại này "+ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chỉ tìm kiếm với danh mục: 'Họ Tên' hoặc 'Số Điện Thoại'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadKH();
            }
        }

        private void btSapxep_Click(object sender, EventArgs e)
        {
            try
            {
                BSKhachHang bs = new BSKhachHang();
                List<KhachHang> ds = bs.getAllKhachhang();
                if (cbbLoaiDM.Text == "Họ Tên")
                {
                    ds.Sort(new KhachhangNameComparer());
                }
                else if (cbbLoaiDM.Text == "Địa Chỉ")
                {
                    ds.Sort(new KhachhangPlaceComparer());
                }
                else if (cbbLoaiDM.Text == "Số Dư TK")
                {
                    ds.Sort(new KhachhangSoDuTK());
                }
                else if (cbbLoaiDM.Text == "Số Nợ")
                {
                    ds.Sort(new KhachhangSoNo());
                }
                else
                {
                    MessageBox.Show("Chỉ sắp xếp với danh mục:'Họ tên','Địa Chỉ','Số Dư TK' hoặc 'Số Nợ'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dtgrKhachHang.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_KhachHang_DoubleClick(object sender, EventArgs e)
        {
            setnullText();
            AnHien(true);
        }
    }
}
