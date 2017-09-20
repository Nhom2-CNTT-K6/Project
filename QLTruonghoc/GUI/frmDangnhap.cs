using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QLTruonghoc
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();

        }

        public OleDbConnection con = new OleDbConnection();
        public bool layGiaTri(string com)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= E:\QLTruonghoc\CSDL.accdb;Persist Security Info=False";
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = com;
            //OleDbDataAdapter data = new OleDbDataAdapter(com, con);
            OleDbDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                if (txtTendangnhap.Text.Trim() == data["usr"].ToString().Trim() && txtMatkhau.Text.Trim() == data["pw"].ToString().Trim())
                {
                    return true;
                    break;
                }
            }
            con.Close();
            return false;
        }
        private void dangnhap()
        {
            string ten, mk;
            ten = txtTendangnhap.Text;
            mk = txtMatkhau.Text;
            if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Tên không được trống");
                txtTendangnhap.Focus();
                return;
            }
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống");
                txtMatkhau.Focus();
                return;
            }
            if (ten != "")
            {
                //object Q = layGiaTri("SELECT usr, pw FROM account");

                if (!layGiaTri("SELECT usr, pw FROM account"))
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Lỗi đăng nhập");
                    txtMatkhau.Text = "";
                    txtMatkhau.Focus();
                }
                else
                {
                    frmMain main = new frmMain();
                    main.Show();
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
        /*private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "" || txtMatkhau.Text == "")
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống","Lỗi đăng nhập");
            else
            if (txtTendangnhap.Text == "admin" && txtMatkhau.Text == "123")
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Lỗi đăng nhập");
            }

        }*/

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
