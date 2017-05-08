using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_Bus;
using QuanLy_Model;

namespace QuanLy
{
    public partial class frmLogIn : Form
    {
        private static int indexlog = 0;
        private static string MaNV;

        public static int IndexLog()
        {
            return indexlog;
        }
        public frmLogIn()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private int kiemtra(string ten, string pass)
        {
            try
            {
                BSUser bs = new BSUser();
                List<User> ds = bs.getUser();
                for (int i = 0; i < ds.Count; i++)
                {
                    if (txtLogIn.Text == ds[i].tendangnhap.ToString().Replace(" ", "") && txtPassLogIn.Text == ds[i].pass.ToString().Replace(" ", ""))
                    {
                        if (ds[i].chucvu.ToString().Replace(" ", "") == "1")
                        {
                            MaNV = ds[i].MaNV;
                            return 1;
                        }
                        else if (ds[i].chucvu.ToString().Replace(" ", "") == "0")
                        {
                            MaNV = ds[i].MaNV;
                            return 2;
                        }
                        else if (ds[i].chucvu.ToString().Replace(" ", "") == "GT")
                        {
                            MaNV = ds[i].MaNV;
                            return 4;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        public static string getMa()
        {
            return MaNV;
        }
        private void ShowForm()
        {
            Form f = new frmMain();
            f.FormClosed += f_FormClosed;
            f.Show();
            this.Hide();
        }
        private void btlog_Click(object sender, EventArgs e)
        {
            if (txtLogIn.TextLength == 0 || txtPassLogIn.TextLength == 0)
            {
                this.lbstatus.ForeColor = Color.Red;
                this.lbstatus.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
                return;
            }
            else
            {
                if (kiemtra(txtLogIn.Text, txtPassLogIn.Text) == 1)
                {
                    indexlog = 1;
                    ShowForm();
                    ClearText();
                    return;
                }
                else if (kiemtra(txtLogIn.Text, txtPassLogIn.Text) == -1)
                {
                    this.lbstatus.ForeColor = Color.Red;
                    this.lbstatus.Text = "Sai tên đăng nhập hoặc mật khẩu";
                    return;
                }
                else if (kiemtra(txtLogIn.Text, txtPassLogIn.Text) == 2)
                {
                    indexlog = 2;
                    ClearText();
                    ShowForm();
                    return;
                }
            }
        }
        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            this.txtLogIn.Clear();
            this.txtPassLogIn.Clear();
            this.txtLogIn.Focus();
            this.lbstatus.ResetText();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

    }
}