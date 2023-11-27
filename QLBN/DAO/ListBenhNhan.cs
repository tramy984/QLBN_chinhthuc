using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QLBN.DAO
{
    internal class ListBenhNhan
    {
        public void LoadDataFromSelectedRow(DataGridView dgv, TextBox txbid, TextBox txbhoten, ComboBox cbGT, DateTimePicker dtNS, TextBox txbCCCD, TextBox txbBHYT, TextBox txbSDT, DateTimePicker NV, DateTimePicker RV, TextBox txbkhoa, TextBox txbBS, TextBox txbYT, TextBox txbBenh, ComboBox cbGB,ComboBox cbLBN)
        {
            txbid.ReadOnly = true;
            if (dgv.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgv.CurrentRow;

                string MBN = selectedRow.Cells["MaBenhNhan"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string gioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                string ngaySinh = selectedRow.Cells["NgaySinh"].Value.ToString();
                string CCCD = selectedRow.Cells["CCCD"].Value.ToString();
                string BHYT = selectedRow.Cells["BHYT"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string NhapVien = selectedRow.Cells["NgayNhapVien"].Value.ToString();
                string RaVien = selectedRow.Cells["NgayRaVien"].Value.ToString();
                string maBenh = selectedRow.Cells["MaBenh"].Value.ToString();
                string maKhoa = selectedRow.Cells["MaKhoa"].Value.ToString();
                string maBacSi = selectedRow.Cells["MaBacSi"].Value.ToString();
                string maYTa = selectedRow.Cells["MaYTa"].Value.ToString();
                string maGB = selectedRow.Cells["MaGiuong"].Value.ToString();
                string LBN = selectedRow.Cells["LBN"].Value.ToString();

                txbid.Text = MBN;
                txbhoten.Text = name;
                cbGT.Text = gioiTinh;
                dtNS.Text = ngaySinh;
                txbCCCD.Text = CCCD;
                txbBHYT.Text = BHYT;
                txbSDT.Text = phone;
                txbBenh.Text = maBenh;
                txbkhoa.Text = maKhoa;
                txbBS.Text = maBacSi;
                txbYT.Text = maYTa;
                if (LBN == "0")
                {
                    cbLBN.Text = "Nội Trú";
                    RV.Visible = true;
                    NV.Visible = true;
                    cbGB.Visible = true;
                    cbGB.Text = maGB;
                    NV.Text = NhapVien;
                    RV.Text = RaVien;
                }
                else
                {
                    cbLBN.Text = "Ngoại Trú";
                    cbGB.Visible = false;
                    RV.Visible = false;
                    NV.Visible = false;
                }
            }
        }
        public void ThemBenhNhan(TextBox txbid, TextBox txbhoten, ComboBox cbGT, DateTimePicker dtNS, TextBox txbCCCD, TextBox txbBHYT, TextBox txbSDT, DateTimePicker NV, DateTimePicker RV, TextBox txbkhoa, TextBox txbBS, TextBox txbYT, TextBox txbBenh, ComboBox cbGB,ComboBox cbLBN)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False");
                if (cbLBN.Text == "Nội Trú")
                {
                        connection.Open();
                        string query = $"INSERT INTO dbo.Benhnhan(LBN, Name, GioiTinh, NgaySinh, CCCD, BHYT, Phone, NgayNhapVien, NgayRaVien, MaKhoa, MaBacSi, MaYTa, MaBenh, MaGiuong) VALUES (@LBN, @Name, @GioiTinh, @NgaySinh, @CCCD, @BHYT, @Phone, @NgayNhapVien, @NgayRaVien, @MaKhoa, @MaBacSi, @MaYTa, @MaBenh, @MaGiuong)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@LBN", "0");
                            cmd.Parameters.AddWithValue("@Name", txbhoten.Text);
                            cmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
                            cmd.Parameters.AddWithValue("@NgaySinh", dtNS.Value);
                            cmd.Parameters.AddWithValue("@CCCD", txbCCCD.Text);
                            cmd.Parameters.AddWithValue("@BHYT", txbBHYT.Text);
                            cmd.Parameters.AddWithValue("@Phone", txbSDT.Text);
                            cmd.Parameters.AddWithValue("@NgayNhapVien", NV.Value);
                            cmd.Parameters.AddWithValue("@NgayRaVien", RV.Value);
                            cmd.Parameters.AddWithValue("@MaKhoa", txbkhoa.Text);
                            cmd.Parameters.AddWithValue("@MaBacSi", txbBS.Text);
                            cmd.Parameters.AddWithValue("@MaYTa", txbYT.Text);
                            cmd.Parameters.AddWithValue("@MaBenh", txbBenh.Text);
                            cmd.Parameters.AddWithValue("@MaGiuong", cbGB.Text);

                            cmd.ExecuteNonQuery();
                        }
                }               
                else
                {
                        connection.Open();
                        string query = $"INSERT INTO dbo.Benhnhan(LBN, Name, GioiTinh, NgaySinh, CCCD, BHYT, Phone, MaKhoa, MaBacSi, MaYTa, MaBenh) VALUES (@LBN, @Name, @GioiTinh, @NgaySinh, @CCCD, @BHYT, @Phone, @MaKhoa, @MaBacSi, @MaYTa, @MaBenh)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@LBN", "1");
                            cmd.Parameters.AddWithValue("@Name", txbhoten.Text);
                            cmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
                            cmd.Parameters.AddWithValue("@NgaySinh", dtNS.Value);
                            cmd.Parameters.AddWithValue("@CCCD", txbCCCD.Text);
                            cmd.Parameters.AddWithValue("@BHYT", txbBHYT.Text);
                            cmd.Parameters.AddWithValue("@Phone", txbSDT.Text);
                            cmd.Parameters.AddWithValue("@MaKhoa", txbkhoa.Text);
                            cmd.Parameters.AddWithValue("@MaBacSi", txbBS.Text);
                            cmd.Parameters.AddWithValue("@MaYTa", txbYT.Text);
                            cmd.Parameters.AddWithValue("@MaBenh", txbBenh.Text);

                            cmd.ExecuteNonQuery();
                        }
                }
                string upGB = "UPDATE dbo.Giuongbenh SET Status=1 WHERE MaGiuong=@MaGiuong";
                SqlCommand update = new SqlCommand(upGB, connection);
                update.Parameters.AddWithValue("@MaGiuong",cbGB.Text);
                update.ExecuteNonQuery();
                MessageBox.Show("Thêm bệnh nhân thành công","Thông báo");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây, ví dụ: throw ex; hoặc ghi log lỗi
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }
        public void XoaBenhNhan(TextBox txbid,ComboBox cbGB)
        {
            if (!string.IsNullOrEmpty(txbid.Text))
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False");
                connection.Open();
                string id = txbid.Text;
                string query = $"delete from dbo.Benhnhan where MaBenhNhan={id}";
                SqlCommand delete = new SqlCommand(query, connection);
                delete.ExecuteNonQuery();
                string upGB = "UPDATE dbo.Giuongbenh SET Status=0 WHERE MaGiuong=@MaGiuong";
                SqlCommand update = new SqlCommand(upGB, connection);
                update.Parameters.AddWithValue("@MaGiuong", cbGB.Text);
                update.ExecuteNonQuery();
                MessageBox.Show("Xoá bệnh nhân thành công", "Thông báo");
            }

        }
        public void SuaBenhNhan(TextBox txbid, TextBox txbhoten, ComboBox cbGT, DateTimePicker dtNS, TextBox txbCCCD, TextBox txbBHYT, TextBox txbSDT, DateTimePicker NV, DateTimePicker RV, TextBox txbkhoa, TextBox txbBS, TextBox txbYT, TextBox txbBenh, ComboBox cbGB,ComboBox cbLBN)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False");
                if (string.IsNullOrEmpty(txbid.Text))
                {
                    MessageBox.Show("Vui lòng chọn một bệnh nhân để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                connection.Open();
                if (cbLBN.Text == "Nội Trú") {
                    string query = "UPDATE dbo.Benhnhan SET LBN=@LBN,Name=@Name, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, CCCD=@CCCD, BHYT=@BHYT, Phone=@Phone, NgayNhapVien=@NgayNhapVien, NgayRaVien=@NgayRaVien, MaKhoa=@MaKhoa, MaBacSi=@MaBacSi, MaYTa=@MaYTa, MaBenh=@MaBenh, MaGiuong=@MaGiuong WHERE MaBenhNhan=@id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id",txbid.Text);
                        cmd.Parameters.AddWithValue("@LBN", "0");
                        cmd.Parameters.AddWithValue("@Name", txbhoten.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNS.Value);
                        cmd.Parameters.AddWithValue("@CCCD", txbCCCD.Text);
                        cmd.Parameters.AddWithValue("@BHYT", txbBHYT.Text);
                        cmd.Parameters.AddWithValue("@Phone", txbSDT.Text);
                        cmd.Parameters.AddWithValue("@NgayNhapVien", NV.Value);
                        cmd.Parameters.AddWithValue("@NgayRaVien", RV.Value);
                        cmd.Parameters.AddWithValue("@MaKhoa", txbkhoa.Text);
                        cmd.Parameters.AddWithValue("@MaBacSi", txbBS.Text);
                        cmd.Parameters.AddWithValue("@MaYTa", txbYT.Text);
                        cmd.Parameters.AddWithValue("@MaBenh", txbBenh.Text);
                        cmd.Parameters.AddWithValue("@MaGiuong", cbGB.Text);

                        cmd.ExecuteNonQuery();
                    }
                    string upGB = "UPDATE dbo.Giuongbenh SET Status=1 WHERE MaGiuong=@MaGiuong";
                    SqlCommand update = new SqlCommand(upGB, connection);
                    update.Parameters.AddWithValue("@MaGiuong", cbGB.Text);
                    update.ExecuteNonQuery();
                }
                else
                {
                    string upGB = "UPDATE dbo.Giuongbenh SET Status=0 WHERE MaGiuong=@MaGiuong";
                    SqlCommand update = new SqlCommand(upGB, connection);
                    update.Parameters.AddWithValue("@MaGiuong", cbGB.Text);
                    update.ExecuteNonQuery();
                    string query = "UPDATE dbo.Benhnhan SET LBN=@LBN,Name=@Name, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, CCCD=@CCCD, BHYT=@BHYT, Phone=@Phone, NgayNhapVien=@NgayNhapVien, NgayRaVien=@NgayRaVien, MaKhoa=@MaKhoa, MaBacSi=@MaBacSi, MaYTa=@MaYTa, MaBenh=@MaBenh, MaGiuong=null WHERE MaBenhNhan=@id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", txbid.Text);
                        cmd.Parameters.AddWithValue("@LBN", "1");
                        cmd.Parameters.AddWithValue("@Name", txbhoten.Text);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbGT.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtNS.Value);
                        cmd.Parameters.AddWithValue("@CCCD", txbCCCD.Text);
                        cmd.Parameters.AddWithValue("@BHYT", txbBHYT.Text);
                        cmd.Parameters.AddWithValue("@Phone", txbSDT.Text);
                        cmd.Parameters.AddWithValue("@NgayNhapVien","");
                        cmd.Parameters.AddWithValue("@NgayRaVien","");
                        cmd.Parameters.AddWithValue("@MaKhoa", txbkhoa.Text);
                        cmd.Parameters.AddWithValue("@MaBacSi", txbBS.Text);
                        cmd.Parameters.AddWithValue("@MaYTa", txbYT.Text);
                        cmd.Parameters.AddWithValue("@MaBenh", txbBenh.Text);

                        cmd.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Sửa thông tin bệnh nhân thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi cho người dùng hoặc ghi vào file log
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void TimKiemBN(DataGridView dgv, TextBox txbTK, string MaKhoa)
        {
            if (string.IsNullOrEmpty(txbTK.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã bệnh nhân để thực hiện tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.Benhnhan WHERE MaBenhNhan=@id AND MaKhoa=@MaKhoa";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", txbTK.Text);
                    cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();

                    // Kiểm tra xem có dữ liệu tìm thấy hay không
                    if (dataTable.Rows.Count > 0)
                    {
                        dgv.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân với mã này ở trong khoa này.", "Thông báo");
                    }
                }
            }
        }
    }
}
