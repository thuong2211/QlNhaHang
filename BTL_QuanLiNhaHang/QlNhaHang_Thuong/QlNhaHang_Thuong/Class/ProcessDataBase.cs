using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QlNhaHang.Class
{
    internal class ProcessDataBase
    {
        string strConnect = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True";
        SqlConnection sqlConnect = null;

        //Phương thức mở kết nối
        void MoKetNoi()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối
        void DongKetNoi()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable DocBang(string sqlSelct)
        {
            DataTable dt = new DataTable();
            try
            {
                MoKetNoi();  // Kết nối cơ sở dữ liệu
                SqlDataAdapter da = new SqlDataAdapter(sqlSelct, sqlConnect);
                da.Fill(dt);   // Đổ dữ liệu vào DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();  // Đóng kết nối
            }
            return dt;
            //DataTable tblData = new DataTable();
            //MoKetNoi();
            //SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
            //sqlData.Fill(tblData);
            //DongKetNoi();
            //return tblData;
        }
        //Phương thức thực hiện câu lệnh dạng insert,update,delete
        public void CapNhatDuLieu(string sql)
        {
            MoKetNoi();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
