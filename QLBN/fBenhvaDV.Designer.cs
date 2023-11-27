namespace QLBN
{
    partial class fBenhvaDV
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
            Benh = new TabControl();
            tabPage3 = new TabPage();
            btnTK = new Button();
            txbTK = new TextBox();
            btnThem = new Button();
            panel1 = new Panel();
            txbTC = new TextBox();
            label1 = new Label();
            panel15 = new Panel();
            txbBenh = new TextBox();
            label14 = new Label();
            dtgvBenh = new DataGridView();
            tabPage4 = new TabPage();
            panel3 = new Panel();
            txbGTien = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            txbDV = new TextBox();
            label2 = new Label();
            dtgvDV = new DataGridView();
            Benh.SuspendLayout();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBenh).BeginInit();
            tabPage4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDV).BeginInit();
            SuspendLayout();
            // 
            // Benh
            // 
            Benh.Controls.Add(tabPage3);
            Benh.Controls.Add(tabPage4);
            Benh.Location = new Point(12, 12);
            Benh.Name = "Benh";
            Benh.SelectedIndex = 0;
            Benh.Size = new Size(1310, 676);
            Benh.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnTK);
            tabPage3.Controls.Add(txbTK);
            tabPage3.Controls.Add(btnThem);
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(panel15);
            tabPage3.Controls.Add(dtgvBenh);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1294, 622);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Bệnh";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            btnTK.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.Location = new Point(1003, 528);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(228, 63);
            btnTK.TabIndex = 29;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = true;
            btnTK.Click += button1_Click;
            // 
            // txbTK
            // 
            txbTK.Location = new Point(629, 528);
            txbTK.Multiline = true;
            txbTK.Name = "txbTK";
            txbTK.Size = new Size(317, 63);
            txbTK.TabIndex = 28;
            txbTK.TextChanged += txbTK_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(1003, 430);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(228, 56);
            btnThem.TabIndex = 27;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTC);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(615, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 272);
            panel1.TabIndex = 26;
            // 
            // txbTC
            // 
            txbTC.Location = new Point(40, 90);
            txbTC.Multiline = true;
            txbTC.Name = "txbTC";
            txbTC.Size = new Size(576, 150);
            txbTC.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 5;
            label1.Text = "Triệu chứng:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbBenh);
            panel15.Controls.Add(label14);
            panel15.Location = new Point(615, 22);
            panel15.Margin = new Padding(5);
            panel15.Name = "panel15";
            panel15.Size = new Size(652, 104);
            panel15.TabIndex = 25;
            // 
            // txbBenh
            // 
            txbBenh.Location = new Point(201, 35);
            txbBenh.Margin = new Padding(5);
            txbBenh.Name = "txbBenh";
            txbBenh.Size = new Size(415, 39);
            txbBenh.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(5, 34);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(168, 37);
            label14.TabIndex = 1;
            label14.Text = "Tên bệnh:";
            // 
            // dtgvBenh
            // 
            dtgvBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBenh.Location = new Point(12, 3);
            dtgvBenh.Name = "dtgvBenh";
            dtgvBenh.RowHeadersWidth = 82;
            dtgvBenh.RowTemplate.Height = 41;
            dtgvBenh.Size = new Size(580, 616);
            dtgvBenh.TabIndex = 0;
            dtgvBenh.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel3);
            tabPage4.Controls.Add(panel2);
            tabPage4.Controls.Add(dtgvDV);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1294, 622);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Dịch vụ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbGTien);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(615, 221);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(652, 104);
            panel3.TabIndex = 26;
            // 
            // txbGTien
            // 
            txbGTien.Location = new Point(201, 35);
            txbGTien.Margin = new Padding(5);
            txbGTien.Name = "txbGTien";
            txbGTien.Size = new Size(415, 39);
            txbGTien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 34);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 37);
            label3.TabIndex = 1;
            label3.Text = "Giá tiền:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbDV);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(615, 107);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 104);
            panel2.TabIndex = 26;
            panel2.Paint += panel2_Paint;
            // 
            // txbDV
            // 
            txbDV.Location = new Point(227, 35);
            txbDV.Margin = new Padding(5);
            txbDV.Name = "txbDV";
            txbDV.Size = new Size(389, 39);
            txbDV.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 34);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 1;
            label2.Text = "Tên Dịch Vụ:";
            // 
            // dtgvDV
            // 
            dtgvDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDV.Location = new Point(3, 14);
            dtgvDV.Name = "dtgvDV";
            dtgvDV.RowHeadersWidth = 82;
            dtgvDV.RowTemplate.Height = 41;
            dtgvDV.Size = new Size(580, 497);
            dtgvDV.TabIndex = 1;
            dtgvDV.CellContentClick += dtgvDV_CellContentClick;
            // 
            // fBenhvaDV
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 700);
            Controls.Add(Benh);
            Name = "fBenhvaDV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bệnh và dịch vụ";
            Benh.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBenh).EndInit();
            tabPage4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Benh;
        private TabPage tabPage3;
        private DataGridView dtgvBenh;
        private TabPage tabPage4;
        private Panel panel15;
        public TextBox txbBenh;
        private Label label14;
        private Panel panel1;
        private TextBox txbTC;
        private Label label1;
        private Panel panel2;
        public TextBox txbDV;
        private Label label2;
        private DataGridView dtgvDV;
        private Panel panel3;
        public TextBox txbGTien;
        private Label label3;
        private Button btnThem;
        private Button btnTK;
        private TextBox txbTK;
    }
}