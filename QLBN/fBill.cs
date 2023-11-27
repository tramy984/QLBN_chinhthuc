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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBN
{
    public partial class fBill : Form
    {
        private string LBN;
        private string idGiuong;
        public fBill(string id)
        {
            InitializeComponent();
            txbid.Text = id;
            LoadBN();
        }
        private static string TaoMaHD(string id)
        {
            string MaHD = "HD";
            MaHD = MaHD + id;
            return MaHD;
        }
        void LoadBN()
        {
            txbMHD.Text = TaoMaHD(txbid.Text);
            LoadHoaDon(txbMHD.Text);
            LoadData(txbMHD.Text);
            LoadInforHD();
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string id = txbid.Text;
            string query = "SELECT   BN.MaBenhNhan , BN.MaGiuong ,BN.LBN , BN.Name , BN.NgayNhapVien ,BN.NgayRaVien , BN.MaBenh , BN.MaKhoa , K.nameKhoa , B.nameBenh  " +
                            "FROM dbo.Benhnhan AS BN" +
                           " JOIN dbo.Benh AS B ON BN.MaBenh = B.MaBenh " +
                           "LEFT JOIN dbo.Khoa AS K ON BN.MaKhoa = K.MaKhoa " +
                           "WHERE BN.MaBenhNhan=@id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txbhoten.Text = reader["Name"].ToString();
                    txbkhoa.Text = reader["nameKhoa"].ToString();
                    txbTB.Text = reader["nameBenh"].ToString();
                    LBN = reader["LBN"].ToString();
                    if (LBN == "0")
                    {
                        dtNV.Value = Convert.ToDateTime(reader["NgayNhapVien"]);
                        dtRV.Value = DateTime.Now;
                        reader.Close();
                        string select = "SELECT BN.MaGiuong , GB.nameGB , BN.MaBenhNhan " +
                            "FROM dbo.Benhnhan AS BN " +
                            "JOIN dbo.Giuongbenh AS GB ON BN.MaGiuong=GB.MaGiuong " +
                            "WHERE BN.MaBenhNhan=@id ";
                        SqlCommand selectGB = new SqlCommand(select, connection);
                        selectGB.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader readerGB = selectGB.ExecuteReader())
                        {
                            if (readerGB.Read())
                            {
                                txbGB.Text = readerGB["nameGB"].ToString();
                                idGiuong = readerGB["MaGiuong"].ToString();
                            }
                            readerGB.Close();
                        }
                    }
                    else
                    {
                        dtNV.Visible = false;
                        dtRV.Visible = false;
                        txbGB.Visible = false;
                    }
                }
                reader.Close();
            }

            connection.Close();



        }
        void LoadDichVu()
        {
            string LoaiDV = cbDV.Text;
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (LoaiDV == "Dịch Vụ Khám Bệnh")
            {
                cbThuoc.Items.Clear();
                string query = "SELECT * FROM dbo.DichVu WHERE LEFT(MaDV, 1) = 'K'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbThuoc.Items.Add(reader["nameDV"].ToString());
                }
                reader.Close();

            }
            else if (LoaiDV == "Thuốc")
            {
                cbThuoc.Items.Clear();
                string query = "SELECT * FROM dbo.DichVu WHERE LEFT(MaDV, 1) = 'T'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbThuoc.Items.Add(reader["nameDV"].ToString());
                }
                reader.Close();
            }
            connection.Close();
        }

        void LoadHoaDon(string idBill)
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string KT = "SELECT COUNT(*) FROM [dbo].HoaDon WHERE MaHoaDon=@id";
            SqlCommand KiemTra = new SqlCommand(KT, connection);
            KiemTra.Parameters.AddWithValue("@id", idBill);
            int count = (int)KiemTra.ExecuteScalar();
            if (count > 0) { return; }
            else
            {
                string themHD = "INSERT INTO dbo.HoaDon(MaHoaDon,MaBenhNhan,TongTien,GiamGia,ThanhTien,idGiuong,songay) VALUES (@idBill,@MBN,@TongTien,@GiamGia,@ThanhTien,@idGiuong,@songay)";
                SqlCommand insert = new SqlCommand(themHD, connection);
                insert.Parameters.AddWithValue("@idBill", idBill);
                insert.Parameters.AddWithValue("@MBN", txbid.Text);
                insert.Parameters.AddWithValue("@TongTien", txbTong.Text);
                insert.Parameters.AddWithValue("@GiamGia", GiamGia.Value);
                insert.Parameters.AddWithValue("@ThanhTien", txbTongTien.Text);
                insert.Parameters.AddWithValue("@idGiuong", txbGB.Text);
                insert.Parameters.AddWithValue("@songay", "0");
                insert.ExecuteNonQuery();
            }
        }
        void LoadInforHD()
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM dbo.HoaDon WHERE MaHoaDon=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", txbMHD.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("GiamGia")))
                {
                    GiamGia.Text = reader["GiamGia"].ToString();
                    txbTongTien.Text = reader["ThanhTien"].ToString();
                }
            }
        }

        void LoadData(string idBill)
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT B.idDV,T.nameDV, B.count , T.price ,B.ThanhTien " +
                  "FROM dbo.BillInfor AS B " +
                  "JOIN dbo.DichVu AS T ON B.idDV= T.MaDV " +
                  "WHERE idBill=@idBill";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idBill", idBill);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán DataTable cho DataGridView
                    dtgvBill.DataSource = dataTable;
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int soLuong = (int)SoLuong.Value;
            int DonGia;
            int.TryParse(txbDonGia.Text, out DonGia);
            int ThanhTien = DonGia * soLuong;
            txbThanhTien.Text = ThanhTien.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Thuoc = cbThuoc.Text;
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM dbo.DichVu WHERE nameDV=@nameDV";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nameDV", Thuoc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txbDonGia.Text = reader["price"].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string MaDV = "";
            string tenThuoc = cbThuoc.SelectedItem.ToString();

            string selectQuery = "SELECT MaDV FROM dbo.DichVu WHERE nameDV=@nameDV";
            SqlCommand select = new SqlCommand(selectQuery, connection);
            select.Parameters.AddWithValue("@nameDV", tenThuoc);
            SqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                MaDV = reader["MaDV"].ToString();

            }
            reader.Close();

            int soLuong = (int)SoLuong.Value;
            string idBill = txbMHD.Text;
            string ThanhTien = txbThanhTien.Text;
            string insertQuery = "INSERT INTO dbo.BillInfor (idBill,idDV,count,ThanhTien) VALUES (@id,@idThuoc,@soLuong,@ThanhTien)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

            insertCommand.Parameters.AddWithValue("@id", idBill);
            insertCommand.Parameters.AddWithValue("@idThuoc", MaDV);
            insertCommand.Parameters.AddWithValue("@soLuong", soLuong);
            insertCommand.Parameters.AddWithValue("@ThanhTien", ThanhTien);

            int rowsAffected = insertCommand.ExecuteNonQuery();

            connection.Close();
            LoadData(txbMHD.Text);
            txbTong_TextChanged(sender, e);

        }

        private void txbTong_TextChanged(object sender, EventArgs e)
        {
            int TongTien = 0;
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT ThanhTien FROM dbo.BillInfor WHERE idBill=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", txbMHD.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Kiểm tra nếu giá trị là DBNull trước khi chuyển đổi
                if (!reader.IsDBNull(reader.GetOrdinal("ThanhTien")))
                {
                    int Tien = Convert.ToInt32(reader["ThanhTien"]);
                    TongTien = TongTien + Tien;
                }
            }
            txbTong.Text = TongTien.ToString();
            reader.Close();
            connection.Close();
        }

        private void GiamGia_ValueChanged(object sender, EventArgs e)
        {
            int giamgia = (int)GiamGia.Value;
            int Tong;
            int.TryParse(txbTong.Text, out Tong);
            float TongTien = Tong - Tong * giamgia / 100;
            txbTongTien.Text = TongTien.ToString();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            txbTong_TextChanged(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int songay;
            string idGiuong;
            if (LBN == "0")
            {
                TimeSpan ngay = dtRV.Value - dtNV.Value;
                songay = ngay.Days;
                idGiuong = txbGB.Text;
                string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "UPDATE dbo.HoaDon SET TongTien=@TongTien,GiamGia=@GiamGia,ThanhTien=@ThanhTien,idGiuong=@idGiuong,songay=@songay WHERE MaHoaDon=@id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", txbMHD.Text);
                cmd.Parameters.AddWithValue("@TongTien", txbTong.Text);
                cmd.Parameters.AddWithValue("@GiamGia", GiamGia.Value);
                cmd.Parameters.AddWithValue("@ThanhTien", txbTongTien.Text);
                cmd.Parameters.AddWithValue("@idGiuong", idGiuong);
                cmd.Parameters.AddWithValue("@songay", songay);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                songay = 0;
                idGiuong = null;
                string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "UPDATE dbo.HoaDon SET TongTien=@TongTien,GiamGia=@GiamGia,ThanhTien=@ThanhTien,songay=@songay WHERE MaHoaDon=@id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", txbMHD.Text);
                cmd.Parameters.AddWithValue("@TongTien", txbTong.Text);
                cmd.Parameters.AddWithValue("@GiamGia", GiamGia.Value);
                cmd.Parameters.AddWithValue("@ThanhTien", txbTongTien.Text);
                cmd.Parameters.AddWithValue("@songay", songay);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DateTime NgayHT = DateTime.Now;
            if (LBN == "0")
            {
                string query = $"UPDATE dbo.Giuongbenh SET Status=0 WHERE MaGiuong=@MaGiuong";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaGiuong", txbGB.Text);
            }
            else { }
            string selectBN = "SELECT * FROM dbo.Benhnhan WHERE MaBenhNhan=@id";
            using (SqlCommand selectCommand = new SqlCommand(selectBN, connection))
            {
                selectCommand.Parameters.AddWithValue("@id", txbid.Text);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        using (SqlConnection insert = new SqlConnection(connectionString))
                        {
                            insert.Open();
                            DateTime NgayHienTai = DateTime.Now;
                            string insertQuery = "INSERT INTO dbo.Benhnhancu (MaBenhNhan, Name, GioiTinh, NgaySinh, CCCD, BHYT, Phone, NgayNhapVien, NgayRaVien, MaKhoa, MaBacSi, MaYTa, MaBenh, MaGiuong,LBN) VALUES (@MaBenhNhan, @Name, @GioiTinh, @NgaySinh, @CCCD, @BHYT, @Phone, @NgayNhapVien, @NgayRaVien, @MaKhoa, @MaBacSi, @MaYTa, @MaBenh, @MaGiuong,@LBN)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, insert))
                            {
                                insertCommand.Parameters.AddWithValue("@MaBenhNhan", reader["MaBenhNhan"]);
                                insertCommand.Parameters.AddWithValue("@Name", reader["Name"]);
                                insertCommand.Parameters.AddWithValue("@GioiTinh", reader["GioiTinh"]);
                                insertCommand.Parameters.AddWithValue("@NgaySinh", reader["NgaySinh"]);
                                insertCommand.Parameters.AddWithValue("@CCCD", reader["CCCD"]);
                                insertCommand.Parameters.AddWithValue("@BHYT", reader["BHYT"]);
                                insertCommand.Parameters.AddWithValue("@Phone", reader["Phone"]);
                                insertCommand.Parameters.AddWithValue("@NgayNhapVien", NgayHienTai);
                                insertCommand.Parameters.AddWithValue("@NgayRaVien", NgayHienTai);
                                insertCommand.Parameters.AddWithValue("@MaKhoa", reader["MaKhoa"]);
                                insertCommand.Parameters.AddWithValue("@MaBacSi", reader["MaBacSi"]);
                                insertCommand.Parameters.AddWithValue("@MaYTa", reader["MaYTa"]);
                                insertCommand.Parameters.AddWithValue("@MaBenh", reader["MaBenh"]);
                                insertCommand.Parameters.AddWithValue("@MaGiuong", reader["MaGiuong"]);
                                insertCommand.Parameters.AddWithValue("@LBN", reader["LBN"]);


                                int rowsAffected = insertCommand.ExecuteNonQuery();

                            }
                            insert.Close();
                        }
                    }
                    reader.Close();

                }
            }

            string selectQuery = "SELECT * FROM dbo.HoaDon WHERE MaHoaDon=@idBill";
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@idBill", txbMHD.Text);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        using (SqlConnection insert = new SqlConnection(connectionString))
                        {
                            insert.Open();

                            string insertQuery = "INSERT INTO dbo.HoaDonCu (MaHoaDon, MaBenhNhan, idGiuong,songay,TongTien, GiamGia, ThanhTien,NgayThanhToan) VALUES (@MaHoaDon, @MaBenhNhan,@idGiuong,@songay, @TongTien, @GiamGia, @ThanhTien,@NgayTT)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, insert))
                            {
                                insertCommand.Parameters.AddWithValue("@MaHoaDon", reader["MaHoaDon"]);
                                insertCommand.Parameters.AddWithValue("@MaBenhNhan", reader["MaBenhNhan"]);
                                insertCommand.Parameters.AddWithValue("@idGiuong", reader["idGiuong"]);
                                insertCommand.Parameters.AddWithValue("@songay", reader["songay"]);
                                insertCommand.Parameters.AddWithValue("@TongTien", reader["TongTien"]);
                                insertCommand.Parameters.AddWithValue("@GiamGia", reader["GiamGia"]);
                                insertCommand.Parameters.AddWithValue("@ThanhTien", reader["ThanhTien"]);
                                insertCommand.Parameters.AddWithValue("@NgayTT", NgayHT);
                                int rowsAffected = insertCommand.ExecuteNonQuery();


                            }
                            insert.Close();

                        }
                    }

                }
            }

            string selectBill = "SELECT * FROM dbo.BillInfor WHERE idBill=@idBill";
            using (SqlCommand selectCommand = new SqlCommand(selectBill, connection))
            {
                selectCommand.Parameters.AddWithValue("@idBill", txbMHD.Text);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {

                    using (SqlConnection insert = new SqlConnection(connectionString))
                    {
                        insert.Open();

                        string insertQuery = "INSERT INTO dbo.BillInforcu (idBill, idDV, count,ThanhTien) VALUES (@MHD, @idDV, @soluong, @ThanhTien)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, insert))
                        {
                            insertCommand.Parameters.AddWithValue("@MHD", row["idBill"]);
                            insertCommand.Parameters.AddWithValue("@idDV", row["idDV"]);
                            insertCommand.Parameters.AddWithValue("@soluong", row["count"]);
                            insertCommand.Parameters.AddWithValue("@ThanhTien", row["ThanhTien"]);

                            int rowsAffected = insertCommand.ExecuteNonQuery();


                        }
                        insert.Close();
                    }
                }
            }
            try
            {
                string deletebill = "DELETE FROM dbo.BillInfor WHERE idBill=@idBill";
                using (SqlCommand command = new SqlCommand(deletebill, connection))
                {
                    command.Parameters.AddWithValue("@idBill", txbMHD.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                }

                string deleteHD = "DELETE FROM dbo.HoaDon WHERE MaHoaDon=@MHD";
                using (SqlCommand command = new SqlCommand(deleteHD, connection))
                {
                    command.Parameters.AddWithValue("@MHD", txbMHD.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                }

                string deleteBN = "DELETE FROM dbo.Benhnhan WHERE MaBenhNhan=@MBN";
                using (SqlCommand command = new SqlCommand(deleteBN, connection))
                {
                    command.Parameters.AddWithValue("@MBN", txbid.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                }
                MessageBox.Show("Thanh toán thành công", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDichVu();
        }

        private void GiamGia_ValueChanged_1(object sender, EventArgs e)
        {
            int giamgia = (int)GiamGia.Value;
            int Tong;
            int.TryParse(txbTong.Text, out Tong);
            float TongTien = Tong - Tong * giamgia / 100;
            txbTongTien.Text = TongTien.ToString();
        }

        private void txbTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTong_TextChanged_1(object sender, EventArgs e)
        {
            txbTongTien.Text = txbTong.Text;
        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
