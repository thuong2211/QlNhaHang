using QlNhaHang.Class;
using QlNhaHang_Thuong.Class;
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
using System.Xml.Linq;

namespace QlNhaHang_Thuong
{
    public partial class StaffManagement : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        bool checkImg = true;
        string linkImg="";
        

        public StaffManagement()
        {
            InitializeComponent();

        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            this.Width = 1050;
            this.Height = 600;
            pictureBox8.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "update.png")); // WinForms

            pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "invisible.png")); // WinForms
            btnSearch.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "search.png")); // WinForms
            pictureBox2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "cat.png")); // WinForms
            menuArrange.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "arrows.png")); // WinForms
            decreaseToolStripMenuItem.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "decrease.png")); // WinForms
            acreaseToolStripMenuItem.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "increase.png")); // WinForms
            menuFilter.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "filter.png")); // WinForms
            chefToolStripMenuItem.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "chef.png")); // WinForms
            casherToolStripMenuItem.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "cashier.png")); // WinForms
            securityToolStripMenuItem.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "security.png")); // WinForms
            waiterToolStripMenuItem.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "waiter.png")); // WinForms
            pictureBox2.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "add-user.png")); // WinForms
            pictureBox4.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "delete.png")); // WinForms
            ImgStaff.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "photos.png")); // WinForms
            pictureBox6.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "save.png")); // WinForms
            pictureBox7.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "cancel.png")); // WinForms

            btnAdd.Enabled = true;
            btnDel.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien order by MaNV asc");
            DataTable dt = pd.DocBang("select * from NhanVien where MaNV = '" + Program.maNV + "'");
            label10.Text = "Hello, " + dt.Rows[0]["TenNV"].ToString();
            pictureBox3.Image = Image.FromFile(dt.Rows[0]["Anh"].ToString());
            button1.Enabled = false;
        }

        private void btnOpenFileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|" +
                "All files(*.*)|*.*";
            openFileDialog.InitialDirectory = "D:\\LTTQuan\\BTL_QuanLiNhaHang\\" +
                "QlNhaHang_Thuong\\QlNhaHang_Thuong\\bin\\Debug\\Image";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "Select a image to display";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImgStaff.Image = Image.FromFile(openFileDialog.FileName);
                linkImg = openFileDialog.FileName;
            }
            else
                MessageBox.Show("You clicked Cancel", "Open Dialog",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (checkImg)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "show.png")); // WinForms

                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "invisible.png")); // WinForms

                txtPassword.UseSystemPasswordChar = true;
            }
            checkImg = !checkImg;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reset()
        {
            txtFullName.Text = "";
            txtStaffId.Text = "";
            cbBoPhan.SelectedIndex = -1;
            rdFemale.Checked = false;
            rdMale.Checked = false;
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtPassword.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            reset();

            ImgStaff.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "photos.png")); // WinForms
            txtStaffId.Text = AutoSingKey("NhanVien", "MaNV", "NV");
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            button1.Enabled = false;
        }

        public string AutoSingKey(string tableName, string ID, string startCode)
        {
            Random random = new Random();
            string id = "";
            bool check = false;

            do
            {
                id = startCode + random.Next(1, 1000).ToString();
                DataTable dt = pd.DocBang("Select * from " + tableName + " where " +
                    ID + "='" + id + "'");
                if (dt.Rows.Count == 0)
                    check = true;
            }
            while (check == false);
            return id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền mật khẩu");
                return;
            }

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền tên");
                return;
            }
            if (cbBoPhan.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn bộ phận");
                return;
            }
            if (rdFemale.Checked ==false && rdMale.Checked==false)
            {
                MessageBox.Show("Bạn phải chọn giới tính");
                return;
            }
            if (txtPhoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền số điện thoại");
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải điền địa chỉ");
                return;
            }
            if(ImgStaff.Image == Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "photos.png")))
            {
                MessageBox.Show("Bạn phải chọn ảnh");
                return;
            }

            string gt="";
            if (rdFemale.Checked == true) gt = "Nữ";
            if (rdMale.Checked == true) gt = "Nam";

            // string mahoaMK = hPW.HashPassword(txtPassword.Text);
            string sql;
            if (cbBoPhan.Text.Trim() == "Quản lý") sql = "insert into NhanVien(MaNV,TenNV,MatKhau,PhanQuyen,GioiTinh,SDT,NgaySinh,BoPhan,Anh,DiaChi) values(N'" + txtStaffId.Text + "',N'" + txtFullName.Text + "','" +
                txtPassword.Text + "',1,N'" + gt + "','" + txtPhoneNumber.Text + "','"
                + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',N'" + cbBoPhan.Text + "','" + linkImg + "',N'" + txtAddress.Text + "')";

            else sql = "insert into NhanVien(MaNV,TenNV,MatKhau,PhanQuyen,GioiTinh,SDT,NgaySinh,BoPhan,Anh,DiaChi) values(N'" + txtStaffId.Text + "',N'" + txtFullName.Text + "','" +
                txtPassword.Text + "',2,N'" + gt + "','" + txtPhoneNumber.Text + "','"
                + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',N'" + cbBoPhan.Text + "','" + linkImg + "',N'" + txtAddress.Text + "')";
            pd.CapNhatDuLieu(sql);
            DataTable dtChiTiet = pd.DocBang("select top 10" +
                " * from NhanVien");
            reset();

            ImgStaff.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "photos.png")); // WinForms
            dataGridView1.DataSource = dtChiTiet;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
            ImgStaff.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "photos.png")); // WinForms
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Bạn muốn xóa nhân viên này không?", "Thông báo",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                pd.CapNhatDuLieu("delete NhanVien where MaNV = '" + txtStaffId.Text + "'");
                reset();
                dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien  order by MaNV asc");
                MessageBox.Show("Bạn đã xóa thành công một nhân viên!");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStaffId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFullName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nữ") rdFemale.Checked = true;
            else rdMale.Checked = true;
            txtPhoneNumber.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbBoPhan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            ImgStaff.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            btnDel.Enabled = true;
            btnCancel.Enabled = true;
            button1.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void tuổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien  order by datediff(YYYY,NgaySinh,getdate()) desc");
        }

        private void tuổiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien order by datediff(YYYY,NgaySinh,getdate()) asc");
        }

        private void họVàTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien  order by TenNV desc");
        }

        private void họVàTênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien  order by TenNV asc");
        }

        private void bpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            if (clickedItem != null)
            {
                // Sử dụng Tag để phân biệt các menu
                string menuName = clickedItem.Tag.ToString();
                //MessageBox.Show(menuName);
                dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien where BoPhan = N'" + menuName+ "' order by MaNV asc");
            }
        }

        private void menuFilter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            string gt = "";
            if (rdFemale.Checked == true) gt = "Nữ";
            if (rdMale.Checked == true) gt = "Nam";
            DataTable dt = pd.DocBang("select Anh from NhanVien where MaNV = N'" + txtStaffId.Text + "'");
            if (linkImg == "") linkImg = dt.Rows[0]["Anh"].ToString();
            //string mahoaMK = hPW.HashPassword(txtPassword.Text);
            string sql;
            if (cbBoPhan.Text.Trim() == "Quản lý") sql = "UPDATE NhanVien SET " +
             "TenNV = N'" + txtFullName.Text + "', " +
             "MatKhau = '" + txtPassword.Text + "', " +
             "PhanQuyen = 1, " +
             "GioiTinh = N'" + gt + "', " +
             "SDT = '" + txtPhoneNumber.Text + "', " +
             "NgaySinh = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
             "BoPhan = N'" + cbBoPhan.Text + "', " +
             "Anh = '" + linkImg + "', " +
             "DiaChi = N'" + txtAddress.Text + "' " +
             "WHERE MaNV = N'" + txtStaffId.Text + "'";

            else sql = "UPDATE NhanVien SET " +
             "TenNV = N'" + txtFullName.Text + "', " +
             "MatKhau = '" + txtPassword.Text + "', " +
             "PhanQuyen = 2, " +
             "GioiTinh = N'" + gt + "', " +
             "SDT = '" + txtPhoneNumber.Text + "', " +
             "NgaySinh = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', " +
             "BoPhan = N'" + cbBoPhan.Text + "', " +
             "Anh = '" + linkImg + "', " +
             "DiaChi = N'" + txtAddress.Text + "' " +
             "WHERE MaNV = N'" + txtStaffId.Text + "'";

            pd.CapNhatDuLieu(sql);
            reset();
            ImgStaff.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "photos.png")); // WinForms
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien order by MaNV asc");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select top 10 * from NhanVien where TenNV like N'%" + txtSearch.Text + "%' or SDT like '%"+txtSearch.Text+"%' order by MaNV asc");

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnWorkSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}
 