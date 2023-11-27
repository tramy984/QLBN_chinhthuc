using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QLBN.DAO;

namespace QLBN
{
    public partial class fBenhvaDV : Form
    {
        public fBenhvaDV()
        {
            InitializeComponent();
            LoadBenh();
            LoadDV();
        }
        void LoadDV()
        {
            string query = "SELECT * FROM dbo.DichVu";
            DataProvider provider = new DataProvider();
            dtgvDV.DataSource = provider.ExecuteQuery(query);
        }
        void LoadBenh()
        {
            string query = "SELECT * FROM dbo.Benh";
            DataProvider provider = new DataProvider();
            dtgvBenh.DataSource = provider.ExecuteQuery(query);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvBenh.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dtgvBenh.CurrentRow;

                string TenBenh = selectedRow.Cells["nameBenh"].Value.ToString();
                string Trieuchung = selectedRow.Cells["Trieuchung"].Value.ToString();

                txbBenh.Text = TenBenh;
                txbTC.Text = Trieuchung;


            }
        }

        private void dtgvDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDV.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dtgvDV.CurrentRow;

                string TenDV = selectedRow.Cells["nameDV"].Value.ToString();
                string giatien = selectedRow.Cells["price"].Value.ToString();

                txbDV.Text = TenDV;
                txbGTien.Text = giatien;


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txbBenh.Text)) || (!string.IsNullOrEmpty(txbTC.Text)))
            {
                MessageBox.Show("Vui lòng nhập vào tên bệnh và triệu chứng để thực hiện thêm bệnh vào danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False");
            connection.Open();
            string query = "INSERT INTO dbo.Benh(nameBenh,Trieuchung) VALUES (@TenBenh,@Trieuchung)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@TenBenh", txbBenh.Text);
                cmd.Parameters.AddWithValue("@Trieuchung", txbTC.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Thêm bệnh thành công", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTK.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên bệnh để thực hiện tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string TenBenh=txbTK.Text;
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.Benh WHERE nameBenh=@TenBenh";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TenBenh", TenBenh);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        dtgvBenh.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh này. Bạn có thể nhấn nút 'Thêm' để thêm tên bệnh và triệu chứng vào danh sách.", "Thông báo");
                    }
                }
            }
        }

        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            LoadBenh();
        }
    }
}
