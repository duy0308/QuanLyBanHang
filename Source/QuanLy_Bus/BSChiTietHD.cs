using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_Connector;
using QuanLy_Model;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy_Bus
{
    public class BSChiTietHD
    {
        private Connector connect = null;
        public BSChiTietHD()
        {
            connect = new Connector();
        }
        public List<ChiTietHoaDon> getChiTietByID(string MaHD)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("ChiTietHD_SelectByID");
                cmd.Parameters.AddWithValue("@Ma", MaHD);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                List<ChiTietHoaDon> ds = new List<ChiTietHoaDon>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChiTietHoaDon ct = new ChiTietHoaDon();
                    ct.MaHD = dt.Rows[i]["MAHD"].ToString();
                    ct.MaHH = dt.Rows[i]["MAHH"].ToString();
                    ct.SoLuong = Int32.Parse(dt.Rows[i]["SOLUONG"].ToString());
                    ct.DVT = dt.Rows[i]["DONVITINH"].ToString();
                    ct.DonGia = Int32.Parse(dt.Rows[i]["DONGIA"].ToString());
                    ct.ThanhTien = Int32.Parse(dt.Rows[i]["THANHTIEN"].ToString());
                    ds.Add(ct);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void insert_ChiTietHoaDon(ChiTietHoaDon ct)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("ChiTietHD_Insert");
                cmd.Parameters.AddWithValue("@MAHD", ct.MaHD);
                cmd.Parameters.AddWithValue("@MaHH", ct.MaHH);
                cmd.Parameters.AddWithValue("@SOLUONG", ct.SoLuong);
                cmd.Parameters.AddWithValue("@DONVITINH", ct.DVT);
                cmd.Parameters.AddWithValue("@DONGIA", ct.DonGia);
                cmd.Parameters.AddWithValue("@THANHTIEN", ct.ThanhTien);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
    //                @MaHD nchar(10),
    //@tenhh nchar(50),
    //@SOLUONG int,
    //@DONVITINH nchar(10),
    //@DONGIA int,
    //@THANHTIEN int

                throw ex;
            }
        }
    }
}
