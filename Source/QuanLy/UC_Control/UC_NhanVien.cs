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


using System.Data.Odbc;
using Office_12 = Microsoft.Office.Core;
using Excel_12 = Microsoft.Office.Interop.Excel;

namespace QuanLy.UC_Control
{
    public partial class UC_NhanVien : UserControl
    {

        public static void ExportDataGridViewTo_Excel12(DataGridView myDataGridViewQuantity)
        {

            Excel_12.Application oExcel_12 = null; //Excel_12 Application 

            Excel_12.Workbook oBook = null; // Excel_12 Workbook 

            Excel_12.Sheets oSheetsColl = null; // Excel_12 Worksheets collection 

            Excel_12.Worksheet oSheet = null; // Excel_12 Worksheet 

            Excel_12.Range oRange = null; // Cell or Range in worksheet 

            Object oMissing = System.Reflection.Missing.Value;


            // Create an instance of Excel_12. 

            oExcel_12 = new Excel_12.Application();


            // Make Excel_12 visible to the user. 

            oExcel_12.Visible = true;


            // Set the UserControl property so Excel_12 won't shut down. 

            oExcel_12.UserControl = true;

            // System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US"); 

            //object file = File_Name;

            //object missing = System.Reflection.Missing.Value;



            // Add a workbook. 

            oBook = oExcel_12.Workbooks.Add(oMissing);

            // Get worksheets collection 

            oSheetsColl = oExcel_12.Worksheets;

            // Get Worksheet "Sheet1" 

            oSheet = (Excel_12.Worksheet)oSheetsColl.get_Item("Sheet1");
            oSheet.Name = "ChamCong";




            // Export titles 

            for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
            {

                oRange = (Excel_12.Range)oSheet.Cells[1, j + 1];

                oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

            }

            // Export data 

            for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
            {

                for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                {
                    oRange = (Excel_12.Range)oSheet.Cells[i + 2, j + 1];

                    oRange.Value2 = myDataGridViewQuantity[j, i].Value.ToString();

                }

            }
            oBook = null;
            oExcel_12.Quit();
            oExcel_12 = null;
            GC.Collect();
        }

