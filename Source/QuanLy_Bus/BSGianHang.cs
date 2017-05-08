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
    public class BSGianHang
    {
        private Connector connect = null;
        public BSGianHang()
        {
            connect = new Connector();
        }
        public List<GianHang> readdata()
        {
            SqlDataReader read = null;
            List<GianHang> list = null;
            try
            {
                read = connect.readData("GianHang_Select");
                while (read.Read())
                {
                    GianHang gh = new GianHang();
                    gh.MaGH = read.GetString(0);
                    gh.TenGH = read.GetString(1);
                    gh.ViTri = read.GetString(2);
                    gh.MaNQL = read.GetString(3);
                    list.Add(gh);                    
                }
                connect.CloseConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
            return list;
        }
        public List<GianHang> getGianHang()
        {
            SqlDataAdapter adap = null;
            List<GianHang> list = null;
            try
            {
                adap = connect.getData("GianHang_Select");
                DataTable dt = new DataTable();
                list = new List<GianHang>();
                adap.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GianHang gh = new GianHang();
                    gh.MaGH = dt.Rows[i][0].ToString();
                    gh.MaNQL = dt.Rows[i][3].ToString();
                    gh.ViTri = dt.Rows[i][2].ToString();
                    gh.TenGH = dt.Rows[i][1].ToString();
                    list.Add(gh);
                }
                connect.CloseConnect();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
