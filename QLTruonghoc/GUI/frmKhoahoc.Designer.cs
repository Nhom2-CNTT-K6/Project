namespace QLTruonghoc
{
    partial class frmKhoahoc
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
            this.lblThongtinKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMotaKH = new System.Windows.Forms.Label();
            this.lblMonhoc = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTieudeKH = new System.Windows.Forms.TextBox();
            this.txtMotaKH = new System.Windows.Forms.TextBox();
            this.ckbXoa = new System.Windows.Forms.CheckBox();
            this.ckbTimkiem = new System.Windows.Forms.CheckBox();
            this.ckbCapnhat = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cmbMKHxoa = new System.Windows.Forms.ComboBox();
            this.ckbMKHxoa = new System.Windows.Forms.CheckBox();
            this.txtMKHxoa = new System.Windows.Forms.TextBox();
            this.lblMKHxoa = new System.Windows.Forms.Label();
            this.lblXoa = new System.Windows.Forms.Label();
            this.cmbMKHtim = new System.Windows.Forms.ComboBox();
            this.ckbMKHtim = new System.Windows.Forms.CheckBox();
            this.txtMKHtim = new System.Windows.Forms.TextBox();
            this.lblMKHtim = new System.Windows.Forms.Label();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.cmbMKHcapnhat = new System.Windows.Forms.ComboBox();
            this.ckbMKHcapnhat = new System.Windows.Forms.CheckBox();
            this.lblMKHcapnhat = new System.Windows.Forms.Label();
            this.txtMKHcapnhat = new System.Windows.Forms.TextBox();
            this.lblCapnhat = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.ckbThem = new System.Windows.Forms.CheckBox();
            this.lblBomon = new System.Windows.Forms.Label();
            this.cmbBomon = new System.Windows.Forms.ComboBox();
            this.lblLuachon = new System.Windows.Forms.Label();
            this.lblThemKH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongtinKH
            // 
            this.lblThongtinKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblThongtinKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongtinKH.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinKH.ForeColor = System.Drawing.Color.Blue;
            this.lblThongtinKH.Location = new System.Drawing.Point(0, 0);
            this.lblThongtinKH.Name = "lblThongtinKH";
            this.lblThongtinKH.Size = new System.Drawing.Size(600, 34);
            this.lblThongtinKH.TabIndex = 0;
            this.lblThongtinKH.Text = "Thông tin khóa học";
            this.lblThongtinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.Color.Blue;
            this.lblMaKH.Location = new System.Drawing.Point(38, 155);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(97, 19);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khóa học";
            this.lblMaKH.Leave += new System.EventHandler(this.label2_Leave);
            // 
            // lblMotaKH
            // 
            this.lblMotaKH.AutoSize = true;
            this.lblMotaKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblMotaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotaKH.ForeColor = System.Drawing.Color.Blue;
            this.lblMotaKH.Location = new System.Drawing.Point(38, 210);
            this.lblMotaKH.Name = "lblMotaKH";
            this.lblMotaKH.Size = new System.Drawing.Size(114, 19);
            this.lblMotaKH.TabIndex = 2;
            this.lblMotaKH.Text = "Mô tả khóa học";
            // 
            // lblMonhoc
            // 
            this.lblMonhoc.AutoSize = true;
            this.lblMonhoc.BackColor = System.Drawing.SystemColors.Control;
            this.lblMonhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonhoc.ForeColor = System.Drawing.Color.Blue;
            this.lblMonhoc.Location = new System.Drawing.Point(38, 183);
            this.lblMonhoc.Name = "lblMonhoc";
            this.lblMonhoc.Size = new System.Drawing.Size(68, 19);
            this.lblMonhoc.TabIndex = 3;
            this.lblMonhoc.Text = "Môn học";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(175, 153);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(153, 26);
            this.txtMaKH.TabIndex = 4;
            this.txtMaKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMaKH.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtTieudeKH
            // 
            this.txtTieudeKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieudeKH.Location = new System.Drawing.Point(175, 182);
            this.txtTieudeKH.Name = "txtTieudeKH";
            this.txtTieudeKH.Size = new System.Drawing.Size(153, 26);
            this.txtTieudeKH.TabIndex = 5;
            this.txtTieudeKH.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txtMotaKH
            // 
            this.txtMotaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotaKH.Location = new System.Drawing.Point(175, 211);
            this.txtMotaKH.Name = "txtMotaKH";
            this.txtMotaKH.Size = new System.Drawing.Size(153, 26);
            this.txtMotaKH.TabIndex = 6;
            this.txtMotaKH.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtMotaKH.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // ckbXoa
            // 
            this.ckbXoa.AutoSize = true;
            this.ckbXoa.BackColor = System.Drawing.SystemColors.Control;
            this.ckbXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbXoa.ForeColor = System.Drawing.Color.Blue;
            this.ckbXoa.Location = new System.Drawing.Point(463, 81);
            this.ckbXoa.Name = "ckbXoa";
            this.ckbXoa.Size = new System.Drawing.Size(55, 23);
            this.ckbXoa.TabIndex = 110;
            this.ckbXoa.Text = "Xóa";
            this.ckbXoa.UseVisualStyleBackColor = false;
            this.ckbXoa.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ckbTimkiem
            // 
            this.ckbTimkiem.AutoSize = true;
            this.ckbTimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.ckbTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTimkiem.ForeColor = System.Drawing.Color.Blue;
            this.ckbTimkiem.Location = new System.Drawing.Point(323, 81);
            this.ckbTimkiem.Name = "ckbTimkiem";
            this.ckbTimkiem.Size = new System.Drawing.Size(91, 23);
            this.ckbTimkiem.TabIndex = 109;
            this.ckbTimkiem.Text = "Tìm kiếm";
            this.ckbTimkiem.UseVisualStyleBackColor = false;
            this.ckbTimkiem.CheckedChanged += new System.EventHandler(this.ckbTimkiem_CheckedChanged);
            // 
            // ckbCapnhat
            // 
            this.ckbCapnhat.AutoSize = true;
            this.ckbCapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.ckbCapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCapnhat.ForeColor = System.Drawing.Color.Blue;
            this.ckbCapnhat.Location = new System.Drawing.Point(189, 81);
            this.ckbCapnhat.Name = "ckbCapnhat";
            this.ckbCapnhat.Size = new System.Drawing.Size(88, 23);
            this.ckbCapnhat.TabIndex = 108;
            this.ckbCapnhat.Text = "Cập nhật";
            this.ckbCapnhat.UseVisualStyleBackColor = false;
            this.ckbCapnhat.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(254, 656);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 41);
            this.btnXoa.TabIndex = 128;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cmbMKHxoa
            // 
            this.cmbMKHxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMKHxoa.FormattingEnabled = true;
            this.cmbMKHxoa.Location = new System.Drawing.Point(442, 604);
            this.cmbMKHxoa.Name = "cmbMKHxoa";
            this.cmbMKHxoa.Size = new System.Drawing.Size(139, 27);
            this.cmbMKHxoa.TabIndex = 127;
            this.cmbMKHxoa.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // ckbMKHxoa
            // 
            this.ckbMKHxoa.AutoSize = true;
            this.ckbMKHxoa.BackColor = System.Drawing.SystemColors.Control;
            this.ckbMKHxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMKHxoa.ForeColor = System.Drawing.Color.Blue;
            this.ckbMKHxoa.Location = new System.Drawing.Point(282, 606);
            this.ckbMKHxoa.Name = "ckbMKHxoa";
            this.ckbMKHxoa.Size = new System.Drawing.Size(152, 23);
            this.ckbMKHxoa.TabIndex = 126;
            this.ckbMKHxoa.Text = "Chọn từ danh sách";
            this.ckbMKHxoa.UseVisualStyleBackColor = false;
            this.ckbMKHxoa.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // txtMKHxoa
            // 
            this.txtMKHxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKHxoa.Location = new System.Drawing.Point(147, 605);
            this.txtMKHxoa.MaxLength = 10;
            this.txtMKHxoa.Name = "txtMKHxoa";
            this.txtMKHxoa.Size = new System.Drawing.Size(121, 26);
            this.txtMKHxoa.TabIndex = 125;
            this.txtMKHxoa.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lblMKHxoa
            // 
            this.lblMKHxoa.AutoSize = true;
            this.lblMKHxoa.BackColor = System.Drawing.SystemColors.Control;
            this.lblMKHxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKHxoa.ForeColor = System.Drawing.Color.Blue;
            this.lblMKHxoa.Location = new System.Drawing.Point(38, 608);
            this.lblMKHxoa.Name = "lblMKHxoa";
            this.lblMKHxoa.Size = new System.Drawing.Size(97, 19);
            this.lblMKHxoa.TabIndex = 124;
            this.lblMKHxoa.Text = "Mã khóa học";
            // 
            // lblXoa
            // 
            this.lblXoa.AutoSize = true;
            this.lblXoa.BackColor = System.Drawing.SystemColors.Control;
            this.lblXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXoa.ForeColor = System.Drawing.Color.Blue;
            this.lblXoa.Location = new System.Drawing.Point(38, 569);
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(123, 22);
            this.lblXoa.TabIndex = 123;
            this.lblXoa.Text = "Xóa khóa học";
            // 
            // cmbMKHtim
            // 
            this.cmbMKHtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMKHtim.FormattingEnabled = true;
            this.cmbMKHtim.Location = new System.Drawing.Point(440, 493);
            this.cmbMKHtim.Name = "cmbMKHtim";
            this.cmbMKHtim.Size = new System.Drawing.Size(141, 27);
            this.cmbMKHtim.TabIndex = 121;
            this.cmbMKHtim.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // ckbMKHtim
            // 
            this.ckbMKHtim.AutoSize = true;
            this.ckbMKHtim.BackColor = System.Drawing.SystemColors.Control;
            this.ckbMKHtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMKHtim.ForeColor = System.Drawing.Color.Blue;
            this.ckbMKHtim.Location = new System.Drawing.Point(282, 495);
            this.ckbMKHtim.Name = "ckbMKHtim";
            this.ckbMKHtim.Size = new System.Drawing.Size(152, 23);
            this.ckbMKHtim.TabIndex = 120;
            this.ckbMKHtim.Text = "Chọn từ danh sách";
            this.ckbMKHtim.UseVisualStyleBackColor = false;
            this.ckbMKHtim.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtMKHtim
            // 
            this.txtMKHtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKHtim.Location = new System.Drawing.Point(147, 493);
            this.txtMKHtim.MaxLength = 10;
            this.txtMKHtim.Name = "txtMKHtim";
            this.txtMKHtim.Size = new System.Drawing.Size(121, 26);
            this.txtMKHtim.TabIndex = 119;
            this.txtMKHtim.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblMKHtim
            // 
            this.lblMKHtim.AutoSize = true;
            this.lblMKHtim.BackColor = System.Drawing.SystemColors.Control;
            this.lblMKHtim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKHtim.ForeColor = System.Drawing.Color.Blue;
            this.lblMKHtim.Location = new System.Drawing.Point(38, 496);
            this.lblMKHtim.Name = "lblMKHtim";
            this.lblMKHtim.Size = new System.Drawing.Size(97, 19);
            this.lblMKHtim.TabIndex = 118;
            this.lblMKHtim.Text = "Mã khóa học";
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.ForeColor = System.Drawing.Color.Blue;
            this.lblTimkiem.Location = new System.Drawing.Point(38, 461);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(123, 22);
            this.lblTimkiem.TabIndex = 117;
            this.lblTimkiem.Text = "Tìm khóa học";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Blue;
            this.btnCapnhat.Location = new System.Drawing.Point(256, 401);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(138, 38);
            this.btnCapnhat.TabIndex = 116;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMKHcapnhat
            // 
            this.cmbMKHcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMKHcapnhat.FormattingEnabled = true;
            this.cmbMKHcapnhat.Location = new System.Drawing.Point(442, 347);
            this.cmbMKHcapnhat.Name = "cmbMKHcapnhat";
            this.cmbMKHcapnhat.Size = new System.Drawing.Size(139, 27);
            this.cmbMKHcapnhat.TabIndex = 115;
            this.cmbMKHcapnhat.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // ckbMKHcapnhat
            // 
            this.ckbMKHcapnhat.AutoSize = true;
            this.ckbMKHcapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.ckbMKHcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMKHcapnhat.ForeColor = System.Drawing.Color.Blue;
            this.ckbMKHcapnhat.Location = new System.Drawing.Point(282, 351);
            this.ckbMKHcapnhat.Name = "ckbMKHcapnhat";
            this.ckbMKHcapnhat.Size = new System.Drawing.Size(152, 23);
            this.ckbMKHcapnhat.TabIndex = 114;
            this.ckbMKHcapnhat.Text = "Chọn từ danh sách";
            this.ckbMKHcapnhat.UseVisualStyleBackColor = false;
            this.ckbMKHcapnhat.CheckedChanged += new System.EventHandler(this.ckbMKH_CheckedChanged);
            // 
            // lblMKHcapnhat
            // 
            this.lblMKHcapnhat.AutoSize = true;
            this.lblMKHcapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.lblMKHcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKHcapnhat.ForeColor = System.Drawing.Color.Blue;
            this.lblMKHcapnhat.Location = new System.Drawing.Point(38, 354);
            this.lblMKHcapnhat.Name = "lblMKHcapnhat";
            this.lblMKHcapnhat.Size = new System.Drawing.Size(97, 19);
            this.lblMKHcapnhat.TabIndex = 113;
            this.lblMKHcapnhat.Text = "Mã khóa học";
            // 
            // txtMKHcapnhat
            // 
            this.txtMKHcapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKHcapnhat.Location = new System.Drawing.Point(147, 350);
            this.txtMKHcapnhat.MaxLength = 10;
            this.txtMKHcapnhat.Name = "txtMKHcapnhat";
            this.txtMKHcapnhat.Size = new System.Drawing.Size(121, 26);
            this.txtMKHcapnhat.TabIndex = 112;
            this.txtMKHcapnhat.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblCapnhat
            // 
            this.lblCapnhat.AutoSize = true;
            this.lblCapnhat.BackColor = System.Drawing.SystemColors.Control;
            this.lblCapnhat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapnhat.ForeColor = System.Drawing.Color.Blue;
            this.lblCapnhat.Location = new System.Drawing.Point(38, 311);
            this.lblCapnhat.Name = "lblCapnhat";
            this.lblCapnhat.Size = new System.Drawing.Size(242, 22);
            this.lblCapnhat.TabIndex = 111;
            this.lblCapnhat.Text = "Cập nhật thông tin khóa học";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(253, 257);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 37);
            this.btnThem.TabIndex = 129;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckbThem
            // 
            this.ckbThem.AutoSize = true;
            this.ckbThem.BackColor = System.Drawing.SystemColors.Control;
            this.ckbThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbThem.ForeColor = System.Drawing.Color.Blue;
            this.ckbThem.Location = new System.Drawing.Point(101, 81);
            this.ckbThem.Name = "ckbThem";
            this.ckbThem.Size = new System.Drawing.Size(66, 23);
            this.ckbThem.TabIndex = 130;
            this.ckbThem.Text = "Thêm";
            this.ckbThem.UseVisualStyleBackColor = false;
            this.ckbThem.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // lblBomon
            // 
            this.lblBomon.AutoSize = true;
            this.lblBomon.BackColor = System.Drawing.SystemColors.Control;
            this.lblBomon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomon.ForeColor = System.Drawing.Color.Blue;
            this.lblBomon.Location = new System.Drawing.Point(364, 157);
            this.lblBomon.Name = "lblBomon";
            this.lblBomon.Size = new System.Drawing.Size(60, 19);
            this.lblBomon.TabIndex = 131;
            this.lblBomon.Text = "Bộ môn";
            // 
            // cmbBomon
            // 
            this.cmbBomon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBomon.FormattingEnabled = true;
            this.cmbBomon.Location = new System.Drawing.Point(442, 154);
            this.cmbBomon.Name = "cmbBomon";
            this.cmbBomon.Size = new System.Drawing.Size(139, 27);
            this.cmbBomon.TabIndex = 132;
            this.cmbBomon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLuachon
            // 
            this.lblLuachon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLuachon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuachon.ForeColor = System.Drawing.Color.Blue;
            this.lblLuachon.Location = new System.Drawing.Point(0, 34);
            this.lblLuachon.Name = "lblLuachon";
            this.lblLuachon.Size = new System.Drawing.Size(600, 33);
            this.lblLuachon.TabIndex = 133;
            this.lblLuachon.Text = "Lựa chọn phương thức và nhập đầy đủ thông tin";
            this.lblLuachon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThemKH
            // 
            this.lblThemKH.AutoSize = true;
            this.lblThemKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemKH.ForeColor = System.Drawing.Color.Blue;
            this.lblThemKH.Location = new System.Drawing.Point(38, 118);
            this.lblThemKH.Name = "lblThemKH";
            this.lblThemKH.Size = new System.Drawing.Size(214, 22);
            this.lblThemKH.TabIndex = 134;
            this.lblThemKH.Text = "Thêm thông tin khóa học";
            // 
            // frmKhoahoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 769);
            this.Controls.Add(this.lblThemKH);
            this.Controls.Add(this.lblLuachon);
            this.Controls.Add(this.cmbBomon);
            this.Controls.Add(this.lblBomon);
            this.Controls.Add(this.ckbThem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cmbMKHxoa);
            this.Controls.Add(this.ckbMKHxoa);
            this.Controls.Add(this.txtMKHxoa);
            this.Controls.Add(this.lblMKHxoa);
            this.Controls.Add(this.lblXoa);
            this.Controls.Add(this.cmbMKHtim);
            this.Controls.Add(this.ckbMKHtim);
            this.Controls.Add(this.txtMKHtim);
            this.Controls.Add(this.lblMKHtim);
            this.Controls.Add(this.lblTimkiem);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.cmbMKHcapnhat);
            this.Controls.Add(this.ckbMKHcapnhat);
            this.Controls.Add(this.lblMKHcapnhat);
            this.Controls.Add(this.txtMKHcapnhat);
            this.Controls.Add(this.lblCapnhat);
            this.Controls.Add(this.ckbXoa);
            this.Controls.Add(this.ckbTimkiem);
            this.Controls.Add(this.ckbCapnhat);
            this.Controls.Add(this.txtMotaKH);
            this.Controls.Add(this.txtTieudeKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblMonhoc);
            this.Controls.Add(this.lblMotaKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblThongtinKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmKhoahoc";
            this.Text = "Thông tin về khóa học";
            this.Load += new System.EventHandler(this.course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongtinKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMotaKH;
        private System.Windows.Forms.Label lblMonhoc;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTieudeKH;
        private System.Windows.Forms.TextBox txtMotaKH;
        private System.Windows.Forms.CheckBox ckbXoa;
        private System.Windows.Forms.CheckBox ckbTimkiem;
        private System.Windows.Forms.CheckBox ckbCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmbMKHxoa;
        private System.Windows.Forms.CheckBox ckbMKHxoa;
        private System.Windows.Forms.TextBox txtMKHxoa;
        private System.Windows.Forms.Label lblMKHxoa;
        private System.Windows.Forms.Label lblXoa;
        private System.Windows.Forms.ComboBox cmbMKHtim;
        private System.Windows.Forms.CheckBox ckbMKHtim;
        private System.Windows.Forms.TextBox txtMKHtim;
        private System.Windows.Forms.Label lblMKHtim;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.ComboBox cmbMKHcapnhat;
        private System.Windows.Forms.CheckBox ckbMKHcapnhat;
        private System.Windows.Forms.Label lblMKHcapnhat;
        private System.Windows.Forms.TextBox txtMKHcapnhat;
        private System.Windows.Forms.Label lblCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox ckbThem;
        private System.Windows.Forms.Label lblBomon;
        private System.Windows.Forms.ComboBox cmbBomon;
        private System.Windows.Forms.Label lblLuachon;
        private System.Windows.Forms.Label lblThemKH;
    }
}