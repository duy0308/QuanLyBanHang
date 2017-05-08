using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_Bus;
using QuanLy_Model;

namespace QuanLy.FormDetailHangHoa
{
    public partial class frmHangHoaSL : Form
    {
        public frmHangHoaSL()
        {
            InitializeComponent();
        }

        private void frmHangHoaSL_Load(object sender, EventArgs e)
        {
            try
            {
                BSHangHoa bs = new BSHangHoa();
                List<HangHoa> ds = bs.getHangHoaMax();
                for (int i = 0; i < ds.Count; i++)
                {
                    dtgrThongKeHH.Rows.Add(i + 1, ds[i].MaHH, ds[i].TenHH, ds[i].Soluong, ds[i].DVT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
