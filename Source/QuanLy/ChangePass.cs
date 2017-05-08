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

namespace QuanLy
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        private void kiemtra()
        {
            BSUser bs = new BSUser();
            string id = frmLogIn.getMa();
            User us = bs.GetUserID(id);
            if (us != null)
            {
                if (us.pass.Trim() == txtOldPass.Text.Trim())
                {
                    if (this.txtNewPass.Text.Trim() == this.txtComfirmPass.Text.Trim())
                    {
                        us.pass = this.txtNewPass.Text.Trim();
                        bs.UpdateUser(us);
                        MessageBox.Show("Change Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mat khau moi chua khop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    this.Hide();
                    return;
                }
            }
        }
        private void btnXacNhanThayDoi_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn chắc chắn thay sự thay đổi?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                kiemtra();
            }
        }
    }
}
