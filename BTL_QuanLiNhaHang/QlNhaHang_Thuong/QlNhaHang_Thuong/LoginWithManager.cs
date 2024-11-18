using QlNhaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using QlNhaHang_Thuong.Class;


namespace QlNhaHang_Thuong
{
    public partial class LoginWithManager : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public LoginWithManager()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DodgerBlue;
            if (txtName.Text.Trim() == "")
            {
                errorCheck.SetError(txtName, "This field cannot be left blank.!");
                return;
            }
            else
            {
                errorCheck.Clear();
            }
            if (txtPW.Text.Trim() == "")
            {
                errorCheck.SetError(txtPW, "This field cannot be left blank.");
                return;
            }
            else
            {
                errorCheck.Clear();
            }
            DataTable dt = pd.DocBang("select * from NhanVien where MaNV = '" + txtName.Text + "'");
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có tài khoản nào phù hợp");
                return;
            }
            else
            {
                Program.maNV = txtName.Text;
                //string giaimaMK = hPW.HashPassword(txtPW.Text);
                

                if(dt.Rows[0]["PhanQuyen"].ToString() == "1"){
                    if (dt.Rows[0]["MatKhau"].ToString() != txtPW.Text)
                    {
                        MessageBox.Show("Sai mật khẩu");
                        return;
                    }
                    StaffManagement sm = new StaffManagement();
                    sm.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (dt.Rows[0]["MatKhau"].ToString() != txtPW.Text)
                    {
                        MessageBox.Show("Sai mật khẩu");
                        return;
                    }
                    Role form = new Role();
                    form.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.KeyCode == Keys.Enter) btn.BackColor = Color.DodgerBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.ControlLight;
        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
           btnLogin.BackColor = SystemColors.ControlLight;
        }

        private void LoginWithManager_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "restaurant-building.png")); // WinForms
            pictureBox2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "login.png")); // WinForms

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            Role form = new Role();
            form.Show();
            this.Close();
        }

        private void cBoxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (!cBoxShowPw.Checked)
            {
                txtPW.UseSystemPasswordChar = true;
            }
            else txtPW.UseSystemPasswordChar = false;
        }

        private void titleLogin_Click(object sender, EventArgs e)
        {

        }

    }
}
