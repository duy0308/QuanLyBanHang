using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_Model;
using QuanLy_Connector;
using System.Data.SqlClient;
using System.Data;
using QuanLy_Model.Nhanvien;

namespace QuanLy_Bus
{
    public class BSNhanVien
    {
        private Connector connect = null;
        public BSNhanVien()
        {
            connect = new Connector();
        }
        public List<NhanVien> getAllNhanVien()
        {
            try
            {
                SqlDataAdapter adap = connect.getData("NhanVien_Select");
                List<NhanVien> ds = new List<NhanVien>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = dt.Rows[i][0].ToString();
                    nv.HoTen = dt.Rows[i][1].ToString();
                    nv.NgaySinh = dt.Rows[i][2].ToString();
                    nv.GioiTinh = dt.Rows[i][3].ToString();
                    nv.QueQuan = dt.Rows[i][4].ToString();
                    nv.SDT = dt.Rows[i][5].ToString();
                    nv.Luong = Int32.Parse(dt.Rows[i][6].ToString());
                    nv.MaNQL = dt.Rows[i][7].ToString();
                    nv.MaGH = dt.Rows[i][8].ToString();
                    ds.Add(nv);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhanVien> getAllNhanVienByID(string mskh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("NhanVien_SelectByID");
                cmd.Parameters.AddWithValue("@manv", mskh);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                List<NhanVien> ds = new List<NhanVien>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = dt.Rows[i][0].ToString();
                    nv.HoTen = dt.Rows[i][1].ToString();
                    nv.NgaySinh = dt.Rows[i][2].ToString();
                    nv.GioiTinh = dt.Rows[i][3].ToString();
                    nv.QueQuan = dt.Rows[i][4].ToString();
                    nv.SDT = dt.Rows[i][5].ToString();
                    nv.Luong = Int32.Parse(dt.Rows[i][6].ToString());
                    nv.MaNQL = dt.Rows[i][7].ToString();
                    nv.MaGH = dt.Rows[i][8].ToString();
                    ds.Add(nv);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhanVien> getAllNhanVie()
        {
            SqlDataReader read = null;
            List<NhanVien> ds = null;
            try
            {
                read = connect.readData("NhanVien_Select");
                while (read.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = read.GetString(0);
                    nv.HoTen = read.GetString(1);
                    nv.NgaySinh = read.GetString(2).ToString();
                    nv.GioiTinh = read.GetString(3);
                    nv.QueQuan = read.GetString(4);
                    nv.SDT = read.GetString(5);
                    nv.Luong = Int32.Parse(read.GetString(6));
                    nv.MaNQL = read.GetString(7);
                    nv.MaGH = read.GetString(8);
                    ds.Add(nv);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool insertNhanVien(NhanVien nv)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("NhanVien_Insert");
                cmd.Parameters.AddWithValue("@manv", nv.MaNV);
                cmd.Parameters.AddWithValue("@tennv", nv.HoTen);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@quequan", nv.QueQuan);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@luong", nv.Luong);
                cmd.Parameters.AddWithValue("@manql", nv.MaNQL);
                cmd.Parameters.AddWithValue("@magh", nv.MaGH);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool updateNhanVien(NhanVien nv)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("NhanVien_Update");
                cmd.Parameters.AddWithValue("@manv", nv.MaNV);
                cmd.Parameters.AddWithValue("@tennv", nv.HoTen);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@quequan", nv.QueQuan);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@luong", nv.Luong);
                cmd.Parameters.AddWithValue("@manql", nv.MaNQL);
                cmd.Parameters.AddWithValue("@magh", nv.MaGH);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool deleteNhanVien(string manv)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("NhanVien_Del");
                cmd.Parameters.AddWithValue("@MANV", manv);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public List<NhanVienLV> getNhanVienLV()
        {
            try
            {
                SqlDataAdapter adap = connect.getData("NhanVien_LamViec");
                List<NhanVienLV> ds = new List<NhanVienLV>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVienLV nvlv = new NhanVienLV();
                    nvlv.MaNV = dt.Rows[i][0].ToString();
                    nvlv.TenNV = dt.Rows[i][1].ToString();
                    nvlv.SLHD = Int32.Parse(dt.Rows[i][2].ToString());
                    nvlv.TongTien = Int32.Parse(dt.Rows[i][3].ToString());
                    ds.Add(nvlv);
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
