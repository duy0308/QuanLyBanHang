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
    public class BSHangHoa
    {
        private Connector connect = null;
        public BSHangHoa()
        {
            connect = new Connector();
        }
        public List<HangHoa> getAllHangHoa()
        {
            SqlDataAdapter adap = null;
            List<HangHoa> ds = null;
            try
            {
                adap = connect.getData("HangHoa_SelectAll");
                ds = new List<HangHoa>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangHoa hh = new HangHoa();
                    hh.MaHH = dt.Rows[i][0].ToString();
                    hh.TenHH = dt.Rows[i][1].ToString();
                    hh.Soluong = Int32.Parse(dt.Rows[i][2].ToString());
                    hh.GiaHH = Int32.Parse(dt.Rows[i][3].ToString());
                    hh.DVT = dt.Rows[i][4].ToString();
                    hh.NSX = dt.Rows[i][5].ToString();
                    hh.HSD = dt.Rows[i][6].ToString();
                    hh.MaGH = dt.Rows[i][7].ToString();
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
        public bool insertHangHoa(HangHoa hh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("HangHoa_Insert");
                cmd.Parameters.AddWithValue("@MAHH", hh.MaHH);
                cmd.Parameters.AddWithValue("@TENHH", hh.TenHH);
                cmd.Parameters.AddWithValue("@SOLUONG", hh.Soluong);
                cmd.Parameters.AddWithValue("@GIAHH", hh.GiaHH);
                cmd.Parameters.AddWithValue("@DONVITINH", hh.DVT);
                cmd.Parameters.AddWithValue("@NSX", hh.NSX);
                cmd.Parameters.AddWithValue("@HSD", hh.HSD);
                cmd.Parameters.AddWithValue("@MAGH", hh.MaGH);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool updateHangHoa(HangHoa hh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("HangHoa_Update");
                cmd.Parameters.AddWithValue("@MAHH", hh.MaHH);
                cmd.Parameters.AddWithValue("@TENHH", hh.TenHH);
                cmd.Parameters.AddWithValue("@SOLUONG", hh.Soluong);
                cmd.Parameters.AddWithValue("@GIAHH", hh.GiaHH);
                cmd.Parameters.AddWithValue("@DONVITINH", hh.DVT);
                cmd.Parameters.AddWithValue("@NSX", hh.NSX);
                cmd.Parameters.AddWithValue("@HSD", hh.HSD);
                cmd.Parameters.AddWithValue("@MAGH", hh.MaGH);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool deleteHangHoa(string hh)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("HangHoa_Delete");
                cmd.Parameters.AddWithValue("@MAHH", hh);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<HangHoa> getHangHoaMax()
        {
            try
            {
                SqlDataAdapter adap = connect.getData("HangHoa_SelectBySlmua");
                List<HangHoa> ds = new List<HangHoa>();
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    HangHoa hh = new HangHoa();
                    hh.MaHH = dt.Rows[i][0].ToString();
                    hh.TenHH = dt.Rows[i][1].ToString();
                    hh.Soluong = Int32.Parse(dt.Rows[i][2].ToString());
                    hh.DVT = dt.Rows[i][3].ToString();
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
