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
    public class BSDoanhThuNgay
    {
        private Connector connect = null;
        public BSDoanhThuNgay()
        {
            connect = new Connector();
        }
        public List<DoanhThuNgay> getDoanhThu(string thang, string nam)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("DoanhThu_Ngay");
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                List<DoanhThuNgay> ds = new List<DoanhThuNgay>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DoanhThuNgay dnn = new DoanhThuNgay();
                    dnn.tongtien = Int32.Parse(dt.Rows[i][0].ToString());
                    dnn.ngay = dt.Rows[i][1].ToString();
                    dnn.thang = dt.Rows[i][2].ToString();
                    dnn.nam = dt.Rows[i][3].ToString();
                    ds.Add(dnn);
                }
                connect.CloseConnect();
                return ds;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
