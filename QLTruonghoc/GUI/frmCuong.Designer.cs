namespace QLTruonghoc.GUI
{
    partial class frmCuong
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
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.txtTimKiem = new VSCM.Base.Controls.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(13, 13);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(40, 13);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.FieldGroup = "";
            this.txtTimKiem.FieldName = "";
            this.txtTimKiem.Location = new System.Drawing.Point(78, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.AutoHeight = false;
            this.txtTimKiem.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtTimKiem.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTimKiem.Properties.Name = "fProperties";
            this.txtTimKiem.Size = new System.Drawing.Size(150, 21);
            this.txtTimKiem.TabIndex = 1;
            // 
            // frmCuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 341);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.ucLabel1);
            this.Name = "frmCuong";
            this.Text = "Thông tin Nội trú";
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucTextBox txtTimKiem;
    }
}