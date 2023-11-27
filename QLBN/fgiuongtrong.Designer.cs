namespace QLBN
{
    partial class fgiuongtrong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnhienthi = new Button();
            flpgiuongtrong = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            txbTenYTa = new TextBox();
            label2 = new Label();
            txbTenBacSi = new TextBox();
            label3 = new Label();
            txbTenBenhNhan = new TextBox();
            txbMaGiuong = new TextBox();
            label6 = new Label();
            txbTenGiuong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnhienthi);
            panel1.Controls.Add(flpgiuongtrong);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 638);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnhienthi
            // 
            btnhienthi.Location = new Point(613, 19);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(150, 46);
            btnhienthi.TabIndex = 2;
            btnhienthi.Text = "Hiển thị ";
            btnhienthi.UseVisualStyleBackColor = true;
            btnhienthi.Click += btnhienthi_Click;
            // 
            // flpgiuongtrong
            // 
            flpgiuongtrong.AutoScroll = true;
            flpgiuongtrong.Location = new Point(3, 82);
            flpgiuongtrong.Name = "flpgiuongtrong";
            flpgiuongtrong.Size = new Size(765, 574);
            flpgiuongtrong.TabIndex = 1;
            flpgiuongtrong.Paint += flpgiuongtrong_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(384, 37);
            label1.TabIndex = 0;
            label1.Text = "Danh sách giường bệnh";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbTenYTa);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbTenBacSi);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txbTenBenhNhan);
            panel2.Controls.Add(txbMaGiuong);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txbTenGiuong);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(800, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 656);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(188, 26);
            label7.Name = "label7";
            label7.Size = new Size(378, 37);
            label7.TabIndex = 21;
            label7.Text = "Thông tin giường bệnh:";
            // 
            // txbTenYTa
            // 
            txbTenYTa.Location = new Point(348, 571);
            txbTenYTa.Name = "txbTenYTa";
            txbTenYTa.Size = new Size(348, 39);
            txbTenYTa.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 120);
            label2.Name = "label2";
            label2.Size = new Size(264, 37);
            label2.TabIndex = 11;
            label2.Text = "ID giường bệnh:";
            // 
            // txbTenBacSi
            // 
            txbTenBacSi.Location = new Point(348, 466);
            txbTenBacSi.Name = "txbTenBacSi";
            txbTenBacSi.Size = new Size(348, 39);
            txbTenBacSi.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 229);
            label3.Name = "label3";
            label3.Size = new Size(290, 37);
            label3.TabIndex = 12;
            label3.Text = "Tên giường bệnh:";
            // 
            // txbTenBenhNhan
            // 
            txbTenBenhNhan.Location = new Point(348, 354);
            txbTenBenhNhan.Name = "txbTenBenhNhan";
            txbTenBenhNhan.Size = new Size(348, 39);
            txbTenBenhNhan.TabIndex = 18;
            // 
            // txbMaGiuong
            // 
            txbMaGiuong.Location = new Point(351, 123);
            txbMaGiuong.Name = "txbMaGiuong";
            txbMaGiuong.Size = new Size(348, 39);
            txbMaGiuong.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 576);
            label6.Name = "label6";
            label6.Size = new Size(302, 37);
            label6.TabIndex = 17;
            label6.Text = "Tên y tá phụ trách:";
            // 
            // txbTenGiuong
            // 
            txbTenGiuong.Location = new Point(351, 230);
            txbTenGiuong.Name = "txbTenGiuong";
            txbTenGiuong.Size = new Size(348, 39);
            txbTenGiuong.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 467);
            label5.Name = "label5";
            label5.Size = new Size(339, 37);
            label5.TabIndex = 16;
            label5.Text = "Tên bác sĩ phụ trách:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 349);
            label4.Name = "label4";
            label4.Size = new Size(252, 37);
            label4.TabIndex = 15;
            label4.Text = "Tên bệnh nhân:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(400, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 39);
            dateTimePicker1.TabIndex = 3;
            // 
            // fgiuongtrong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 686);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fgiuongtrong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giường trống";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private TextBox txbTenYTa;
        private Label label2;
        private TextBox txbTenBacSi;
        private Label label3;
        private TextBox txbTenBenhNhan;
        private TextBox txbMaGiuong;
        private Label label6;
        private TextBox txbTenGiuong;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flpgiuongtrong;
        private Button btnhienthi;
        private DateTimePicker dateTimePicker1;
    }
}