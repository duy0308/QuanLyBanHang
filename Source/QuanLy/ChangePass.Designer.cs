namespace QuanLy
{
    partial class ChangePass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtComfirmPass = new System.Windows.Forms.TextBox();
            this.btnXacNhanThayDoi = new System.Windows.Forms.Button();
            this.btnHuyThayDoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyThayDoi);
            this.panel1.Controls.Add(this.btnXacNhanThayDoi);
            this.panel1.Controls.Add(this.txtComfirmPass);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtOldPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 186);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận lại";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(156, 23);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(228, 20);
            this.txtOldPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(156, 67);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(228, 20);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtComfirmPass
            // 
            this.txtComfirmPass.Location = new System.Drawing.Point(156, 111);
            this.txtComfirmPass.Name = "txtComfirmPass";
            this.txtComfirmPass.Size = new System.Drawing.Size(228, 20);
            this.txtComfirmPass.TabIndex = 5;
            // 
            // btnXacNhanThayDoi
            // 
            this.btnXacNhanThayDoi.Location = new System.Drawing.Point(212, 141);
            this.btnXacNhanThayDoi.Name = "btnXacNhanThayDoi";
            this.btnXacNhanThayDoi.Size = new System.Drawing.Size(78, 35);
            this.btnXacNhanThayDoi.TabIndex = 6;
            this.btnXacNhanThayDoi.Text = "Xác nhận";
            this.btnXacNhanThayDoi.UseVisualStyleBackColor = true;
            this.btnXacNhanThayDoi.Click += new System.EventHandler(this.btnXacNhanThayDoi_Click);
            // 
            // btnHuyThayDoi
            // 
            this.btnHuyThayDoi.Location = new System.Drawing.Point(296, 141);
            this.btnHuyThayDoi.Name = "btnHuyThayDoi";
            this.btnHuyThayDoi.Size = new System.Drawing.Size(88, 35);
            this.btnHuyThayDoi.TabIndex = 7;
            this.btnHuyThayDoi.Text = "Hủy bỏ";
            this.btnHuyThayDoi.UseVisualStyleBackColor = true;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 213);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyThayDoi;
        private System.Windows.Forms.Button btnXacNhanThayDoi;
        private System.Windows.Forms.TextBox txtComfirmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}