using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Connector
{
    public class Connector
    {
        private string strconnect = @"Data Source=DUY-PC;Initial Catalog=QLBH;User ID=sa;Password=admin@123";
        private SqlCommand cmd = null;
        private SqlDataAdapter adap = null;
        private SqlDataReader read = null;
        private SqlConnection conn = null;
        public Connector()
        {
            conn = new SqlConnection(strconnect);
        }
        public void OpenConnect()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CloseConnect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// lay ra du lieu cua 1 bang bat ki
        /// </summary>
        /// <param name="procname">ten thu tuc</param>
        /// <returns>tra ve SqlDataAdapter</returns>
        public SqlDataAdapter getData(string procname)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand();
                cmd.CommandText = procname;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new SqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                throw ex;             
            }
            return adap;
        }
        public SqlDataReader readData(string procname)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand();
                cmd.CommandText = procname;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                read = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return read;
        }
        /// <summary>
        /// tim kiem thong tin 1 bang
        /// </summary>
        /// <param name="procname">ten thu tuc</param>
        /// <param name="bien">parameters truyền vào cho thủ tục</param>
        /// <param name="chuoi">chuỗi tìm kiếm</param>
        /// <returns>Đối tượng SqlDataAdapter</returns>
        public SqlDataAdapter getFindData(string procname,string bien, string chuoi)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand();
                cmd.CommandText = procname;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(bien,chuoi);
                cmd.ExecuteNonQuery();
                adap = new SqlDataAdapter(cmd);
                return adap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// thao tác với các bảng qua các câu lệnh sql
        /// </summary>
        /// <param name="sql">chuỗi câu lệnh sql</param>
        /// <returns>chuỗi sql</returns>
        public string ExcuteNonQuery(string sql)
        {
            try
            {
                this.OpenConnect();
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return "true";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// thao tác với các bảng thông qua thủ tục
        /// </summary>
        /// <param name="procname">tên thủ tục</param>
        /// <returns>đối tượng SqlCommand</returns>
        public SqlCommand ExcuteNonQueryAll(string procname)
        {
            try
            {
                this.OpenConnect();
                string strName = procname;
                cmd = new SqlCommand(procname, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}