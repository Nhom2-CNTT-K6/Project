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
    public partial class frmMonhoc : Form
    {
        public frmMonhoc()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection();
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void department_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QLTruonghoc\CSDL.accdb;Persist Security Info=False";
            con.Open();
            cmbMakhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSMHcapnhat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSMHtim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSMHxoa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtHodem.Enabled = false;
            txTen.Enabled = false;
            btnThem.Enabled = false;
            //Update
            txtMSMHcapnhat.Enabled = false;
            ckbLuachonCapnhat.Enabled = false;
            cmbMSMHcapnhat.Enabled = false;
            btnCapnhat.Enabled = false;
            //Search
            txtMSMHtim.Enabled = false;
            ckbLuachontim.Enabled = false;
            cmbMSMHtim.Enabled = false;
            //Delete
            txtMSMHxoa.Enabled = false;
            cmbMSMHxoa.Enabled = false;
            btnXoa.Enabled = false;
            ckbLuachonxoa.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Update
            if (ckbCapnhat.Checked == true)
            {
                txtMaMH.Enabled = true;
                txtTenMH.Enabled = true;
                txtDiadiem.Enabled = true;
                //Add checkbox
                ckbThem.Checked = false;
                ckbLuachonCapnhat.Enabled = true;
                cmbMSMHcapnhat.Enabled = false;
                btnCapnhat.Enabled = true;
                //Search
                txtMSMHtim.Enabled = false;
                ckbLuachontim.Enabled = false;
                cmbMSMHtim.Enabled = false;
                //Delete
                txtMSMHxoa.Enabled = false;
                cmbMSMHxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbLuachonxoa.Enabled = false;
                txtMSMHcapnhat.Enabled = true;
                //Check boxes
                ckbTimkiem.Checked = false;
                ckbXoa.Checked = false;
            }
            else
            {
                ckbLuachonCapnhat.Enabled = false;
                cmbMSMHcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //Search
            if (ckbTimkiem.Checked == true)
            {

                //Add checkbox
                ckbThem.Checked = false;
                txtMSMHtim.Enabled = true;
                ckbLuachontim.Enabled = true;
                cmbMSMHtim.Enabled = false;
                //Update
                ckbLuachonCapnhat.Enabled = false;
                cmbMSMHcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                //Delete  
                txtMSMHxoa.Enabled = false;
                cmbMSMHxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbLuachonxoa.Enabled = false;
                //Check boxes
                ckbCapnhat.Checked = false;
                ckbXoa.Checked = false;
                txtMSMHcapnhat.Enabled = false;
            }
            else
            {
                txtMSMHtim.Enabled = false;
                ckbLuachontim.Enabled = false;
                cmbMSMHtim.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //Delete
            if (ckbXoa.Checked == true)
            {
                txtMaMH.Enabled = true;
                txtTenMH.Enabled = true;
                txtDiadiem.Enabled = true;

                txtMSMHcapnhat.Enabled = false;

                //Add checkbox
                ckbThem.Checked = false;
                txtMSMHxoa.Enabled = true;
                cmbMSMHxoa.Enabled = false;
                btnXoa.Enabled = true;
                ckbLuachonxoa.Enabled = true;
                //Update
                ckbLuachonCapnhat.Enabled = false;
                cmbMSMHcapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                //Search
                txtMSMHtim.Enabled = false;
                ckbLuachontim.Enabled = false;
                cmbMSMHtim.Enabled = false;
                //check boxes
                ckbCapnhat.Checked = false;
                ckbTimkiem.Checked = false;
            }
            else
            {
                txtMSMHxoa.Enabled = false;
                cmbMSMHxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbLuachonxoa.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cmbMSMHcapnhat.Items.Clear();
            if (ckbLuachonCapnhat.Checked == true)
            {
                //Check box with database
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select deptid from department";
                OleDbDataReader dread = com.ExecuteReader();
                while (dread.Read())
                {
                    cmbMSMHcapnhat.Items.Add(dread["deptid"].ToString());
                }
                txtMSMHcapnhat.Enabled = false;
                //Update Checkbox
                cmbMSMHcapnhat.Enabled = true;
            }
            else
            {
                txtMSMHcapnhat.Enabled = true;
                cmbMSMHcapnhat.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cmbMSMHtim.Items.Clear();
            if (ckbLuachontim.Checked == true)
            {
                //Check box with database
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select deptid from department";
                OleDbDataReader dread = com.ExecuteReader();
                while (dread.Read())
                {
                    cmbMSMHtim.Items.Add(dread["deptid"].ToString());
                }
                //Search Checkbox
                txtMSMHtim.Enabled = false;
                cmbMSMHtim.Enabled = true;
            }
            else
            {
                txtMSMHtim.Enabled = true;
                cmbMSMHtim.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cmbMSMHxoa.Items.Clear();
            if (ckbLuachonxoa.Checked == true)
            {
                //Check box with database
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select deptid from department";
                OleDbDataReader dread = com.ExecuteReader();
                while (dread.Read())
                {
                    cmbMSMHxoa.Items.Add(dread["deptid"].ToString());
                }
                //Delete Checkbox
                txtMSMHxoa.Enabled = false;
                cmbMSMHxoa.Enabled = true;
            }
            else
            {
                txtMSMHxoa.Enabled = true;
                cmbMSMHxoa.Enabled = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string input = txtMaMH.Text;
            try
            {
                long id = long.Parse(input);
                lblMSBM.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtMaMH.Focus();
                lblMSBM.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string input = txtTenMH.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (count == input.Length)
            {
                lblTenMH.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtTenMH.Focus();
                lblTenMH.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string input = txtDiadiem.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (count == input.Length)
            {
                lblDiadiem.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtDiadiem.Focus();
                lblDiadiem.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMaMH.Enabled = false;
            cmbMakhoa.Items.Clear();
            if (txtMSMHcapnhat.Text != "")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
                com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
                OleDbDataReader Cread = com1.ExecuteReader();
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtMSMHcapnhat.Text == fread["dept"].ToString())
                    {
                        cmbMakhoa.Items.Add(fread["fid"].ToString());
                        txtMaMH.Text = fread["dept"].ToString();
                        txtTenMH.Text = fread["dename"].ToString();
                        txtDiadiem.Text = fread["dloc"].ToString();
                        cmbMakhoa.SelectedIndex = 0;
                        while (Cread.Read())
                        {
                            if (fread["dept"].ToString() == Cread["classDept"].ToString())
                            { 
                                txtLop.Text = Cread["cName"].ToString();
                                break;
                            }
                        }
                        lblMSMHcapnhat.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaMH.Text = "";
                        txtTenMH.Text = "";
                        txtDiadiem.Text = "";
                        cmbMakhoa.Items.Clear();
                        txtHodem.Text = "";
                        txTen.Text = "";
                        txtLop.Text = "";
                        lblMSMHcapnhat.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtDiadiem.Enabled = false;
            txtLop.Enabled = false;
            cmbMakhoa.Items.Clear();
            if (txtMSMHtim.Text != "")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
            
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
                com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
                OleDbDataReader Cread = com1.ExecuteReader();
            
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtMSMHtim.Text == fread["dept"].ToString())
                    {
                        cmbMakhoa.Items.Add(fread["fid"].ToString());
                        txtMaMH.Text = fread["dept"].ToString();
                        txtTenMH.Text = fread["dename"].ToString();
                        txtDiadiem.Text = fread["dloc"].ToString();
                        while (Cread.Read())
                        {
                            if (fread["dept"].ToString() == Cread["classDept"].ToString())
                            {
                                txtLop.Text = Cread["cName"].ToString();
                                break;
                            }
                        }
                        cmbMakhoa.SelectedIndex = 0;
                        lblMSMHcapnhat.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaMH.Text = "";
                        txtTenMH.Text = "";
                        txtDiadiem.Text = "";
                        cmbMakhoa.Items.Clear();
                        txtHodem.Text = "";
                        txTen.Text = "";

                        txtLop.Text = "";
                        lblMSMHcapnhat.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtDiadiem.Enabled = false;

            txtLop.Enabled = false;
            cmbMakhoa.Items.Clear();
            if (txtMSMHxoa.Text != "")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
            
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
                com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
                OleDbDataReader Cread = com1.ExecuteReader();
            
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    if (txtMSMHxoa.Text == fread["dept"].ToString())
                    {
                        cmbMakhoa.Items.Add(fread["fid"].ToString());
                        txtMaMH.Text = fread["dept"].ToString();
                        txtTenMH.Text = fread["dename"].ToString();
                        txtDiadiem.Text = fread["dloc"].ToString();
                        while (Cread.Read())
                        {
                            if (fread["dept"].ToString() == Cread["classDept"].ToString())
                            {
                                txtLop.Text = Cread["cName"].ToString();
                                break;
                            }
                        }
                        cmbMakhoa.SelectedIndex = 0;
                        lblMSMHcapnhat.ForeColor = System.Drawing.Color.Green;
                        break;
                    }
                    else
                    {

                        txtMaMH.Text = "";
                        txtTenMH.Text = "";
                        txtDiadiem.Text = "";
                        cmbMakhoa.Items.Clear();
                        txtHodem.Text = "";
                        txTen.Text = "";

                        txtLop.Text = "";
                        lblMSMHcapnhat.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            cmbMakhoa.Items.Clear();
            if (ckbThem.Checked == true)
            {
                txtLop.Enabled = true;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "select facultyid from faculty where facultyid NOT IN (select facultyid from department) ";
                OleDbDataReader fread = com.ExecuteReader();
                while (fread.Read())
                {
                    cmbMakhoa.Items.Add(fread["facultyid"].ToString());
                }
                txtMaMH.Text = "";
                txtTenMH.Text = "";
                txtDiadiem.Text = "";
                txtMaMH.Enabled = true;
                txtTenMH.Enabled = true;
                txtDiadiem.Enabled = true;
                
                ckbCapnhat.Checked = false;
                ckbTimkiem.Checked = false;
                ckbXoa.Checked = false;
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;
            string input = txtMaMH.Text;
            try
            {
                int id = int.Parse(input);
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT deptid FROM Department";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    if (id.ToString() == reader["deptid"].ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    lblMSBM.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMSBM.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                lblMSBM.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = "Select  f.facultyid as fId, p.fname as pfname, p.lname as plname from faculty f, person p where f.facultyid = p.personid";
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (fread["fId"].ToString() == cmbMakhoa.SelectedItem.ToString())
                {
                    txtHodem.Text = fread["pfname"].ToString();
                    txTen.Text = fread["plname"].ToString();
                    break;
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMakhoa.Items.Clear();
            txtMaMH.Enabled = false;
            
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            
            com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
            com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
            OleDbDataReader Cread = com1.ExecuteReader();
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (cmbMSMHcapnhat.SelectedItem.ToString() == fread["dept"].ToString())
                {
                    cmbMakhoa.Items.Add(fread["fid"].ToString());
                    txtMaMH.Text = fread["dept"].ToString();
                    txtTenMH.Text = fread["dename"].ToString();
                    while (Cread.Read())
                    {
                        if (fread["dept"].ToString() == Cread["classDept"].ToString())
                        {
                            txtLop.Text = Cread["cName"].ToString();
                            break;
                        }
                    }
                    txtDiadiem.Text = fread["dloc"].ToString();
                    break;
                }
            }
            cmbMakhoa.SelectedIndex = 0;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMakhoa.Items.Clear();
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtDiadiem.Enabled = false;
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            
            com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
            com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
            OleDbDataReader Cread = com1.ExecuteReader();
            
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (cmbMSMHtim.SelectedItem.ToString() == fread["dept"].ToString())
                {
                    cmbMakhoa.Items.Add(fread["fid"].ToString());
                    txtMaMH.Text = fread["dept"].ToString();
                    txtTenMH.Text = fread["dename"].ToString();
                    txtDiadiem.Text = fread["dloc"].ToString();
                    while (Cread.Read())
                    {
                        if (fread["dept"].ToString() == Cread["classDept"].ToString())
                        {
                            txtLop.Text = Cread["cName"].ToString();
                            break;
                        }
                    }
                    break;
                }
            }
            cmbMakhoa.SelectedIndex = 0;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMakhoa.Items.Clear();
            txtMaMH.Enabled = false;
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            
            com.CommandText = "select f.facultyid as fid, d.deptid as dept, d.dname as dename, d.location as dloc  from department d, faculty f where d.facultyid = f.facultyid";
            com1.CommandText = "Select c.className as cName, c.deptid as classDept from class c, department d where c.deptid = d.deptid";
            OleDbDataReader Cread = com1.ExecuteReader();
            
            OleDbDataReader fread = com.ExecuteReader();
            while (fread.Read())
            {
                if (cmbMSMHxoa.SelectedItem.ToString() == fread["dept"].ToString())
                {
                    cmbMakhoa.Items.Add(fread["fid"].ToString());
                    txtMaMH.Text = fread["dept"].ToString();
                    txtTenMH.Text = fread["dename"].ToString();
                    txtDiadiem.Text = fread["dloc"].ToString();
                    while (Cread.Read())
                    {
                        if (fread["dept"].ToString() == Cread["classDept"].ToString())
                        {
                            txtLop.Text = Cread["cName"].ToString();
                            break;
                        }
                    }
                    break;
                }
            }
            cmbMakhoa.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtMaMH.Text;
            string dname = txtTenMH.Text;
            string dloc = txtDiadiem.Text;
            string className = txtLop.Text;
            object facultyId = cmbMakhoa.SelectedItem;
            if (id != "" && dname != "" && dloc != "" && facultyId != null && className !="")
            {
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Insert into Department(deptid, dname, location, facultyid) values("+int.Parse(id)+",'"+dname+"','"+dloc+"',"+int.Parse(facultyId.ToString())+")";
                com1.CommandText = "Insert into class(className,deptid) values('"+className+"',"+int.Parse(id)+")";
                com.ExecuteNonQuery();
                com1.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenMH.Text != "" && txtDiadiem.Text != "" && txtLop.Text != "")
                {
                    OleDbCommand com1 = new OleDbCommand();
                    com1.Connection = con;
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com1.CommandText = "Update class set className = '"+txtLop.Text+"' where deptid =" + int.Parse(txtMaMH.Text) + "";
                    com.CommandText = "Update department set dname = '" + txtTenMH.Text + "', location ='" + txtDiadiem.Text + "' where deptid =" + int.Parse(txtMaMH.Text) + "";
                    com.ExecuteNonQuery();
                    com1.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                }
            }
            catch
            {
                MessageBox.Show("Can not be updated");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            com1.Connection = con;
            OleDbCommand com2 = new OleDbCommand();
            com2.Connection = con;
            OleDbCommand com3 = new OleDbCommand();
            com3.Connection = con;
            OleDbCommand com4 = new OleDbCommand();
            com4.Connection = con;
            OleDbCommand com5 = new OleDbCommand();
            com5.Connection = con;
            OleDbCommand com6 = new OleDbCommand();
            com6.Connection = con;
            bool flag = false;
            if (txtMSMHxoa.Enabled == true && cmbMSMHxoa.Enabled == false)
            {
                try
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com2.CommandText = "Delete from course where deptid = "+int.Parse(txtMaMH.Text)+"";
                    com1.CommandText = "Delete from Student where deptid =" +int.Parse(txtMaMH.Text)+"";
                    com5.CommandText = "Delete from class where deptid =" + int.Parse(txtMaMH.Text) + "";
                    com.CommandText = "Delete from department where deptid = " + int.Parse(txtMaMH.Text) + "";
                    com5.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    com1.ExecuteNonQuery();
                    com.ExecuteNonQuery();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
                if (flag)
                {
                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtDiadiem.Text = "";
                    txtHodem.Text = "";
                    txTen.Text = "";
                    txtLop.Text = "";
                    cmbMakhoa.Items.Clear(); 
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Can not be Deleted");
                }
            }
            else
            {
                try
                {
                    OleDbCommand com = new OleDbCommand();
                    com.Connection = con;
                    com4.CommandText = "Delete from course where deptid = " + int.Parse(cmbMSMHxoa.SelectedItem.ToString()) + "";
                    com3.CommandText = "Delete from Student where deptid =" + int.Parse(cmbMSMHxoa.SelectedItem.ToString()) + "";
                    com6.CommandText = "Delete from class where deptid =" + int.Parse(cmbMSMHxoa.SelectedItem.ToString()) + "";
                    com.CommandText = "Delete from department where deptid = " + int.Parse(cmbMSMHxoa.SelectedItem.ToString()) + "";
                    com6.ExecuteNonQuery();
                    com4.ExecuteNonQuery();
                    com3.ExecuteNonQuery();
                    com.ExecuteNonQuery();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
                if (flag)
                {
                    txtMaMH.Text = "";
                    txtTenMH.Text = "";
                    txtDiadiem.Text = "";
                    txtHodem.Text = "";
                    txTen.Text = "";
                    txtLop.Text = "";
                    cmbMakhoa.Items.Clear();
                    MessageBox.Show("Successfully Deleted");
                }
                else
                {
                    MessageBox.Show("Can not be Deleted");
                }
            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            string input = txtLop.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (count == input.Length)
            {
                lblLop.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtLop.Focus();
                lblLop.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
