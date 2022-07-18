namespace QuanLySinhVien
{
    partial class FormQLSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_LoadNam = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_Giam = new System.Windows.Forms.RadioButton();
            this.radio_Tang = new System.Windows.Forms.RadioButton();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Hinh = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.lb_TinhThanh = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAPHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhập học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm thứ";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(103, 10);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(133, 20);
            this.txt_MaSV.TabIndex = 5;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(103, 41);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(133, 20);
            this.txt_HoTen.TabIndex = 6;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(103, 139);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(52, 20);
            this.txt_Nam.TabIndex = 7;
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(103, 77);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(133, 21);
            this.cb_Khoa.TabIndex = 8;
            this.cb_Khoa.SelectedIndexChanged += new System.EventHandler(this.cb_Khoa_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_LoadNam
            // 
            this.btn_LoadNam.Location = new System.Drawing.Point(161, 137);
            this.btn_LoadNam.Name = "btn_LoadNam";
            this.btn_LoadNam.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadNam.TabIndex = 10;
            this.btn_LoadNam.Text = "Load năm";
            this.btn_LoadNam.UseVisualStyleBackColor = true;
            this.btn_LoadNam.Click += new System.EventHandler(this.btn_LoadNam_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(16, 175);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(302, 175);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 12;
            this.btn_Load.Text = "Load Data";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(207, 175);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhat.TabIndex = 13;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(114, 175);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_Giam);
            this.groupBox1.Controls.Add(this.radio_Tang);
            this.groupBox1.Location = new System.Drawing.Point(262, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // radio_Giam
            // 
            this.radio_Giam.AutoSize = true;
            this.radio_Giam.Location = new System.Drawing.Point(7, 30);
            this.radio_Giam.Name = "radio_Giam";
            this.radio_Giam.Size = new System.Drawing.Size(96, 17);
            this.radio_Giam.TabIndex = 1;
            this.radio_Giam.TabStop = true;
            this.radio_Giam.Text = "Giảm theo năm";
            this.radio_Giam.UseVisualStyleBackColor = true;
            this.radio_Giam.CheckedChanged += new System.EventHandler(this.radio_Giam_CheckedChanged);
            // 
            // radio_Tang
            // 
            this.radio_Tang.AutoSize = true;
            this.radio_Tang.Location = new System.Drawing.Point(7, 8);
            this.radio_Tang.Name = "radio_Tang";
            this.radio_Tang.Size = new System.Drawing.Size(97, 17);
            this.radio_Tang.TabIndex = 0;
            this.radio_Tang.TabStop = true;
            this.radio_Tang.Text = "Tăng theo năm";
            this.radio_Tang.UseVisualStyleBackColor = true;
            this.radio_Tang.CheckedChanged += new System.EventHandler(this.radio_Tang_CheckedChanged);
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(328, 11);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(49, 20);
            this.txt_Dem.TabIndex = 17;
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(262, 10);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(60, 23);
            this.btn_Dem.TabIndex = 18;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(698, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_Hinh
            // 
            this.txt_Hinh.Location = new System.Drawing.Point(698, 9);
            this.txt_Hinh.Name = "txt_Hinh";
            this.txt_Hinh.Size = new System.Drawing.Size(161, 20);
            this.txt_Hinh.TabIndex = 20;
            this.txt_Hinh.Text = "HinhAnh.jpg_png_jpeg....";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(396, 175);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(124, 23);
            this.btn_Tim.TabIndex = 21;
            this.btn_Tim.Text = "Tìm theo ...";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(540, 176);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(138, 20);
            this.txt_Tim.TabIndex = 22;
            this.txt_Tim.Text = "Mã SV hoặc Tên";
            this.txt_Tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Tim.TextChanged += new System.EventHandler(this.txt_Tim_TextChanged);
            // 
            // lb_TinhThanh
            // 
            this.lb_TinhThanh.FormattingEnabled = true;
            this.lb_TinhThanh.Location = new System.Drawing.Point(396, 11);
            this.lb_TinhThanh.Name = "lb_TinhThanh";
            this.lb_TinhThanh.Size = new System.Drawing.Size(124, 147);
            this.lb_TinhThanh.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(540, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(138, 150);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "Ghi chú";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HOTEN,
            this.NGAYNHAPHOC,
            this.MAKHOA,
            this.HINHANH,
            this.NAMTHU,
            this.GHICHU,
            this.QUEQUAN});
            this.dataGridView1.Location = new System.Drawing.Point(16, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 333);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã SV";
            this.MSSV.Name = "MSSV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // NGAYNHAPHOC
            // 
            this.NGAYNHAPHOC.DataPropertyName = "NGAYNHAPHOC";
            this.NGAYNHAPHOC.HeaderText = "Ngày nhập học";
            this.NGAYNHAPHOC.Name = "NGAYNHAPHOC";
            // 
            // MAKHOA
            // 
            this.MAKHOA.DataPropertyName = "MAKHOA";
            this.MAKHOA.HeaderText = "Mã khoa";
            this.MAKHOA.Name = "MAKHOA";
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Hình ảnh";
            this.HINHANH.Name = "HINHANH";
            // 
            // NAMTHU
            // 
            this.NAMTHU.DataPropertyName = "NAMTHU";
            this.NAMTHU.HeaderText = "Năm thứ";
            this.NAMTHU.Name = "NAMTHU";
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.DataPropertyName = "QUEQUAN";
            this.QUEQUAN.HeaderText = "Quê quán";
            this.QUEQUAN.Name = "QUEQUAN";
            // 
            // FormQLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lb_TinhThanh);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Hinh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_LoadNam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_Khoa);
            this.Controls.Add(this.txt_Nam);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLSinhVien";
            this.Text = "FormQLSinhVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLSinhVien_FormClosing_1);
            this.Load += new System.EventHandler(this.FormQLSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_LoadNam;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_Giam;
        private System.Windows.Forms.RadioButton radio_Tang;
        private System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Hinh;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.ListBox lb_TinhThanh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAPHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUEQUAN;
    }
}