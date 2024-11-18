namespace QlNhaHang_Thuong
{
    partial class LoginWithManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWithManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.titleLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cBoxShowPw = new System.Windows.Forms.CheckBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 506);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mật khẩu:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(379, 171);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(61, 20);
            this.lbUserName.TabIndex = 28;
            this.lbUserName.Text = "Mã NV:";
            // 
            // titleLogin
            // 
            this.titleLogin.AutoSize = true;
            this.titleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogin.Location = new System.Drawing.Point(399, 46);
            this.titleLogin.Name = "titleLogin";
            this.titleLogin.Size = new System.Drawing.Size(287, 26);
            this.titleLogin.TabIndex = 27;
            this.titleLogin.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            this.titleLogin.Click += new System.EventHandler(this.titleLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(474, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 41);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Tag = "3";
            this.btnLogin.Text = "Ok";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btn_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_KeyDown);
            this.btnLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyUp);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // cBoxShowPw
            // 
            this.cBoxShowPw.AutoSize = true;
            this.cBoxShowPw.Location = new System.Drawing.Point(383, 318);
            this.cBoxShowPw.Name = "cBoxShowPw";
            this.cBoxShowPw.Size = new System.Drawing.Size(138, 24);
            this.cBoxShowPw.TabIndex = 24;
            this.cBoxShowPw.Tag = "";
            this.cBoxShowPw.Text = "Hiện mật khẩu";
            this.cBoxShowPw.UseVisualStyleBackColor = true;
            this.cBoxShowPw.CheckedChanged += new System.EventHandler(this.cBoxShowPw_CheckedChanged);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(383, 264);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(303, 28);
            this.txtPW.TabIndex = 23;
            this.txtPW.Tag = "2";
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(383, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 28);
            this.txtName.TabIndex = 22;
            this.txtName.Tag = "1";
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExit.Location = new System.Drawing.Point(726, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 25);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "X";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(484, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // errorCheck
            // 
            this.errorCheck.ContainerControl = this;
            // 
            // LoginWithManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 506);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.titleLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cBoxShowPw);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginWithManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWithManager";
            this.Load += new System.EventHandler(this.LoginWithManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label titleLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cBoxShowPw;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorCheck;
    }
}