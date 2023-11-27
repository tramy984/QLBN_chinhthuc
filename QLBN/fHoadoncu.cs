using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QLBN.DAO;
namespace QLBN
{
    public partial class fHoadoncu : Form
    {
        public fHoadoncu(string id)
        {
            InitializeComponent();
            txbid.Text = id;
            LoadBN();
        }
        void LoadBN()
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string id = txbid.Text;
            string query = "SELECT BN.MaBenhNhan , HD.NgayThanhToan, BN.MaGiuong , BN.Name , BN.MaBenh , BN.MaKhoa , B.nameBenh , HD.MaHoaDon , HD.TongTien , HD.GiamGia , HD.ThanhTien " +
                            "FROM dbo.Benhnhancu AS BN" +
                           " JOIN dbo.Benh AS B ON BN.MaBenh = B.MaBenh " +
                           "LEFT JOIN dbo.HoaDonCu AS HD ON BN.MaBenhNhan = HD.MaBenhNhan " +
                           "WHERE BN.MaBenhNhan=@id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                //MessageBox.Show(txbid.Text);
                if (reader.Read())
                {
                    txbhoten.Text = reader["Name"].ToString();
                    DTTT.Value = Convert.ToDateTime(reader["NgayThanhToan"]);
                    txbTB.Text = reader["nameBenh"].ToString();
                    txbMHD.Text = reader["MaHoaDon"].ToString();
                    txbTT.Text = reader["TongTien"].ToString();
                    txbGG.Text = reader["GiamGia"].ToString();
                    txbThanhTien.Text = reader["ThanhTien"].ToString();
                }
                reader.Close();
            }
            connection.Close();
            LoadHDcu(txbMHD.Text);
        }
        void LoadHDcu(string idBill)
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT B.idDV,T.nameDV, B.count , T.price ,B.ThanhTien " +
                  "FROM dbo.BillInforcu AS B " +
                  "JOIN dbo.DichVu AS T ON B.idDV= T.MaDV " +
                  "WHERE idBill=@idBill";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idBill", idBill); 
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtgvHD.DataSource = dataTable;
                }
            }
        }
        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbGB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbGG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
