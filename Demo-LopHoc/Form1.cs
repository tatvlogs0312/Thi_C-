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

namespace Demo_LopHoc
{
    public partial class frmMain : Form
    {
        SqlConnection conn;
        Connect connectDB;
        SqlCommand cmd;

        public frmMain()
        {
            InitializeComponent();              
            connectDB = new Connect();
            conn = connectDB.connect();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        public void lamMoi()
        {
            txtMa.Text = "";
            txtLop.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMa.Text;
                string tenLop = txtLop.Text;
                conn.Open();
                string query = $"insert into lophoc(id,ten) values ('{maLop}',N'{tenLop}')";
                cmd = new SqlCommand(query,conn);
                int sl = cmd.ExecuteNonQuery();               
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    lamMoi();
                    getData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            try
            {
                List<LopHoc> list = new List<LopHoc>(); 
                conn.Open();
                string query = "select * from lophoc";
                cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    LopHoc lop = new LopHoc();
                    lop.MaLop = (string)rd["id"];
                    lop.TenLop = (string)rd["ten"];
                    list.Add(lop);
                }
                conn.Close();

                dgvLop.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMa.Text = (string)dgvLop.Rows[row].Cells["MaLop"].Value;
                txtLop.Text = (string)dgvLop.Rows[row].Cells["TenLop"].Value;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMa.Text;
                string tenLop = txtLop.Text;
                conn.Open();
                string query = $"update lophoc set ten = '{tenLop}' where id = '{maLop}'" ;
                cmd = new SqlCommand(query,conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Sửa thành công");
                    getData();                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMa.Text;
                conn.Open();
                string query = $"delete from lophoc where id = '{maLop}'";
                cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    getData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
