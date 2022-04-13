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

namespace De07_MayBay
{
    public partial class Form1 : Form
    {
        Connect connect;
        SqlConnection conn;
        public Form1()
        {
            connect = new Connect();
            conn = connect.connect();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "select * from MayBay where KhuVucDo = 'Khu b'";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                List<SanBay> list = new List<SanBay>();
                while (rd.Read())
                {
                    SanBay obj = new SanBay();
                    obj.MaMayBay = (string)rd["MaMayBay"];
                    obj.TenMayBay = (string)rd["TenMayBay"];
                    obj.NamSanXuat = (int)rd["NamSanXuat"];
                    obj.HangSanXuat = (string)rd["HangSanXuat"];
                    obj.KhuVucDo = (string)rd["KhuVucDo"];
                    list.Add(obj);
                }
                conn.Close();
                dgvMayBay.DataSource = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                conn.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string hsx = txtHangSX.Text;
                conn.Open();
                string query = $"select * from MayBay where HangSanXuat = '{hsx}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                List<SanBay> list = new List<SanBay>();
                while (rd.Read())
                {
                    SanBay obj = new SanBay();
                    obj.MaMayBay = (string)rd["MaMayBay"];
                    obj.TenMayBay = (string)rd["TenMayBay"];
                    obj.NamSanXuat = (int)rd["NamSanXuat"];
                    obj.HangSanXuat = (string)rd["HangSanXuat"];
                    obj.KhuVucDo = (string)rd["KhuVucDo"];
                    list.Add(obj);
                }
                conn.Close();
                dgvMayBay.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            if (ma.Length == 0 || KTma() == false)
            {
                MessageBox.Show("Mã không đúng định dạng");
                txtMa.Select();
            }
        }

        public bool KTma()
        {
            string ma = txtMa.Text;
            for (int i = 0; i < ma.Length; i++)
            {
                if(ma[i] > '9' || ma[i] < '0')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
