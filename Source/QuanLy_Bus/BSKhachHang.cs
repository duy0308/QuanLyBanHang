using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_Connector;
using QuanLy_Model;
using System.Data.SqlClient;
using System.Data;
using QuanLy_Model.Khachhang;

namespace QuanLy_Bus
{
    public class BSKhachHang
    {
        private Connector connect = null;
        public BSKhachHang()
        {
            connect = new Connector();
        }
        /// <summary>
        /// lay ra danh sach cac khach hang
        /// </summary>
        /// <returns>tra ve 1 bang khach hang</returns>
        public List<KhachHang> getAllKhachhang()
        {
            SqlDataAdapter adap = null;
            List<KhachHang> ds = null;
            try
            {              
                adap = connect.getData("KhachHang_Select");
                ds = new List<KhachHang>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = dt.Rows[i][0].ToString();
                    kh.HoTen = dt.Rows[i][1].ToString();
                    kh.DiaChi = dt.Rows[i][2].ToString();
                    kh.SDT = dt.Rows[i][3].ToString();
                    kh.SoDuTK = Int32.Parse(dt.Rows[i][4].ToString());
                    kh.SoNo = Int32.Parse(dt.Rows[i][5].ToString());
                    ds.Add(kh);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KhachHang> getKhachHangByID(string makh)
        {
            SqlDataAdapter adap = null;
            SqlCommand cmd = null;
            List<KhachHang> ds = null;
            try
            {
                cmd = connect.ExcuteNonQueryAll("KhachHang_SelectByID");
                cmd.Parameters.AddWithValue("@makh", makh);
                adap = new SqlDataAdapter(cmd);
                ds = new List<KhachHang>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = dt.Rows[i][0].ToString();
                    kh.HoTen = dt.Rows[i][1].ToString();
                    kh.DiaChi = dt.Rows[i][2].ToString();
                    kh.SDT = dt.Rows[i][3].ToString();
                    kh.SoDuTK = Int32.Parse(dt.Rows[i][4].ToString());
                    kh.SoNo = Int32.Parse(dt.Rows[i][5].ToString());
                    ds.Add(kh);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// thực hiện các thao tác với dữ liệu
        /// </summary>
        /// <param name="procname">tên thủ tục</param>
        /// <param name="kh">đối tượng khách hàng</param>
        public void excuteData(string procname, KhachHang kh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll(procname);
                cmd.Parameters.AddWithValue("@MAKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@HOTEN", kh.HoTen);
                cmd.Parameters.AddWithValue("@DIACHI", kh.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                cmd.Parameters.AddWithValue("@SoDuTK", kh.SoDuTK);
                cmd.Parameters.AddWithValue("@SoNo", kh.SoNo);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// thao tác thêm vào bảng khách hàng
        /// </summary>
        /// <param name="kh">đối tượng khách hàng</param>
        public void insertKhachHang(KhachHang kh)
        {
                //string sql = string.Format("insert into KHACHHANG values({0},N'{1}',N'{2}','{3}',{4},{5})", kh.MaKH, kh.HoTen, kh.DiaChi, kh.SDT, kh.SoDuTK, kh.SoNo);
                //return connect.ExcuteNonQuery(sql);
            excuteData("KhachHang_Insert", kh);      
        }
        /// <summary>
        /// cập nhật dữ liệu bảng khách hàng
        /// </summary>
        /// <param name="kh">tối tượng khách hàng</param>
        public void updateKhachHang(KhachHang kh)
        {            
            excuteData("KhachHang_Update", kh);
        }
        /// <summary>
        /// xóa dữ liệu bảng Khách hàng
        /// </summary>
        /// <param name="makh">đối tượng khách hàng</param>
        public void deleteKhachHang(string makh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("KhachHang_Delete");
                cmd.Parameters.AddWithValue("@MAKH", makh);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tra ve danh sach cac khach hang duoc tim kiem
        /// </summary>
        /// <param name="chuoitimkiem">chuoi tim kiem</param>
        public List<KhachHang> findKhachHang(int j,string chuoitimkiem)
        {
            string[] fiel1 = { "KhachHang_SelectByName", "KhachHang_SelectBySDT" };
            string[] fiel2 = { "@Hoten", "@SDT" };
            SqlDataAdapter adap = null;
            List<KhachHang> ds = null;
            try
            {
                adap = connect.getFindData(fiel1[j], fiel2[j],chuoitimkiem);
                ds = new List<KhachHang>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = dt.Rows[i][0].ToString();
                    kh.HoTen = dt.Rows[i][1].ToString();
                    kh.DiaChi = dt.Rows[i][2].ToString();
                    kh.SDT = dt.Rows[i][3].ToString();
                    kh.SoDuTK = Int32.Parse(dt.Rows[i][4].ToString());
                    kh.SoNo = Int32.Parse(dt.Rows[i][5].ToString());
                    ds.Add(kh);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KhachHang> searchKhachHang(KhachHang kh1)
        {
            SqlDataAdapter adap = null;
            List<KhachHang> ds = null;
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("KhachHang_Search");
                cmd.Parameters.AddWithValue("@hoten",kh1.HoTen);
                cmd.Parameters.AddWithValue("@diachi", kh1.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", kh1.SDT);
                cmd.Parameters.AddWithValue("@sodutk", kh1.SoDuTK);
                cmd.Parameters.AddWithValue("@sono", kh1.SoNo);
                cmd.ExecuteNonQuery();
                adap = new SqlDataAdapter(cmd);
                ds = new List<KhachHang>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = dt.Rows[i][0].ToString();
                    kh.HoTen = dt.Rows[i][1].ToString();
                    kh.DiaChi = dt.Rows[i]["DIACHI"].ToString();
                    kh.SDT = dt.Rows[i]["SDT"].ToString();
                    kh.SoDuTK = Int32.Parse(dt.Rows[i]["SODUTK"].ToString());
                    kh.SoNo = Int32.Parse(dt.Rows[i]["SONO"].ToString());
                    ds.Add(kh);
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", kh.MaKH, kh.HoTen, kh.DiaChi, kh.SDT, kh.SoDuTK, kh.SoNo);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KhachHangHD> getHDKhachHang()
        {
            try
            {
                SqlDataAdapter adap = connect.getData("KhachHang_MuaBan");
                List<KhachHangHD> ds = new List<KhachHangHD>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhachHangHD khhd = new KhachHangHD();
                    khhd.MaKH = dt.Rows[i][0].ToString();
                    khhd.HoTen = dt.Rows[i][1].ToString();
                    khhd.SLHD = Int32.Parse(dt.Rows[i][2].ToString());
                    khhd.SLMH = Int32.Parse(dt.Rows[i][3].ToString());
                    khhd.TongTien = Int32.Parse(dt.Rows[i][4].ToString());
                    ds.Add(khhd);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<HangHoaSL> getHHKhachHang(string makh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("KhachHang_ByHH");
                cmd.Parameters.AddWithValue("@makh", makh);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                List<HangHoaSL> ds = new List<HangHoaSL>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangHoaSL hh = new HangHoaSL();
                    hh.TenHH = dt.Rows[i][0].ToString();
                    hh.SLHH = Int32.Parse(dt.Rows[i][1].ToString());
                    ds.Add(hh);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
