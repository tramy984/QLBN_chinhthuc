﻿using System;
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
    public partial class fTMH : Form
    {
        private ListBenhNhan ListBenhNhan;
        public fTMH()
        {
            InitializeComponent();
            LoadBenhNhanKhoaTMH();
            LoadGB();
            this.ListBenhNhan = new ListBenhNhan();
        }
        void LoadGB()
        {
            string connectionString = "Data Source=.;Initial Catalog=QUANLYBN;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cbGB.Items.Clear();
            string query = "SELECT MaGiuong FROM dbo.Giuongbenh WHERE Status=0";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbGB.Items.Add(reader["MaGiuong"].ToString());
            }
            reader.Close();
            connection.Close();
        }
        private void dtgvkhoaTMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListBenhNhan.LoadDataFromSelectedRow(dtgvkhoaTMH, txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
        }
        void LoadBenhNhanKhoaTMH()
        {
            string query = "SELECT * FROM dbo.Benhnhan Where MaKhoa=17";
            DataProvider provider = new DataProvider();
            dtgvkhoaTMH.DataSource = provider.ExecuteQuery(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ListBenhNhan.XoaBenhNhan(txbid, cbGB);
            LoadBenhNhanKhoaTMH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ListBenhNhan.SuaBenhNhan(txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
            LoadBenhNhanKhoaTMH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListBenhNhan.ThemBenhNhan(txbid, txbhoten, cbGT, DtNgaySinh, txbCCCD, txbBHYT, txbSDT, NgayNhapVien, NgayRaVien, txbkhoa, txbBacsi, txbYta, txbBenh, cbGB, cbLBN);
            LoadBenhNhanKhoaTMH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBill f = new fBill(txbid.Text);
            f.txbGB.Text = cbGB.Text;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ListBenhNhan.TimKiemBN(dtgvkhoaTMH, txbTK, "17");
        }

        private void cbLBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            NgayNhapVien.Visible = true;
            NgayRaVien.Visible = true;
            cbGB.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbTK_TextChanged(object sender, EventArgs e)
        {
            LoadBenhNhanKhoaTMH();
        }
    }
}
