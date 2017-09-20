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
    public partial class frmThongtinGV : Form
    {
        public frmThongtinGV()
        {
            InitializeComponent();
        }
        //Global Variable
        public OleDbConnection con = new OleDbConnection();
        
        private void faculty_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QLTruonghoc\CSDL.accdb;Persist Security Info=False";
            con.Open();
            btnThem.Enabled = false;
            cmbVanphong.DropDownStyle = ComboBoxStyle.DropDownList;
            
            cmbGioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSKcapnhat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSKtim.DropDownStyle = ComboBoxStyle.DropDownList;
            //Update
            txtMSKcapnhat.Enabled = false;
            ckbLuachonCapnhat.Enabled = false;
            cmbMSKcapnhat.Enabled = false;
            btnCapnhat.Enabled = false;
            //Search
            txtMSKtim.Enabled = false;
            ckbLuachonTim.Enabled = false;
            cmbMSKtim.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCapnhat.Checked == true)
            {
                //Add checkbox
                ckbThem.Checked = false;
                txtMSKcapnhat.Enabled = true;
                ckbLuachonCapnhat.Enabled = true;
                cmbMSKcapnhat.Enabled = false;
                btnCapnhat.Enabled = true;
                //Search
                txtMSKtim.Enabled = false;
                ckbLuachonTim.Enabled = false;
                cmbMSKtim.Enabled = false;
                //Check boxes
                ckbTimkiem.Checked = false;
            }
            else
            {
                txtMSKcapnhat.Enabled = false;
                ckbLuachonCapnhat.Enabled = false;
                cmbMSKcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
            }
        }

        private void ckbTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            //Search
            if (ckbTimkiem.Checked == true)
            {
                //Add checkbox
                ckbThem.Checked = false;
                txtMSKtim.Enabled = true;
                ckbLuachonTim.Enabled = true;
                cmbMSKtim.Enabled = false;
                //Update
                txtMSKcapnhat.Enabled = false;
                ckbLuachonCapnhat.Enabled = false;
                cmbMSKcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                ckbCapnhat.Checked = false;
            }
            else
            {

                txtMSKtim.Enabled = false;
                ckbLuachonTim.Enabled = false;
                cmbMSKtim.Enabled = false;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cmbMSKcapnhat.Items.Clear();
            if (ckbLuachonCapnhat.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, faculty f where p.PersonId = f.facultyid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbMSKcapnhat.Items.Add(reader["personnum"].ToString());
                }
                //Update Checkbox
                txtMSKcapnhat.Enabled = false;
                cmbMSKcapnhat.Enabled = true;
            }
            else
            {
                txtMSKcapnhat.Enabled = true;
                cmbMSKcapnhat.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cmbMSKtim.Items.Clear();
            if (ckbLuachonTim.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, faculty f where p.PersonId = f.facultyid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbMSKtim.Items.Add(reader["personnum"].ToString());
                }
                //Search Checkbox
                txtMSKtim.Enabled = false;
                cmbMSKtim.Enabled = true;
            }
            else
            {
                txtMSKtim.Enabled = true;
                cmbMSKtim.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fId = txtMakhoa.Text;
            string fname = txtHodem.Text;
            string lname = txtTen.Text;
            string address = txtDiachi.Text;
            string postalCode = txtMavung.Text;
            string fcon = txtSDT.Text;
            string fsal = txtLuong.Text;
            if (fId != "" && fname != "" && lname != "" && address != "" && postalCode != "" && fcon != "" && fsal != "" && cmbGioitinh.SelectedItem != null && dtNgaysinh.Value != null && cmbVanphong.SelectedItem != null)
            {
                OleDbCommand com1 = new OleDbCommand();
                OleDbCommand com2 = new OleDbCommand();
                com1.Connection = con;
                com2.Connection = con;
                try
                {
                    com1.CommandText = "Insert into person(personId,fname,lname,dob,postalcode,gender,address) values(" + fId + ",'" + fname + "','" + lname + "'," + dtNgaysinh.Value.ToString("mm-dd-yyyy") + "," + postalCode + ",'" + cmbGioitinh.SelectedItem.ToString() + "','" + address + "')";
                    com2.CommandText = "Insert into faculty(facultyid, office, salary, contactNo) values(" + fId + ",'" + cmbVanphong.SelectedItem.ToString() + "'," + long.Parse(txtLuong.Text) + "," + long.Parse(txtSDT.Text) + ")";
                    com1.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
                catch
                {
                    MessageBox.Show("Can not be added");
                }
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string input = txtMakhoa.Text;
            try
            {
                long id = long.Parse(input);
                lblMSkhoa.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtMakhoa.Focus();
                lblMSkhoa.ForeColor = System.Drawing.Color.Red;
            }
        
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            string input = txtHodem.Text;
            int count = 0;
            if (input.Length > 3)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]) || input[i] == ' ')
                        count++;
                }
                if (count == input.Length)
                {
                    lblHodem.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtHodem.Focus();
                    lblHodem.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                txtHodem.Focus();
                lblHodem.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            string input = txtTen.Text;
            int count = 0;
            if (input.Length > 3)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]) || input[i] == ' ')
                        count++;
                }
                if (count == input.Length)
                {
                    lblTen.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtTen.Focus();
                    lblTen.ForeColor = System.Drawing.Color.Red;
                }
            }

            else
            {
                txtTen.Focus();
                lblTen.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            string input = txtSDT.Text;
            try
            {
                long id = long.Parse(input);
                lblSDT.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtSDT.Focus();
                lblSDT.ForeColor = System.Drawing.Color.Red;
            }
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMakhoa.Enabled = false;
            cmbVanphong.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtMSKcapnhat.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMSKcapnhat.ForeColor = System.Drawing.Color.Green;
                txtMakhoa.Text = reader["personnum"].ToString();
                txtHodem.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbVanphong.Items.Add(reader["foffice"].ToString());
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                cmbVanphong.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);
                txtSDT.Text = reader["fCon"].ToString();
                txtLuong.Text = reader["fSal"].ToString(); 

            }
            else
            {
                txtMakhoa.Text = "";
                txtHodem.Text = "";
                txtTen.Text = "";
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                txtLuong.Text = "";
                txtSDT.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMSKcapnhat.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMakhoa.Enabled = false;
            txtHodem.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtMavung.Enabled = false;
            txtSDT.Enabled = false;
            txtLuong.Enabled = false;
  
            cmbVanphong.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtMSKtim.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMSKtimkiem.ForeColor = System.Drawing.Color.Green;
                txtMakhoa.Text = reader["personnum"].ToString();
                txtHodem.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbVanphong.Items.Add(reader["foffice"].ToString());
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                cmbVanphong.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);
                txtSDT.Text = reader["fCon"].ToString();
                txtLuong.Text = reader["fSal"].ToString();

            }
            else
            {
                txtMakhoa.Text = "";
                txtHodem.Text = "";
                txtTen.Text = "";
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                txtLuong.Text = "";
                txtSDT.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMSKtimkiem.ForeColor = System.Drawing.Color.Red;
            }
        }

       

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbThem.Checked)
            {
                cmbVanphong.Items.Clear();
                btnThem.Enabled = true;
                txtMakhoa.Enabled = true;
                txtHodem.Enabled = true;
                txtTen.Enabled = true;
                txtDiachi.Enabled = true;
                txtMavung.Enabled = true;
                txtLuong.Enabled = true;
                txtSDT.Enabled = true;
                cmbGioitinh.Items.Clear();
                cmbGioitinh.Items.Add("Male");
                cmbGioitinh.Items.Add("Female");
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select dname from department";

                OleDbDataReader Fread = com.ExecuteReader();
                while (Fread.Read())
                {
                    cmbVanphong.Items.Add(Fread["dname"].ToString());
                }
                ckbCapnhat.Checked = false;
                ckbTimkiem.Checked = false;
            }
            else
            {
                cmbVanphong.Items.Clear();
                btnThem.Enabled = false;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
            {
                txtDiachi.Focus();
                lblDiachi.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblDiachi.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;
            string input = txtMakhoa.Text;
            try
            {
                int id = int.Parse(input);
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT PersonId FROM PERSON";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    if (id.ToString() == reader["PersonId"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    lblMSkhoa.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMSkhoa.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                lblMSkhoa.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string input = txtMavung.Text;
            try
            {
                long id = long.Parse(input);
                lblMavung.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtMavung.Focus();
                lblMavung.ForeColor = System.Drawing.Color.Red;
            }
        
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMakhoa.Enabled = false;
            txtHodem.Enabled = true;
            txtTen.Enabled = true;
            txtDiachi.Enabled = true;
            txtMavung.Enabled = true;
            txtSDT.Enabled = true;
            txtLuong.Enabled = true;

            cmbVanphong.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbMSKcapnhat.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMSKcapnhat.ForeColor = System.Drawing.Color.Green;
                txtMakhoa.Text = reader["personnum"].ToString();
                txtHodem.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                cmbVanphong.Items.Add(reader["foffice"].ToString());
                cmbVanphong.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);
                txtSDT.Text = reader["fCon"].ToString();
                txtLuong.Text = reader["fSal"].ToString();

            }
        }

        private void cmbMSKtim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMakhoa.Enabled = false;
            txtHodem.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtMavung.Enabled = false;
            txtSDT.Enabled = false;
            txtLuong.Enabled = false;

            //Check box with database
            txtMakhoa.Enabled = false;
            cmbVanphong.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, f.salary as fSal, f.contactNo as fCon, f.office as foffice  FROM PERSON p, Faculty f where p.PersonId = f.facultyid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbMSKtim.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMSKtimkiem.ForeColor = System.Drawing.Color.Green;
                txtMakhoa.Text = reader["personnum"].ToString();
                txtHodem.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                cmbVanphong.Items.Add(reader["foffice"].ToString());
                cmbVanphong.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);
                txtSDT.Text = reader["fCon"].ToString();
                txtLuong.Text = reader["fSal"].ToString();

            }
        
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
                OleDbCommand com1 = new OleDbCommand();
                OleDbCommand com2 = new OleDbCommand();
                com1.Connection = con;
                com2.Connection = con;
                if (txtMSKcapnhat.Text != "" || cmbMSKcapnhat.SelectedItem != null)
                {
                    try
                    {
                        com1.CommandText = "Update Person set fname ='" + txtHodem.Text + "', lname ='" + txtTen.Text + "', address ='" + txtDiachi.Text + "', postalcode = " + int.Parse(txtMavung.Text) + " where personid =" + int.Parse(txtMakhoa.Text) + "";
                        com2.CommandText = "Update Faculty set salary = " + long.Parse(txtLuong.Text) + ", contactNo = " + long.Parse(txtSDT.Text) + " where facultyid =" + int.Parse(txtMakhoa.Text) + "";
                        com1.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can not be updated");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Values");
                }
            
        }
    }
}
