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
    public partial class frmKhoahoc : Form
    {
        public frmKhoahoc()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection();


        private void course_Load(object sender, EventArgs e)
        {

            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QLTruonghoc\CSDL.accdb;Persist Security Info=False";
            con.Open();

            btnThem.Enabled = false;
            cmbBomon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMKHcapnhat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMKHtim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMKHxoa.DropDownStyle = ComboBoxStyle.DropDownList;
            //Update
            txtMKHcapnhat.Enabled = false;
            ckbMKHcapnhat.Enabled = false;
            cmbMKHcapnhat.Enabled = false;
            btnCapnhat.Enabled = false;
            //Search
            txtMKHtim.Enabled = false;
            ckbMKHtim.Enabled = false;
            cmbMKHtim.Enabled = false;
            //Delete
            txtMKHxoa.Enabled = false;
            cmbMKHxoa.Enabled = false;
            btnXoa.Enabled = false;
            ckbMKHxoa.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Update
            if (ckbCapnhat.Checked == true)
            {
                txtMaKH.Enabled = false;
                txtTieudeKH.Enabled = true;
                txtMotaKH.Enabled = true;
                //Add checkbox
                ckbThem.Checked = false;
                txtMKHcapnhat.Enabled = true;
                ckbMKHcapnhat.Enabled = true;
                cmbMKHcapnhat.Enabled = false;
                btnCapnhat.Enabled = true;
                //Search
                txtMKHtim.Enabled = false;
                ckbMKHtim.Enabled = false;
                cmbMKHtim.Enabled = false;
                //Delete
                txtMKHxoa.Enabled = false;
                cmbMKHxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbMKHxoa.Enabled = false;
                //Check boxes
                ckbTimkiem.Checked = false;
                ckbXoa.Checked = false;
            }
            else
            {
                txtMKHcapnhat.Enabled = false;
                ckbMKHcapnhat.Enabled = false;
                cmbMKHcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
            }
        }

        private void ckbTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTimkiem.Checked == true)
            {

                //Add checkbox
                ckbThem.Checked = false;
                txtMKHtim.Enabled = true;
                ckbMKHtim.Enabled = true;
                cmbMKHtim.Enabled = false;
                //Update
                txtMKHcapnhat.Enabled = false;
                ckbMKHcapnhat.Enabled = false;
                cmbMKHcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                //Delete  
                txtMKHxoa.Enabled = false;
                cmbMKHxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbMKHxoa.Enabled = false;
                //Check boxes
                ckbCapnhat.Checked = false;
                ckbXoa.Checked = false;
            }
            else
            {
                txtMKHtim.Enabled = false;
                ckbMKHtim.Enabled = false;
                cmbMKHtim.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //Delete
            if (ckbXoa.Checked == true)
            {
                txtMaKH.Enabled = false;
                txtTieudeKH.Enabled = false;
                txtMotaKH.Enabled = false;


                //Add checkbox
                ckbThem.Checked = false;
                txtMKHxoa.Enabled = true;
                cmbMKHxoa.Enabled = false;
                btnXoa.Enabled = true;
                ckbMKHxoa.Enabled = true;
                //Update
                txtMKHcapnhat.Enabled = false;
                ckbMKHcapnhat.Enabled = false;
                cmbMKHcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                //Search
                txtMKHtim.Enabled = false;
                ckbMKHtim.Enabled = false;
                cmbMKHtim.Enabled = false;
                //check boxes
                ckbCapnhat.Checked = false;
                ckbTimkiem.Checked = false;
            }
            else
            {
                txtMKHxoa.Enabled = false;
                cmbMKHxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbMKHxoa.Enabled = false;
            }
        }

        private void ckbMKH_CheckedChanged(object sender, EventArgs e)
        {
            cmbMKHcapnhat.Items.Clear();

            if (ckbMKHcapnhat.Checked == true)
            {
                //Update Checkbox
                txtMKHcapnhat.Enabled = false;
                cmbMKHcapnhat.Enabled = true;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select courseid from course";
                OleDbDataReader Cread = com.ExecuteReader();
                while (Cread.Read())
                {
                    cmbMKHcapnhat.Items.Add(Cread["courseid"].ToString());
                }
            }
            else
            {
                txtMKHcapnhat.Enabled = true;
                cmbMKHcapnhat.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMKHtim.Checked == true)
            {
                //Check box with database
                txtMKHtim.Enabled = false;
                cmbMKHtim.Enabled = true;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select courseid from course";
                OleDbDataReader Cread = com.ExecuteReader();
                while (Cread.Read())
                {
                    cmbMKHtim.Items.Add(Cread["courseid"].ToString());
                }
            }
            else
            {
                txtMKHtim.Enabled = true;
                cmbMKHtim.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMKHxoa.Checked == true)
            {
                //Check box with database
                //Delete Checkbox
                txtMKHxoa.Enabled = false;
                cmbMKHxoa.Enabled = true;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select courseid from course";
                OleDbDataReader Cread = com.ExecuteReader();
                while (Cread.Read())
                {
                    cmbMKHxoa.Items.Add(Cread["courseid"].ToString());
                }
            }
            else
            {
                txtMKHxoa.Enabled = true;
                cmbMKHxoa.Enabled = false;
            }
        }

        private void label2_Leave(object sender, EventArgs e)
        {
            string input = txtMaKH.Text;
            try
            {
                long id = long.Parse(input);
                lblMaKH.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtMaKH.Focus();
                lblMaKH.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string input = txtTieudeKH.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) || input[i] == ' ')
                    count++;
            }
            if (count == input.Length)
            {
                lblMonhoc.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtTieudeKH.Focus();
                lblMonhoc.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string input = txtMotaKH.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) || input[i] == ' ')
                    count++;
            }
            if (count == input.Length)
            {
                lblMotaKH.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtMotaKH.Focus();
                lblMotaKH.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string input = txtMaKH.Text;
            try
            {
                long id = long.Parse(input);
                lblMaKH.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtMaKH.Focus();
                lblMaKH.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMaKH.Enabled = false;
            cmbBomon.Items.Clear();
            if (txtMKHcapnhat.Text != "")
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "Select deptid, dname from department";
                OleDbDataReader Dread = com1.ExecuteReader();
                com.CommandText = "select c.courseid as cid, c.coursetitle as cName, c.coursedesc as cDesc, c.deptid as cDeptid from course c, department d where  d.deptid = c.deptid";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtMKHcapnhat.Text == fread["cid"].ToString())
                    {
                        txtMaKH.Text = fread["cid"].ToString();
                        txtTieudeKH.Text = fread["cName"].ToString();
                        txtMotaKH.Text = fread["Cdesc"].ToString();
                        while (Dread.Read())
                        {
                            if (fread["cDeptid"].ToString() == Dread["deptid"].ToString())
                            {
                                cmbBomon.Items.Add(Dread["dname"].ToString());
                                cmbBomon.SelectedIndex = 0;
                                break;
                            }
                        }

                        lblMKHcapnhat.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaKH.Text = "";
                        txtTieudeKH.Text = "";
                        txtMotaKH.Text = "";
                        cmbBomon.SelectedItem = null;
                        lblMKHcapnhat.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTieudeKH.Enabled = false;
            txtMotaKH.Enabled = false;
            cmbBomon.Items.Clear();
            if (txtMKHtim.Text != "")
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "Select deptid, dname from department";
                OleDbDataReader Dread = com1.ExecuteReader();
                com.CommandText = "select c.courseid as cid, c.coursetitle as cName, c.coursedesc as cDesc, c.deptid as cDeptid from course c, department d where  d.deptid = c.deptid";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtMKHtim.Text == fread["cid"].ToString())
                    {
                        txtMaKH.Text = fread["cid"].ToString();
                        txtTieudeKH.Text = fread["cName"].ToString();
                        txtMotaKH.Text = fread["Cdesc"].ToString();
                        while (Dread.Read())
                        {
                            if (fread["cDeptid"].ToString() == Dread["deptid"].ToString())
                            {
                                cmbBomon.Items.Add(Dread["dname"].ToString());
                                cmbBomon.SelectedIndex = 0;
                                break;
                            }
                        }

                        lblMKHtim.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaKH.Text = "";
                        txtTieudeKH.Text = "";
                        txtMotaKH.Text = "";
                        cmbBomon.SelectedItem = null;
                        lblMKHtim.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;

            txtTieudeKH.Enabled = false;
            txtMotaKH.Enabled = false;
            cmbBomon.Items.Clear();
            if (txtMKHxoa.Text != "")
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "Select deptid, dname from department";
                OleDbDataReader Dread = com1.ExecuteReader();
                com.CommandText = "select c.courseid as cid, c.coursetitle as cName, c.coursedesc as cDesc, c.deptid as cDeptid from course c, department d where  d.deptid = c.deptid";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtMKHxoa.Text == fread["cid"].ToString())
                    {
                        txtMaKH.Text = fread["cid"].ToString();
                        txtTieudeKH.Text = fread["cName"].ToString();
                        txtMotaKH.Text = fread["Cdesc"].ToString();
                        while (Dread.Read())
                        {
                            if (fread["cDeptid"].ToString() == Dread["deptid"].ToString())
                            {
                                cmbBomon.Items.Add(Dread["dname"].ToString());
                                cmbBomon.SelectedIndex = 0;
                                break;
                            }
                        }

                        lblMKHxoa.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaKH.Text = "";
                        txtTieudeKH.Text = "";
                        txtMotaKH.Text = "";
                        cmbBomon.SelectedItem = null;
                        lblMKHxoa.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbThem.Checked == true)
            {
                cmbBomon.Items.Clear();
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select dname from department ";
                OleDbDataReader cRead = com.ExecuteReader();
                while (cRead.Read())
                {
                    cmbBomon.Items.Add(cRead["dname"].ToString());
                }
                txtMaKH.Enabled = true;
                txtTieudeKH.Enabled = true;
                txtMotaKH.Enabled = true;
                ckbCapnhat.Checked = false;
                ckbTimkiem.Checked = false;
                ckbXoa.Checked = false;
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                cmbBomon.Items.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            bool flag = false;
            com.CommandText = "Select courseid from course";
            OleDbDataReader cRead = com.ExecuteReader();
            while (cRead.Read())
            {
                if (txtMaKH.Text == cRead["courseid"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                lblMaKH.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMaKH.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txtMaKH.Text != "" && txtTieudeKH.Text != "" && txtMotaKH.Text != "" && cmbBomon.SelectedItem != null)
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select deptid,dname from department";
                OleDbDataReader cRead = com.ExecuteReader();
                while (cRead.Read())
                {
                    if (cmbBomon.SelectedItem.ToString() == cRead["dname"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    OleDbCommand com1 = new OleDbCommand();
                    com1.Connection = con;
                    try
                    {
                        com1.CommandText = "Insert into Course(courseid,deptid,coursetitle,coursedesc) values(" + int.Parse(txtMaKH.Text) + "," + int.Parse(cRead["deptid"].ToString()) + ",'" + txtTieudeKH.Text + "','" + txtMotaKH.Text + "')";
                        com1.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");
                    }
                    catch
                    {
                        MessageBox.Show("Can not be added");
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMaKH.Enabled = false;
            cmbBomon.Items.Clear();
            if (cmbMKHcapnhat.SelectedItem != null)
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "Select deptid, dname from department";
                OleDbDataReader Dread = com1.ExecuteReader();
                com.CommandText = "select c.courseid as cid, c.coursetitle as cName, c.coursedesc as cDesc, c.deptid as cDeptid from course c, department d where  d.deptid = c.deptid";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (cmbMKHcapnhat.SelectedItem.ToString() == fread["cid"].ToString())
                    {
                        txtMaKH.Text = fread["cid"].ToString();
                        txtTieudeKH.Text = fread["cName"].ToString();
                        txtMotaKH.Text = fread["Cdesc"].ToString();
                        while (Dread.Read())
                        {
                            if (fread["cDeptid"].ToString() == Dread["deptid"].ToString())
                            {
                                cmbBomon.Items.Add(Dread["dname"].ToString());
                                cmbBomon.SelectedIndex = 0;
                                break;
                            }
                        }

                        lblMKHcapnhat.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaKH.Text = "";
                        txtTieudeKH.Text = "";
                        txtMotaKH.Text = "";
                        cmbBomon.SelectedItem = null;
                        lblMKHcapnhat.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMaKH.Enabled = false;
            cmbBomon.Items.Clear();
            if (cmbMKHtim.SelectedItem != null)
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "Select deptid, dname from department";
                OleDbDataReader Dread = com1.ExecuteReader();
                com.CommandText = "select c.courseid as cid, c.coursetitle as cName, c.coursedesc as cDesc, c.deptid as cDeptid from course c, department d where  d.deptid = c.deptid";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (cmbMKHtim.SelectedItem.ToString() == fread["cid"].ToString())
                    {
                        txtMaKH.Text = fread["cid"].ToString();
                        txtTieudeKH.Text = fread["cName"].ToString();
                        txtMotaKH.Text = fread["Cdesc"].ToString();
                        while (Dread.Read())
                        {
                            if (fread["cDeptid"].ToString() == Dread["deptid"].ToString())
                            {
                                cmbBomon.Items.Add(Dread["dname"].ToString());
                                cmbBomon.SelectedIndex = 0;
                                break;
                            }
                        }

                        lblMKHtim.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaKH.Text = "";
                        txtTieudeKH.Text = "";
                        txtMotaKH.Text = "";
                        cmbBomon.SelectedItem = null;
                        lblMKHtim.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMaKH.Enabled = false;
            cmbBomon.Items.Clear();
            if (cmbMKHxoa.SelectedItem != null)
            {
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "Select deptid, dname from department";
                OleDbDataReader Dread = com1.ExecuteReader();
                com.CommandText = "select c.courseid as cid, c.coursetitle as cName, c.coursedesc as cDesc, c.deptid as cDeptid from course c, department d where  d.deptid = c.deptid";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (cmbMKHxoa.SelectedItem.ToString() == fread["cid"].ToString())
                    {
                        txtMaKH.Text = fread["cid"].ToString();
                        txtTieudeKH.Text = fread["cName"].ToString();
                        txtMotaKH.Text = fread["Cdesc"].ToString();
                        while (Dread.Read())
                        {
                            if (fread["cDeptid"].ToString() == Dread["deptid"].ToString())
                            {
                                cmbBomon.Items.Add(Dread["dname"].ToString());
                                cmbBomon.SelectedIndex = 0;
                                break;
                            }
                        }

                        lblMKHxoa.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaKH.Text = "";
                        txtTieudeKH.Text = "";
                        txtMotaKH.Text = "";
                        cmbBomon.SelectedItem = null;
                        lblMKHxoa.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTieudeKH.Text != "" && txtMotaKH.Text != "")
            {
                if (txtMKHcapnhat.Enabled == true && cmbMKHcapnhat.Enabled == false)
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    try
                    {
                        com.CommandText = "Update course set coursetitle ='" + txtTieudeKH.Text + "', coursedesc = '" + txtMotaKH.Text + "' where courseid =" + int.Parse(txtMaKH.Text) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can not be updated");
                    }
                }
                else
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    try
                    {
                        com.CommandText = "Update course set coursetitle ='" + txtTieudeKH.Text + "', coursedesc = '" + txtMotaKH.Text + "' where courseid =" + int.Parse(cmbMKHcapnhat.SelectedItem.ToString()) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can not be updated");
                    }

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu sẽ không thể phục hồi!", "Cảnh báo", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMKHxoa.Enabled == true && cmbMKHxoa.Enabled == false)
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    try
                    {
                        com.CommandText = "Delete from course where courseid =" + int.Parse(txtMKHxoa.Text) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
                else
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    try
                    {
                        com.CommandText = "Delete from course where courseid =" + int.Parse(cmbMKHxoa.SelectedItem.ToString()) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa");
                    }
                }
            }
            
        }
    }
}