        private int rowindex;
        public UC_NhanVien()
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
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
            loadGH();
            setGT();
            AnHien(false);
        }
        private void loadNV()
        {
            try
            {
                BSNhanVien bs = new BSNhanVien();
                List<NhanVien> ds = bs.getAllNhanVien();
                //load mã nhân viên lên cbbMaNV
                cbbMaNV.DataSource = ds;
                cbbMaNV.ValueMember = "MANV";
                cbbMaNV.DisplayMember = "MANV";

                cbbMaNV.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbMaNV.AutoCompleteSource = AutoCompleteSource.ListItems;

                //load họ tên lên cbbTenNV
                cbbTenNV.DataSource = ds;
                cbbTenNV.ValueMember = "MANV";
                cbbTenNV.DisplayMember = "HOTEN";
                cbbTenNV.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbTenNV.AutoCompleteSource = AutoCompleteSource.ListItems;

                //load mã người quản lý
                cbbMaNQL.DataSource = ds;
                cbbMaNQL.ValueMember = "MANQL";
                cbbMaNQL.DisplayMember = "MANQL";
                cbbMaNQL.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbMaNQL.AutoCompleteSource = AutoCompleteSource.ListItems;

                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrNhanVien.Rows.Add(i + 1, ds[i].MaNV.ToString(), ds[i].HoTen.ToString(), ds[i].NgaySinh.ToString(), ds[i].GioiTinh.ToString(), ds[i].QueQuan.ToString(), ds[i].SDT.ToString(), ds[i].Luong.ToString(), ds[i].MaNQL, ds[i].MaGH.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình load dữ liệu nhân viên bị lỗi!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void loadGH()
        {
            try
            {
                BSGianHang bs = new BSGianHang();
                List<GianHang> ds = bs.getGianHang();
                cbbMaGH.DataSource = ds;
                cbbMaGH.ValueMember = "MAGH";
                cbbMaGH.DisplayMember = "MAGH";
                cbbMaGH.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbMaGH.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load tên gian hàng: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setGT()
        {
            BSNhanVien bs = new BSNhanVien();
            List<NhanVien> ds = bs.getAllNhanVien();
            for (int i = 0; i < ds.Count; i++)
            {
                if (cbbTenNV.Text == ds[i].HoTen||cbbMaNV.Text==ds[i].MaNV)
                {
                    cbbGioiTinh.Text = ds[i].GioiTinh.ToString();
                    txtLuong.Text = ds[i].Luong.ToString();
                    txtQueQuan.Text = ds[i].QueQuan.ToString();
                    txtSDT.Text = ds[i].SDT.ToString();
                    dateNgaySinh.Text = ds[i].NgaySinh;
                    cbbMaGH.Text = ds[i].MaGH;
                }
            }
        }
        private void dtgrNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            rowindex = e.RowIndex;
            
            cbbMaNV.Text = dtgrNhanVien.Rows[rowindex].Cells[1].Value.ToString();
            cbbMaGH.Text = dtgrNhanVien.Rows[rowindex].Cells[9].Value.ToString();
            AnHien(true);
        }
        private void AnHien(bool ishow)
        {
           btSua.Enabled = btXoa.Enabled = ishow;
        }
        private int kiemtraMaNV(string manv)
        {
            if (manv.Replace(" ", "") == "")
                return -2;
            for (int i = 0; i < dtgrNhanVien.Rows.Count; i++)
            {
                if (manv == dtgrNhanVien.Rows[i].Cells[0].Value.ToString().Replace(" ", ""))
                {
                    return -1;
                }
            }
            return 1;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (kiemtraMaNV(cbbMaNV.Text) == -1)
            {
                MessageBox.Show("Nhân viên đã tồn tại! Không thể thêm mới!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kiemtraMaNV(cbbMaNV.Text) == -2)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVien nv = new NhanVien();
            try
            {
                BSNhanVien bs = new BSNhanVien();
                nv.MaNV = cbbMaNV.Text;
                nv.HoTen = cbbTenNV.Text;
                nv.NgaySinh = dateNgaySinh.Text;
                nv.SDT = txtSDT.Text;
                nv.QueQuan = txtQueQuan.Text;
                nv.GioiTinh = cbbGioiTinh.Text;
                nv.MaNQL = cbbMaNQL.Text;
                nv.MaGH = cbbMaGH.Text;
                try
                {
                    nv.Luong = Int32.Parse(txtLuong.Text);
                }
                catch (Exception ax)
                {
                    MessageBox.Show("Lương không thể có kí tự chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                if(bs.insertNhanVien(nv)==true)
                {
                    dtgrNhanVien.Rows.Add(dtgrNhanVien.Rows.Count, nv.MaNV, nv.HoTen, nv.NgaySinh, nv.SDT, nv.QueQuan,nv.GioiTinh,nv.Luong, nv.MaNQL, nv.MaGH);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int kiemtraeditMaNV(string manv)
        {
            for (int i = 0; i < dtgrNhanVien.Rows.Count; i++)
            {
                if (manv == dtgrNhanVien.Rows[i].Cells[0].Value.ToString().Replace(" ", ""))
                {
                    return -1;
                }
            }
            return 1;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (rowindex == -1)
            {
                setNull();
                return;
            }
            if (kiemtraeditMaNV(cbbMaNV.Text) == -1)
            {
                setNull();
                MessageBox.Show("Nhân viên không tồn tại! Không thể sửa thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVien nv = new NhanVien();
            try
            {
                BSNhanVien bs = new BSNhanVien();
                nv.MaNV = cbbMaNV.Text;
                nv.HoTen = cbbTenNV.Text;
                nv.NgaySinh = dateNgaySinh.Text;
                nv.SDT = txtSDT.Text;
                nv.QueQuan = txtQueQuan.Text;
                nv.GioiTinh = cbbGioiTinh.Text;
                nv.MaNQL = cbbMaNQL.Text;
                nv.MaGH = cbbMaGH.Text;
                try
                {
                    nv.Luong = Int32.Parse(txtLuong.Text);
                }
                catch (Exception ax)
                {
                    MessageBox.Show("Lương không thể có kí tự chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                if(bs.updateNhanVien(nv)==true)
                {
                    DataGridViewRow row = dtgrNhanVien.Rows[rowindex];
                    row.Cells[1].Value = nv.MaNV;
                    row.Cells[2].Value = nv.HoTen;
                    row.Cells[3].Value = nv.NgaySinh;
                    row.Cells[4].Value = nv.GioiTinh;
                    row.Cells[5].Value = nv.QueQuan;
                    row.Cells[6].Value = nv.SDT;
                    row.Cells[7].Value = nv.Luong;
                    row.Cells[8].Value = nv.MaNQL;
                    row.Cells[9].Value = nv.MaGH;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AnHien(false);
        }

        private void UC_NhanVien_DoubleClick(object sender, EventArgs e)
        {
            setNull();
            AnHien(false);
        }
        private void setNull()
        {
            cbbMaNV.Text = "";
            cbbTenNV.Text = "";
            cbbMaNQL.Text = "";
            cbbMaGH.Text = "";
            cbbGioiTinh.Text = "";
            txtLuong.Text = "0";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
        }
        private void textChange_Ma_Ten(object sender, EventArgs e)
        {
            setGT();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (rowindex == -1)
            {
                setNull();
                return;
            }
            try
            {
                BSNhanVien bs = new BSNhanVien();
                
                if (bs.deleteNhanVien(cbbMaNV.Text) == true)
                {
                    dtgrNhanVien.Rows.RemoveAt(rowindex);
                    AnHien(false);
                    for (int i = rowindex; i < dtgrNhanVien.Rows.Count; i++)
                    {
                        int c;
                        string s1 = dtgrNhanVien[0, i].Value.ToString();
                        int.TryParse(s1, out c);
                        c = c - 1;
                        dtgrNhanVien[0, i].Value = c;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            setNull();
            AnHien(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDataGridViewTo_Excel12(dtgrNhanVien);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
