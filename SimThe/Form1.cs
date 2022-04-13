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

namespace SimThe
{
    public partial class Form1 : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            connect = new Connect();
            conn = connect.connect();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            try
            {
                List<SimThe> list = new List<SimThe>();
                conn.Open();
                string query = "select * from sim";
                cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SimThe obj = new SimThe();
                    obj.Id = (string)rd["id"];
                    obj.SoSim = (string)rd["soSim"];
                    obj.IdMang = (string)rd["mangId"];
                    obj.NKH = (DateTime)rd["ngayKichHoat"];
                    obj.NHH = (DateTime)rd["ngayHetHan"];
                    list.Add(obj);
                }

                conn.Close();
                dgvSim.DataSource = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string soSim = txtSoSim.Text;
                string idMang = txtMangID.Text;
                string ngayKH = txtNgayKH.Text;
                string ngayHH = txtNgayHH.Text; 
                conn.Open();
                string query = $"insert into sim(id,soSim , mangId,ngayKichHoat,ngayHetHan) values " +
                    $"('{id}', '{soSim}', '{idMang}', '{ngayKH}', '{ngayHH}')";
                cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
            getData();
        }

        private void txtSoSim_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSoSim_Leave(object sender, EventArgs e)
        {
            string soSim = txtSoSim.Text;
            if (soSim.Length != 10)
            {
                MessageBox.Show("Số sim không hợp lệ");
                txtSoSim.Text = "";
            }
        }
    }
}
