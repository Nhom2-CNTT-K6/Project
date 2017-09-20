namespace QLTruonghoc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.picTip = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnKhoahoc = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.btnSinhvien = new System.Windows.Forms.Button();
            this.pnlThongtin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picTip)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(160, 51);
            this.lblMenu.TabIndex = 9;
            this.lblMenu.Text = "MENU";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTip
            // 
            this.lblTip.BackColor = System.Drawing.SystemColors.Control;
            this.lblTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTip.Location = new System.Drawing.Point(0, 324);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(160, 164);
            this.lblTip.TabIndex = 11;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picTip
            // 
            this.picTip.BackColor = System.Drawing.SystemColors.Control;
            this.picTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picTip.Location = new System.Drawing.Point(0, 488);
            this.picTip.Name = "picTip";
            this.picTip.Size = new System.Drawing.Size(160, 281);
            this.picTip.TabIndex = 12;
            this.picTip.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.Controls.Add(this.btnDangxuat);
            this.pnlMenu.Controls.Add(this.btnKhoahoc);
            this.pnlMenu.Controls.Add(this.btnDangky);
            this.pnlMenu.Controls.Add(this.btnMonhoc);
            this.pnlMenu.Controls.Add(this.lblTip);
            this.pnlMenu.Controls.Add(this.btnGiaovien);
            this.pnlMenu.Controls.Add(this.btnSinhvien);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Controls.Add(this.picTip);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(160, 769);
            this.pnlMenu.TabIndex = 13;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangxuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.Blue;
            this.btnDangxuat.Location = new System.Drawing.Point(0, 244);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(160, 38);
            this.btnDangxuat.TabIndex = 18;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            this.btnDangxuat.MouseLeave += new System.EventHandler(this.btnDangxuat_MouseLeave);
            this.btnDangxuat.MouseHover += new System.EventHandler(this.btnDangxuat_MouseHover);
            // 
            // btnKhoahoc
            // 
            this.btnKhoahoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoahoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoahoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoahoc.ForeColor = System.Drawing.Color.Blue;
            this.btnKhoahoc.Location = new System.Drawing.Point(0, 206);
            this.btnKhoahoc.Name = "btnKhoahoc";
            this.btnKhoahoc.Size = new System.Drawing.Size(160, 38);
            this.btnKhoahoc.TabIndex = 17;
            this.btnKhoahoc.Text = "Khóa học";
            this.btnKhoahoc.UseVisualStyleBackColor = true;
            this.btnKhoahoc.Click += new System.EventHandler(this.btnKhoahoc_Click);
            this.btnKhoahoc.MouseLeave += new System.EventHandler(this.btnKhoahoc_MouseLeave);
            this.btnKhoahoc.MouseHover += new System.EventHandler(this.btnKhoahoc_MouseHover);
            // 
            // btnDangky
            // 
            this.btnDangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangky.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangky.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.Color.Blue;
            this.btnDangky.Location = new System.Drawing.Point(0, 168);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(160, 38);
            this.btnDangky.TabIndex = 16;
            this.btnDangky.Text = "Danh sách SV";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            this.btnDangky.MouseLeave += new System.EventHandler(this.btnDangky_MouseLeave);
            this.btnDangky.MouseHover += new System.EventHandler(this.btnDangky_MouseHover);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonhoc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonhoc.ForeColor = System.Drawing.Color.Blue;
            this.btnMonhoc.Location = new System.Drawing.Point(0, 130);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.Size = new System.Drawing.Size(160, 38);
            this.btnMonhoc.TabIndex = 15;
            this.btnMonhoc.Text = "Môn học";
            this.btnMonhoc.UseVisualStyleBackColor = true;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            this.btnMonhoc.MouseLeave += new System.EventHandler(this.btnMonhoc_MouseLeave);
            this.btnMonhoc.MouseHover += new System.EventHandler(this.btnMonhoc_MouseHover);
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaovien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaovien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaovien.ForeColor = System.Drawing.Color.Blue;
            this.btnGiaovien.Location = new System.Drawing.Point(0, 89);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Size = new System.Drawing.Size(160, 41);
            this.btnGiaovien.TabIndex = 14;
            this.btnGiaovien.Text = "Giáo viên";
            this.btnGiaovien.UseVisualStyleBackColor = true;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            this.btnGiaovien.MouseLeave += new System.EventHandler(this.btnGiaovien_MouseLeave);
            this.btnGiaovien.MouseHover += new System.EventHandler(this.btnGiaovien_MouseHover);
            // 
            // btnSinhvien
            // 
            this.btnSinhvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinhvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhvien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhvien.ForeColor = System.Drawing.Color.Blue;
            this.btnSinhvien.Location = new System.Drawing.Point(0, 51);
            this.btnSinhvien.Name = "btnSinhvien";
            this.btnSinhvien.Size = new System.Drawing.Size(160, 38);
            this.btnSinhvien.TabIndex = 13;
            this.btnSinhvien.Text = "Sinh viên";
            this.btnSinhvien.UseVisualStyleBackColor = true;
            this.btnSinhvien.Click += new System.EventHandler(this.btnSinhvien_Click);
            this.btnSinhvien.MouseLeave += new System.EventHandler(this.btnSinhvien_MouseLeave);
            this.btnSinhvien.MouseHover += new System.EventHandler(this.btnSinhvien_MouseHover);
            // 
            // pnlThongtin
            // 
            this.pnlThongtin.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongtin.Location = new System.Drawing.Point(160, 0);
            this.pnlThongtin.Name = "pnlThongtin";
            this.pnlThongtin.Size = new System.Drawing.Size(590, 769);
            this.pnlThongtin.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 769);
            this.Controls.Add(this.pnlThongtin);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Giao diện chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picTip)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox picTip;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSinhvien;
        private System.Windows.Forms.Panel pnlThongtin;
        private System.Windows.Forms.Button btnKhoahoc;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnMonhoc;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Button btnDangxuat;
    }
}