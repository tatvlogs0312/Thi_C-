using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeNguoiDung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            string con_str = $"Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS ; Initial Catalog = NguoiDung ; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            try
            {
                conn.Open();
                string query = $"select count(*) from Nguoidung where Taikhoan = '{tk}' and Matkhau = '{mk}'";
                SqlCommand cmd = new SqlCommand(query,conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl == 1)
                {
                    string x = " ";
                    if(chkAdmin.Checked == true)
                    {
                        x = "x";
                    } 
                    string query2 = $"select count(*) from Nguoidung where Taikhoan = '{tk}' and Matkhau = '{mk}' and quyenAdmin = '{x}'";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    conn.Open();
                    int sl2 = (int)cmd2.ExecuteScalar();
                    conn.Close();
                    if (sl2 == 1)
                    {
                        MessageBox.Show("Đăng nhập admin thành công");
                        getData();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập người dùng thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }               
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Lỗi : " + ex.Message);               
            }
        }

        public void getData()
        {
            try
            {
                string con_str = $"Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS ; Initial Catalog = NguoiDung ; Integrated Security = SSPI";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string query = $"select * from nguoiDung";
                SqlCommand cmd = new SqlCommand(query, conn);
                List<Admin> list = new List<Admin>();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Admin ad = new Admin();
                    ad.TaiKhoan = (string)rd["TaiKhoan"];
                    ad.MatKhau = (string)rd["MatKhau"];
                    ad.QuyenAdmin = (string)rd["quyenAdmin"];
                    list.Add(ad);
                }
                conn.Close();
                dgvDanhSach.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
