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
    public class BSDoanhThu
    {
        private Connector connect = null;
        public BSDoanhThu()
        {
            connect = new Connector();
        }
        public List<DoanhThu> getDoanhThu(string thang, string nam)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("DoanhThu_Thang");
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                List<DoanhThu> ds = new List<DoanhThu>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DoanhThu dn = new DoanhThu();
                    dn.tongtien = Int32.Parse(dt.Rows[i][0].ToString());
                    dn.thang = dt.Rows[i][1].ToString();
                    dn.nam = dt.Rows[i][2].ToString();
                    ds.Add(dn);
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
