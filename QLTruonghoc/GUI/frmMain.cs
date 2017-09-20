using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTruonghoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnSinhvien_MouseHover(object sender, EventArgs e)
        {
            btnSinhvien.Font = new Font(btnSinhvien.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btnSinhvien.ForeColor = Color.Red;
            picTip.Image = Properties.Resources.std;
            lblTip.Text = "Trong menu Sinh viên, bạn có thể thêm mới sinh viên, tìm kiếm, cập nhật hoặc xóa thông tin về sinh viên đã có";
        }

        private void btnSinhvien_MouseLeave(object sender, EventArgs e)
        {
            btnSinhvien.Font = new Font(btnSinhvien.Font, FontStyle.Bold);
            btnSinhvien.ForeColor = Color.Blue;
            lblTip.Text = "";
            picTip.Image = null;
        }

        private void btnGiaovien_MouseHover(object sender, EventArgs e)
        {
            btnGiaovien.Font = new Font(btnGiaovien.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btnGiaovien.ForeColor = Color.Red;
            picTip.Image = Properties.Resources.sir;
            lblTip.Text = "Trong menu giáo viên, bạn có thể thêm mới giáo viên, cập nhật hoặc xóa thông tin về giáo viên đã có";
        }

        private void btnGiaovien_MouseLeave(object sender, EventArgs e)
        {
            btnGiaovien.Font = new Font(btnSinhvien.Font, FontStyle.Bold);
            btnGiaovien.ForeColor = Color.Blue;
            lblTip.Text = "";
            picTip.Image = null;
        }
        private void btnMonhoc_MouseHover(object sender, EventArgs e)
        {
            lblTip.Text = "Trong menu Môn học, bạn có thể thêm mới thông tin môn học,tìm kiếm, cập nhật hoặc xóa thông tin môn học đã có";
            picTip.Image = Properties.Resources.Building_Clip_Art;
            btnMonhoc.Font = new Font(btnMonhoc.Font, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
            btnMonhoc.ForeColor = Color.Red;
        }

        private void btnMonhoc_MouseLeave(object sender, EventArgs e)
        {
            btnMonhoc.Font = new Font(btnMonhoc.Font, FontStyle.Bold);
            btnMonhoc.ForeColor = Color.Blue;
            lblTip.Text = "";
            picTip.Image = null;
        }

        private void btnDangky_MouseHover(object sender, EventArgs e)
        {
            btnDangky.Font = new Font(btnDangky.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btnDangky.ForeColor = Color.Red;
            picTip.Image = Properties.Resources.registration;
            lblTip.Text = "Trong menu Đăng ký, bạn có thể xem thông tin về sinh viên và các môn học đã đăng ký";
        }

        private void btnDangky_MouseLeave(object sender, EventArgs e)
        {
            btnDangky.Font = new Font(btnSinhvien.Font, FontStyle.Bold);
            btnDangky.ForeColor = Color.Blue;
            picTip.Image = null;
            lblTip.Text = "";
        }

        private void btnKhoahoc_MouseHover(object sender, EventArgs e)
        {
            btnKhoahoc.Font = new Font(btnKhoahoc.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btnKhoahoc.ForeColor = Color.Red;
            picTip.Image = Properties.Resources.books;
            lblTip.Text = "Trong menu Khóa học, bạn có thể thêm mới khóa học, tìm kiếm, xóa hoặc cập nhật thông tin về khóa học đã có";
        }

        private void btnKhoahoc_MouseLeave(object sender, EventArgs e)
        {
            btnKhoahoc.Font = new Font(btnSinhvien.Font, FontStyle.Bold);
            btnKhoahoc.ForeColor = Color.Blue;
            picTip.Image = null;
            lblTip.Text = "";
        }
        private void btnDangxuat_MouseHover(object sender, EventArgs e)
        {
            btnDangxuat.Font = new Font(btnDangxuat.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            btnDangxuat.ForeColor = Color.Red;
            lblTip.Text = "Click vào đây sẽ trở về cửa sổ đăng nhập";
        }

        private void btnDangxuat_MouseLeave(object sender, EventArgs e)
        {
            btnDangxuat.Font = new Font(btnSinhvien.Font, FontStyle.Bold);
            btnDangxuat.ForeColor = Color.Blue;
            lblTip.Text = "";
        }
        public bool CheckForm(string  arr)
        {
            bool flag = false;
            Form[] array = this.MdiChildren;
            foreach (Form temp in array)
            {
                if (temp.GetType().ToString() == "QLTruonghoc." + arr)
                {
                    flag = true;
                }
            }
            return flag;
        }
        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmThongtinSV"))
            {
                frmThongtinSV sinhVien = new frmThongtinSV();
                sinhVien.MdiParent = this;
                pnlThongtin.Controls.Add(sinhVien);
                sinhVien.Show();
            }
            else
            {
                MessageBox.Show("Menu này đang được sử dụng", "Thông báo");
            }
        }
        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            if (!CheckForm("frmThongtinGV"))
            {
                frmThongtinGV giaoVien = new frmThongtinGV();
                giaoVien.MdiParent = this;
                pnlThongtin.Controls.Add(giaoVien);
                giaoVien.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckForm("department"))
            {
                frmMonhoc dp = new frmMonhoc();
                dp.MdiParent = this;
                dp.Show();
                dp.Location = new System.Drawing.Point(137, 0);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!CheckForm("course"))
            {
                frmKhoahoc c = new frmKhoahoc();
                c.MdiParent = this;
                c.Show();
                c.Location = new System.Drawing.Point(137, 0);
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (!CheckForm("register"))
            {
                frmDangky dKy = new frmDangky();
                dKy.MdiParent = this;
                pnlThongtin.Controls.Add(dKy);
                dKy.Show();
            }
        }

        private void btnKhoahoc_Click(object sender, EventArgs e)
        {
            if (!CheckForm("course"))
            {
                frmKhoahoc khoaHoc = new frmKhoahoc();
                khoaHoc.MdiParent = this;
                pnlThongtin.Controls.Add(khoaHoc);
                khoaHoc.Show();
            }
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            if (!CheckForm("department"))
            {
                frmMonhoc monHoc = new frmMonhoc();
                monHoc.MdiParent = this;
                pnlThongtin.Controls.Add(monHoc);
                monHoc.Show();
            }
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở về cửa sổ đăng nhập?", "Thông báo", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDangnhap f = new frmDangnhap();
                f.Show();
                this.Dispose();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes))
                Application.Exit();
        }
    }
}
