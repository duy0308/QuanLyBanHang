using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.FormUser
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void IsShow(bool show)
        {
            this.cbbTenDangNhap.Visible = this.btnAdd.Enabled = show;
            this.btnSave.Visible = this.txtTenDangNhap.Visible = !show;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            IsShow(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IsShow(true); 
        }

    }
}
