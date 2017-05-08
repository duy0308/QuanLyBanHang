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
    public class BSUser
    {
        private Connector connect = null;
        public BSUser()
        {
            connect = new Connector();
        }
        public User GetUserID(string id)
        {
            SqlDataAdapter adap = null;
            SqlCommand cmd = null;
            User us = new User();
            try
            {
                cmd = connect.ExcuteNonQueryAll("UserByID");
                cmd.Parameters.AddWithValue("@MaNV", id);
                adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                us.MaNV = dt.Rows[0][0].ToString();
                us.tendangnhap = dt.Rows[0][1].ToString();
                us.pass = dt.Rows[0][2].ToString();
                us.chucvu = dt.Rows[0][3].ToString();
                return us;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateUser(User us)
        {
            try
            {
                SqlCommand cmd = connect.ExcuteNonQueryAll("User_Update");
                cmd.Parameters.AddWithValue("@MANV", us.MaNV);
                cmd.Parameters.AddWithValue("@pass",us.pass);
                cmd.Parameters.AddWithValue("@chucnang", us.chucvu);
                cmd.ExecuteNonQuery();
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<User> getUser()
        {
            SqlDataAdapter adap = null;
            List<User> ds = new List<User>();
            try
            {
                adap = connect.getData("User_Select");
                DataTable dt = new DataTable();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    User us = new User();
                    us.MaNV = dt.Rows[i][0].ToString();
                    us.tendangnhap = dt.Rows[i][1].ToString();
                    us.pass = dt.Rows[i][2].ToString();
                    us.chucvu = dt.Rows[i][3].ToString();
                    ds.Add(us);
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
