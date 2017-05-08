namespace QuanLy
{
    partial class frmLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconLog = new System.Windows.Forms.PictureBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtPassLogIn = new System.Windows.Forms.TextBox();
            this.txtLogIn = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(145, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phần mềm quản lý bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.iconLog);
            this.groupBox1.Controls.Add(this.lbstatus);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.txtPassLogIn);
            this.groupBox1.Controls.Add(this.txtLogIn);
            this.groupBox1.Location = new System.Drawing.Point(35, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 157);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // iconLog
            // 
            this.iconLog.Image = ((System.Drawing.Image)(resources.GetObject("iconLog.Image")));
            this.iconLog.Location = new System.Drawing.Point(47, 19);
            this.iconLog.Name = "iconLog";
            this.iconLog.Size = new System.Drawing.Size(122, 125);
            this.iconLog.TabIndex = 15;
            this.iconLog.TabStop = false;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(246, 138);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(0, 13);
            this.lbstatus.TabIndex = 14;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(178, 98);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 10;
            this.labelPass.Text = "Mật Khẩu";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(175, 54);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(56, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Tài Khoản";
            // 
            // txtPassLogIn
            // 
            this.txtPassLogIn.Location = new System.Drawing.Point(255, 95);
            this.txtPassLogIn.Name = "txtPassLogIn";
            this.txtPassLogIn.PasswordChar = '*';
            this.txtPassLogIn.Size = new System.Drawing.Size(220, 20);
            this.txtPassLogIn.TabIndex = 11;
            // 
            // txtLogIn
            // 
            this.txtLogIn.Location = new System.Drawing.Point(255, 47);
            this.txtLogIn.Name = "txtLogIn";
            this.txtLogIn.Size = new System.Drawing.Size(220, 20);
            this.txtLogIn.TabIndex = 9;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(443, 271);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(111, 24);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btlog
            // 
            this.btlog.BackColor = System.Drawing.Color.Transparent;
            this.btlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlog.Location = new System.Drawing.Point(171, 271);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(111, 24);
            this.btlog.TabIndex = 11;
            this.btlog.Text = "Đăng Nhập";
            this.btlog.UseVisualStyleBackColor = false;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Transparent;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(306, 271);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(111, 24);
            this.btReset.TabIndex = 12;
            this.btReset.Text = "Nhập Lại";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.Location = new System.Drawing.Point(0, 304);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(588, 22);
            this.lblstatus.TabIndex = 16;
            this.lblstatus.Text = "statusStrip1";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(588, 326);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btlog);
            this.Controls.Add(this.btReset);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(604, 365);
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox iconLog;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtPassLogIn;
        private System.Windows.Forms.TextBox txtLogIn;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.StatusStrip lblstatus;
    }
}