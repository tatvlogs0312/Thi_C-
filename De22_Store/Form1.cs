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

namespace De22_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ncc = txtNCC.Text;
                string con_str = "Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS ; Initial Catalog = PMStore ; Integrated Security = SSPI";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string query = $"select * from SanPham where NhaCungCap like '%{ncc}%'";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                List<SanPham> list = new List<SanPham>();
                while (rd.Read())
                {
                    SanPham obj = new SanPham();
                    obj.MaSanPham = (string)rd["MaSanPham"];
                    obj.TenSanPham = (string)rd["TenSanPham"];
                    obj.SoLuongTon = (int)rd["SoLuongTon"];
                    obj.NgaySanXuat = (DateTime)rd["NgaySanXuat"];
                    obj.NgayHetHan = (DateTime)rd["NgayHetHan"];
                    obj.NhaCungCap = (string)rd["NhaCungCap"];
                    list.Add(obj);
                }
                conn.Close();
                dgvStore.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
    }
}
