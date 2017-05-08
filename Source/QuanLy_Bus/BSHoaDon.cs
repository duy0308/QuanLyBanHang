using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_Model;
using QuanLy_Connector;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy_Bus
{
    public class BSHoaDon
    {
        private Connector connect = null;
        public BSHoaDon()
        {
            connect = new Connector();
        }
        public List<HoaDon> getAllHoaDon()
        {
            try
            {
                List<HoaDon> ds = new List<HoaDon>();
                SqlDataAdapter adap = connect.getData("HoaDon_Select");
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHD = dt.Rows[i]["MaHD"].ToString();
                    hd.MaKH = dt.Rows[i]["MaKH"].ToString();
                    hd.MaNV = dt.Rows[i]["MaNV"].ToString();
                    hd.NgayLap = dt.Rows[i]["NgayLap"].ToString();
                    hd.TongTien = Int32.Parse(dt.Rows[i]["TongTien"].ToString());
                    ds.Add(hd);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<HoaDon> getHoaDonByID(string makh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("HoaDon_SelectByID");
                cmd.Parameters.AddWithValue("@makh", makh);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                List<HoaDon> ds = new List<HoaDon>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHD = dt.Rows[i]["MaHD"].ToString();
                    hd.MaKH = dt.Rows[i]["MaKH"].ToString();
                    hd.MaNV = dt.Rows[i]["MaNV"].ToString();
                    hd.NgayLap = dt.Rows[i]["NgayLap"].ToString();
                    hd.TongTien = Int32.Parse(dt.Rows[i]["TongTien"].ToString());
                    ds.Add(hd);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void insertHoaDon(HoaDon hd)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("HoaDon_Insert");
                cmd.Parameters.AddWithValue("@MAHD", hd.MaHD);
                cmd.Parameters.AddWithValue("@NGAYLAP", hd.NgayLap);
                cmd.Parameters.AddWithValue("@TONGTIEN", hd.TongTien);
                cmd.Parameters.AddWithValue("@MANV", hd.MaNV);
                cmd.Parameters.AddWithValue("@MAKH", hd.MaKH);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
