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
using QuanLy_Bus;
using QuanLy_Model;
using QuanLy_Model.SortKhachHang;
using QuanLy_Model.SortHangHoa;
using QuanLy_Model.SortNhanVien;

namespace QuanLy.UC_Control
{
    public partial class UC_BanHang : UserControl
    {
        private int rowindex = 0;
        public UC_BanHang()
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
        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            AnHien(false);
            loadKhachHang();
            loadHangHoa();
            loadNhanVien();
            gelMaHD();
            if (cbbTenHH.Items.Count > 0)
                cbbTenHH_SelectedIndexChanged(null, null);
            if (cbbKhachHang.Items.Count > 0)
                cbbKhachHang_SelectedIndexChanged(null, null);
        }
        private void setnull()
        {
            txtTongTien.Text = "0";
            txtSoLuong.Text = "0";
        }

        /// <summary>
        /// kiểm tra xem hàng hóa được thêm đã có trong hóa đơn chưa
        /// </summary>
        /// <param name="tenhang">tên hàng hóa</param>
        /// <returns>trả về -1 nếu không trùng</returns>
        private int KiemtraTrung(string tenhang)
        {
            for (int i = 0; i < dtgrDonHang.Rows.Count; i++)
            {
                string rowTH = dtgrDonHang[1, i].Value.ToString();
                if (rowTH.ToUpper() == tenhang.ToUpper())
                    return i;
            }
            return -1;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int soluong = 0, dongia = 0, thanhtien = 0, soluong1 = 0;
            DataGridViewRow row = new DataGridViewRow();

            int.TryParse(txtSoLuong.Text, out soluong);
            if (soluong == 0)
            {
                MessageBox.Show("Bạn phải thêm số lượng cho mặt hàng này!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(txtDonGia.Text, out dongia);
            int.TryParse(txtThanhTien.Text, out thanhtien);

            try
            {
                BSHangHoa bshanghoa = new BSHangHoa();
                List<HangHoa> list = bshanghoa.getAllHangHoa();
                int p = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (cbbTenHH.SelectedValue.ToString() == list[i].MaHH.ToString())
                        p = list[i].Soluong;
                }
                if (soluong > p)
                {
                    MessageBox.Show("Số lượng hàng hóa còn lại không đủ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            thanhtien = soluong * dongia;

            row.CreateCells(dtgrDonHang);
            row.Cells[0].Value = dtgrDonHang.Rows.Count + 1;
            row.Cells[1].Value = cbbTenHH.Text;
            row.Cells[2].Value = txtDVT.Text;
            row.Cells[3].Value = soluong;
            row.Cells[4].Value = dongia;
            row.Cells[5].Value = string.Format("{0:0,0}", thanhtien);
            if (KiemtraTrung(cbbTenHH.Text.Trim()) == -1)
            {
                dtgrDonHang.Rows.Add(row);
            }
            else
            {
                string s = dtgrDonHang[3, KiemtraTrung(cbbTenHH.Text.Trim())].Value.ToString();
                int.TryParse(s, out soluong1);
                dtgrDonHang[3, KiemtraTrung(cbbTenHH.Text.Trim())].Value = soluong + soluong1;
                thanhtien = dongia * (soluong + soluong1);
                dtgrDonHang[5, KiemtraTrung(cbbTenHH.Text.Trim())].Value = thanhtien;
                MessageBox.Show("Mặt hàng này đã tồn tại!\n Bạn vừa thay đổi số lượng loại mặt hàng này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            setnull();
            TinhTongTien();
        }

        /// <summary>
        /// Kiểm tra xem hàng hóa vừa sửa lại có bị trùng trong hóa đơn ko
        /// </summary>
        /// <param name="tenhang">tên hàng hóa</param>
        /// <returns>trả về -1 nếu không trùng</returns>
        private int KiemTraSuaTrung(string tenhang)
        {
            for (int i = 0; i < dtgrDonHang.Rows.Count; i++)
            {
                string rowTH = dtgrDonHang[1, i].Value.ToString();
                if ((i != rowindex) && (rowTH.ToUpper() == tenhang.ToUpper()))
                    return i;
            }
            return -1;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int soluong = 0, dongia = 0, thanhtien = 0;
            DataGridViewRow row = dtgrDonHang.Rows[rowindex];

            if (KiemTraSuaTrung(cbbTenHH.Text.Trim()) == -1)
            {
                row.Cells[1].Value = cbbTenHH.Text;
                int.TryParse(txtSoLuong.Text, out soluong);
                row.Cells[2].Value = txtDVT.Text;
                int.TryParse(txtDonGia.Text, out dongia);
                row.Cells[3].Value = soluong;
                int.TryParse(txtThanhTien.Text, out thanhtien);
                row.Cells[4].Value = dongia;
                row.Cells[5].Value = thanhtien;

                AnHien(false);
                setnull();
                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Mặt hàng này đã tồn tại!\n Bạn vừa thay đổi số lượng loại mặt hàng này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtgrDonHang.Rows[KiemTraSuaTrung(cbbTenHH.Text.Trim())].Selected=true;
                AnHien(false);
                return;
            }          
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtgrDonHang.Rows.RemoveAt(rowindex);
                for (int i = rowindex ; i < dtgrDonHang.Rows.Count; i++)
                {
                    dtgrDonHang[0, i].Value = i + 1;
                }
                    AnHien(false);
            }
            setnull();
            TinhTongTien();
        }

        /// <summary>
        /// Tính tổng tiền của hóa đơn
        /// </summary>
        private void TinhTongTien()
        {
            int tong = 0, k;
            if (dtgrDonHang.Rows.Count == 0)
            {
                tong = 0;
            }
            else
            {
                for (int i = 0; i < dtgrDonHang.Rows.Count; i++)
                {
                    int.TryParse(dtgrDonHang[5, i].Value.ToString().Replace(",", ""), out k);
                    tong += k;
                }
            }
            txtTongTien.Text = string.Format("{0:0,0}", tong);
        }

        /// <summary>
        /// thành tiền của 1 loại hàng hóa
        /// </summary>
        private void tinhThanhTien()
        {
            int soluong = 0;
            int dongia = 0;
            try
            {
                int.TryParse(txtSoLuong.Text, out soluong);
                int.TryParse(txtDonGia.Text, out dongia);
                txtThanhTien.Text = string.Format("{0:0,0}",(soluong * dongia));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            tinhThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            tinhThanhTien();
        }

        private void dtgrDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            rowindex = e.RowIndex;
            DataGridViewRow row = dtgrDonHang.Rows[e.RowIndex];
            AnHien(true);
            try
            {
                cbbTenHH.Text = row.Cells[1].Value.ToString();
                txtDVT.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        /// <summary>
        /// thay đổi trạng thái ẩn hiện của button sửa và xóa
        /// </summary>
        /// <param name="isShow">giá trị bool</param>
        private void AnHien(bool isShow)
        {
            btSua.Enabled = btXoa.Enabled = isShow;
        }

        /// <summary>
        /// load danh sách khách hàng lên cbb
        /// </summary>
        private void loadKhachHang()
        {
            BSKhachHang bskhachhang = new BSKhachHang();
            List<KhachHang> list = bskhachhang.getAllKhachhang();
            list.Sort(new KhachhangNameComparer());
            cbbKhachHang.DataSource = list;
            cbbKhachHang.DisplayMember = "HoTen";
            cbbKhachHang.ValueMember = "MaKH";

            cbbKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void gelMaHD()
        {
            try
            {
                BSHoaDon bs = new BSHoaDon();
                List<HoaDon> ds = bs.getAllHoaDon();
                txtMaHD.Text = "#"+ds.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// lấy danh sách hàng hóa lên cbb
        /// </summary>
        private void loadHangHoa()
        {
            BSHangHoa bshanghoa = new BSHangHoa();
            List<HangHoa> list =bshanghoa.getAllHangHoa();
            list.Sort(new HangHoaNameComparer());
            cbbTenHH.DataSource = list;
            cbbTenHH.DisplayMember = "TENHH";
            cbbTenHH.ValueMember = "MaHH";
        }
        /// <summary>
        /// lấy danh sách nhân viên lên cbb
        /// </summary>
        private void loadNhanVien()
        {
            try
            {
                BSNhanVien bsnhanvien = new BSNhanVien();
                List<NhanVien> list = bsnhanvien.getAllNhanVien();
                list.Sort(new NhanVienNameComparer());
                cbbMaNV.DataSource = list;
                cbbMaNV.DisplayMember = "HoTen";
                cbbMaNV.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
        /// <summary>
        /// kiểm tra mã hóa đơn bán đã có trong cơ dữ liệu chưa
        /// </summary>
        /// <param name="mahd">Mã hóa đơn mới</param>
        /// <returns>int</returns>
        private int kiemtraMaHD(string mahd)
        {
            try
            {
                BSHoaDon bs = new BSHoaDon();
                List<HoaDon> ds = bs.getAllHoaDon();
                for (int i = 0; i < ds.Count; i++)
                {
                    if (mahd == ds[i].MaHD.ToString().Replace(" ",""))
                        return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 1;
        }
        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhachHang.SelectedValue == null)
                return;
            try
            {
               
                BSKhachHang bs = new BSKhachHang();
                List<KhachHang> ds = bs.getAllKhachhang();
                for (int i = 0; i < ds.Count; i++)
                {
                    if (cbbKhachHang.SelectedValue.ToString() == ds[i].MaKH.ToString())
                    {
                        txtSDT.Text = ds[i].SDT.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }

        }

        private void cbbTenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenHH.SelectedValue == null)
                return;
            try
            {
                BSHangHoa bs = new BSHangHoa();
                List<HangHoa> ds = bs.getAllHangHoa();
                for (int i = 0; i < ds.Count; i++)
                {
                    if (cbbTenHH.SelectedValue.ToString() == ds[i].MaHH.ToString())
                    {
                        txtDVT.Text = ds[i].DVT.ToString();
                        txtDonGia.Text = ds[i].GiaHH.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        /// <summary>
        /// kiểm tra hợp lệ trước khi thanh toán hóa đơn
        /// </summary>
        /// <returns>trả về 1 nếu hợp lệ</returns>
        private int kiemtra()
        {

            int tt;
            Int32.TryParse(txtTongTien.Text.Replace(",", ""), out tt);
            try
            {
                BSHangHoa bshanghoa = new BSHangHoa();
                List<HangHoa> list = bshanghoa.getAllHangHoa();
                int sl,p=0;
                Int32.TryParse(txtSoLuong.Text, out sl);
                for(int i=0;i<list.Count;i++){
                    if(cbbTenHH.SelectedValue.ToString()==list[i].MaHH.ToString())
                        p=list[i].Soluong;
                }
                if (sl > p)
                    MessageBox.Show("Số lượng hàng hóa còn lại không đủ!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (tt == 0)
            {
                MessageBox.Show("Hóa đơn chưa có hàng hóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Nhập sai mã hóa đơn!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
                
           
            return 1;
        }
        /// <summary>
        /// kiểm tra xem khách hàng này đã có trong danh sách chưa!
        /// </summary>
        /// <param name="makh">mã khách</param>
        /// <returns>int</returns>
        private int kiemtraKH(string makh)
        {
            for (int i = 0; i < cbbKhachHang.Items.Count; i++)
            {
                if (makh == cbbKhachHang.Items[i].ToString())
                    return -1;
            }
            if (chbKhachHang.Checked == true)
                return -1;

            if (chbKhachHang.Checked == false)
                return 1;
            return 1;
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (kiemtraMaHD(txtMaHD.Text) == -1)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại! Không thể thêm mới!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kiemtraKH(cbbKhachHang.Text) == -1)
            {
                txtSDT.Text = "";
                cbbKhachHang.Text = "";
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thêm mới khách hàng?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    BSKhachHang bs = new BSKhachHang();
                    List<KhachHang> ds = bs.getAllKhachhang();

                    KhachHang kh = new KhachHang();
                    kh.MaKH = "#NewKH" + ds.Count.ToString();
                    kh.HoTen = cbbKhachHang.Text;
                    kh.SDT = txtSDT.Text;
                    kh.SoDuTK = 0;
                    kh.SoNo = 0;
                    kh.DiaChi = "#";
                    bs.insertKhachHang(kh);
                }
                else
                    return;
            }
            if(kiemtra()==-1)
            {
                return;
            }
            try
            {
#region
                BSHoaDon bshd = new BSHoaDon();
                HoaDon hd = new HoaDon();
                hd.MaHD = txtMaHD.Text;
                hd.MaKH = cbbKhachHang.SelectedValue.ToString();
                hd.MaNV = cbbMaNV.SelectedValue.ToString();
                hd.NgayLap = dateNgayLapHD.Text;
                int k;
                Int32.TryParse(txtTongTien.Text.Replace(",", ""), out k);
                hd.TongTien = k;                
                bshd.insertHoaDon(hd);
                
#endregion
                BSChiTietHD bsct = new BSChiTietHD();
                ChiTietHoaDon ct = new ChiTietHoaDon();
                
                for (int i = 0; i < dtgrDonHang.Rows.Count; i++)
                {
                    int soluong, thanhtien, dongia;
                    DataGridViewRow row = dtgrDonHang.Rows[i];
                    chuanhoaMa(txtMaHD.Text);
                    ct.MaHD = txtMaHD.Text;
                    ct.MaHH=getMahh(row.Cells["TenHH"].Value.ToString());
                    try
                    {
                        Int32.TryParse(row.Cells["SoLuong"].Value.ToString(), out soluong);
                        ct.SoLuong = soluong;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhập sai số lượng");
                    }
                    Int32.TryParse(row.Cells["DONGIA"].Value.ToString(),out dongia);
                    Int32.TryParse(row.Cells["THANHTIEN"].Value.ToString().Replace(",",""), out thanhtien);                   
                    ct.ThanhTien = thanhtien;
                    ct.DonGia = dongia;
                    ct.DVT = row.Cells["DONVITINH"].Value.ToString();
                    bsct.insert_ChiTietHoaDon(ct);
                    //if ((MessageBox.Show("Bạn có muốn suất chi tiết hóa đơn ra file ExCel không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    //    Export_Excel.ExportDataGridViewTo_Excel12(dtgrDonHang);
                }
                for (int i = dtgrDonHang.Rows.Count; i > 0; i--)
                {
                    dtgrDonHang.Rows.RemoveAt(i - 1);
                }
                gelMaHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("khong them duocdj hóa don "+ex.Message);
            }
        }
        private string getMahh(string hh)
        {
            BSHangHoa bshanghoa = new BSHangHoa();
            List<HangHoa> list = bshanghoa.getAllHangHoa();
            for (int i = 0; i < list.Count; i++)
            {
                if (hh == list[i].TenHH.ToString())
                    hh = list[i].MaHH.ToString();
            }
            return hh;
        }
        private string chuanhoaMa(string str)
        {
            if(str.Length==15)
                return str;
            for (int i = str.Length; i < 15; i++)
            {
                str += " ";
            }
            return str;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == (MessageBox.Show("Bạn có chắc chắn hủy bỏ hóa đơn này?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)))
            {
                for (int i = dtgrDonHang.Rows.Count; i > 0; i--)
                {
                    dtgrDonHang.Rows.RemoveAt(i - 1);
                }
            }
        }

        private void chbKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKhachHang.Checked == true)
            {
                txtSDT.Text = "";
                cbbKhachHang.Text = "";
            }
        }

    }
}
