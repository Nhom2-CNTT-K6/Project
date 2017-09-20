namespace QLTruonghoc
{
    partial class frmDangky
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
            this.lblDanhsach = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTen = new System.Windows.Forms.Label();
            this.ckbLocten = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhsach
            // 
            this.lblDanhsach.BackColor = System.Drawing.SystemColors.Control;
            this.lblDanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhsach.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhsach.ForeColor = System.Drawing.Color.Blue;
            this.lblDanhsach.Location = new System.Drawing.Point(0, 0);
            this.lblDanhsach.Name = "lblDanhsach";
            this.lblDanhsach.Size = new System.Drawing.Size(622, 42);
            this.lblDanhsach.TabIndex = 0;
            this.lblDanhsach.Text = "Danh sách sinh viên đã đăng ký môn học";
            this.lblDanhsach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(194, 57);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(131, 26);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 445);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.SystemColors.Control;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Blue;
            this.lblTen.Location = new System.Drawing.Point(90, 60);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(98, 19);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên sinh viên";
            // 
            // ckbLocten
            // 
            this.ckbLocten.AutoSize = true;
            this.ckbLocten.BackColor = System.Drawing.SystemColors.Control;
            this.ckbLocten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLocten.ForeColor = System.Drawing.Color.Blue;
            this.ckbLocten.Location = new System.Drawing.Point(393, 59);
            this.ckbLocten.Name = "ckbLocten";
            this.ckbLocten.Size = new System.Drawing.Size(111, 23);
            this.ckbLocten.TabIndex = 5;
            this.ckbLocten.Text = "Lọc theo tên";
            this.ckbLocten.UseVisualStyleBackColor = false;
            this.ckbLocten.CheckedChanged += new System.EventHandler(this.ckbLocten_CheckedChanged);
            // 
            // frmDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 640);
            this.Controls.Add(this.ckbLocten);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblDanhsach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đăng ký môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhsach;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.CheckBox ckbLocten;
    }
}