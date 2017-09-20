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
    public partial class frmThongtinSV : Form
    {
        public frmThongtinSV()
        {
            InitializeComponent();
        }
        //Global Variable
        public OleDbConnection con = new OleDbConnection();
        
        private void frmThongtinSV_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\QLTruonghoc\CSDL.accdb;Persist Security Info=False";
            con.Open();
            btnThem.Enabled = false;
            //Connection with database
            //form load activities
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoahoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMScapnhat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMStimkiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMSxoa.DropDownStyle = ComboBoxStyle.DropDownList;
            //Update
            txtMScapnhat.Enabled = false;
            ckbLuachonCapnhat.Enabled = false;
            cmbMScapnhat.Enabled = false;
            btnCapnhat.Enabled = false;
            //Search
            txtMStimkiem.Enabled = false;
            cbkLuachonTimkiem.Enabled = false;
            cmbMStimkiem.Enabled = false;
            //Delete
            txtMSxoa.Enabled = false;
            cmbMSxoa.Enabled = false;
            btnXoa.Enabled = false;
            ckbLuachonXoa.Enabled = false;
        }
        private void ckbCapnhat_CheckedChanged(object sender, EventArgs e)
        {   
            //Update
            if (ckbCapnhat.Checked == true)
            {
                txtMasoSV.Enabled = false;
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                txtDiachi.Enabled = true;
                txtMavung.Enabled = true;
                //Add checkbox
                ckbThem.Checked = false;  
                txtMScapnhat.Enabled = true;
                ckbLuachonCapnhat.Enabled = true;
                cmbMScapnhat.Enabled = false;
                btnCapnhat.Enabled = true;
                //Search
                txtMStimkiem.Enabled = false;
                cbkLuachonTimkiem.Enabled = false;
                cmbMStimkiem.Enabled = false;
                //Delete
                txtMSxoa.Enabled = false;
                cmbMSxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbLuachonXoa.Enabled = false;
                //Check boxes
                ckbTimkiem.Checked = false;
                ckbXoa.Checked = false;
            }
            else
            {

                txtMasoSV.Enabled = true;
                txtMScapnhat.Enabled = false;
                ckbLuachonCapnhat.Enabled = false;
                cmbMScapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
            }
        }

        private void ckbCapnhat_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void ckbTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            //Search
            if (ckbTimkiem.Checked == true)
            {

                //Add checkbox
                ckbThem.Checked = false;  
                txtMStimkiem.Enabled = true;
                cbkLuachonTimkiem.Enabled = true;
                cmbMStimkiem.Enabled = false;
                //Update
                txtMScapnhat.Enabled = false;
                ckbLuachonCapnhat.Enabled = false;
                cmbMScapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                //Delete  
                txtMSxoa.Enabled = false;
                cmbMSxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbLuachonXoa.Enabled = false;
                //Check boxes
                ckbCapnhat.Checked = false;
                ckbXoa.Checked = false;
            }
            else
            {
                txtMStimkiem.Enabled = false;
                cbkLuachonTimkiem.Enabled = false;
                cmbMStimkiem.Enabled = false;
            }
        }

        private void ckbXoa_CheckedChanged(object sender, EventArgs e)
        {
            //Delete
            if (ckbXoa.Checked == true)
            {
                txtMasoSV.Enabled = true;
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                txtDiachi.Enabled = true;
                txtMavung.Enabled = true;
               

                //Add checkbox
                ckbThem.Checked = false;  
                txtMSxoa.Enabled = true;
                cmbMSxoa.Enabled = false;
                btnXoa.Enabled = true;
                ckbLuachonXoa.Enabled = true;
                //Update
                txtMScapnhat.Enabled = false;
                ckbLuachonCapnhat.Enabled = false;
                cmbMScapnhat.Enabled = false;
                btnCapnhat.Enabled = false;
                //Search
                txtMStimkiem.Enabled = false;
                cbkLuachonTimkiem.Enabled = false;
                cmbMStimkiem.Enabled = false;
                //check boxes
                ckbCapnhat.Checked = false;
                ckbTimkiem.Checked = false;
            }
            else
            {
                txtMSxoa.Enabled = false;
                cmbMSxoa.Enabled = false;
                btnXoa.Enabled = false;
                ckbLuachonXoa.Enabled = false;
            }
        }

        private void ckbLuachonCapnhat_CheckedChanged(object sender, EventArgs e)
        {
            cmbMScapnhat.Items.Clear();
            if (ckbLuachonCapnhat.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, student s where p.PersonId = s.studentid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbMScapnhat.Items.Add(reader["personnum"].ToString());
                }
                //Update Checkbox
                txtMScapnhat.Enabled = false;
                cmbMScapnhat.Enabled = true;
            }
            else
            {
                txtMScapnhat.Enabled = true;
                cmbMScapnhat.Enabled = false;    
            }
        }

        private void ckbLuachonTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            cmbMStimkiem.Items.Clear();
            if (cbkLuachonTimkiem.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, student s where p.PersonId = s.studentid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbMStimkiem.Items.Add(reader["personnum"].ToString());
                }
                //Search Checkbox
                txtMStimkiem.Enabled = false;
                cmbMStimkiem.Enabled = true;
            }
            else
            {
                txtMStimkiem.Enabled = true;
                cmbMStimkiem.Enabled = false;
            }
        }

        private void ckbLuachonXoa_CheckedChanged(object sender, EventArgs e)
        {
            cmbMSxoa.Items.Clear();
            if (ckbLuachonXoa.Checked == true)
            {
                //Check box with database
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = con;
                command1.CommandText = "SELECT p.PersonId as personnum  FROM PERSON p, student s where p.PersonId = s.studentid";
                OleDbDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    cmbMSxoa.Items.Add(reader["personnum"].ToString());
                }
                //Delete Checkbox
                txtMSxoa.Enabled = false;
                cmbMSxoa.Enabled = true;
            }
            else
            {
                txtMSxoa.Enabled = true;
                cmbMSxoa.Enabled = false;
            }
        }

        private void txtMasoSV_TextChanged(object sender, EventArgs e)
        {
            bool flag = false;  
            string input = txtMasoSV.Text;
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
                    lblMasoSV.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMasoSV.ForeColor = System.Drawing.Color.Red;        
                }
            }
            catch
            {
                lblMasoSV.ForeColor = System.Drawing.Color.Red;
            }
            
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            OleDbCommand com2 = new OleDbCommand();
            OleDbCommand com3 = new OleDbCommand();
            OleDbCommand com4 = new OleDbCommand();
            OleDbCommand com5 = new OleDbCommand();

            com1.Connection = con;
            com2.Connection = con;
            com3.Connection = con;
            com4.Connection = con;
            com5.Connection = con;
            bool flag1 = false, flag2 = false;
            string studentId = txtMasoSV.Text;
            string fname = txtHo.Text;
            string lname = txtTen.Text;
            string address = txtDiachi.Text;
            string postalCode = txtMavung.Text;

            if (studentId != "" && fname != "" && lname != "" && address != "" && postalCode != "" && cmbKhoa.SelectedItem != null && cmbGioitinh.SelectedItem != null && cmbKhoahoc.SelectedItem != null)
            {
                com4.CommandText = "Select courseid , coursetitle from course";
                OleDbDataReader courseRead = com4.ExecuteReader();
                while (courseRead.Read())
                {
                    if (cmbKhoahoc.SelectedItem.ToString() == courseRead["coursetitle"].ToString())
                    {
                        flag1 = true;
                        break;
                    }
                }
                com5.CommandText = "SELECT c.courseid as cID, d.deptid as stdDept, d.dname as depName FROM Course c, Department d where c.deptid = d.deptid";
                OleDbDataReader DeRead = com5.ExecuteReader();
                while (DeRead.Read())
                {
                    if (cmbKhoa.SelectedItem.ToString() == DeRead["depName"].ToString())
                    {
                        flag2 = true;
                        break;
                    }
                }
                if (flag1 && flag2)
                {
                    try
                    {
                        com1.CommandText = "Insert into person(personId,fname,lname,dob,postalcode,gender,address) values(" + int.Parse(studentId) + ",'" + fname + "','" + lname + "'," + dtNgaysinh.Value.ToString("mm-dd-yyyy") + "," + long.Parse(postalCode) + ",'" + cmbGioitinh.SelectedItem.ToString() + "','" + address + "')";
                        com2.CommandText = "Insert into student(studentid,class,Deptid) values(" + int.Parse(studentId) + ",'" + cmbLop.SelectedItem.ToString() + "'," + int.Parse(DeRead["stdDept"].ToString()) + ")";
                        com3.CommandText = "Insert into Register(courseid, studentid) values(" + int.Parse(courseRead["courseid"].ToString()) + "," + int.Parse(studentId) + ")";
                        com1.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        com3.ExecuteNonQuery();
                        MessageBox.Show("Đã thêm vào danh sách sinh viên mới");
                    }
                    catch(Exception es) 
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập giá trị");
            }
        }

        private void txtMasoSV_Leave(object sender, EventArgs e)
        {
            string input = txtMasoSV.Text;
            try
            {
                long id = long.Parse(input);
                lblMasoSV.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                txtMasoSV.Focus();
                lblMasoSV.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtHo_Leave(object sender, EventArgs e)
        {
            string input = txtHo.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (input.Length != 0)
            {
                if(count == input.Length)
                lblHodem.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtHo.Focus();
                lblHodem.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            string input = txtTen.Text;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    count++;
            }
            if (input.Length != 0)
            {
                if (count == input.Length)
                {
                    lblTen.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                txtTen.Focus();
                lblTen.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtMavung_Leave(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMScapnhat_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMasoSV.Enabled = false;
            cmbKhoa.Items.Clear();
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtMScapnhat.Text == reader["personnum"].ToString()) 
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMasoupdate.ForeColor = System.Drawing.Color.Green;
                txtMasoSV.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbKhoa.Items.Add(readStd["deptname"].ToString());
                        cmbLop.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbKhoa.SelectedIndex = 0;
                cmbLop.SelectedIndex = 0;
                txtHo.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtMasoSV.Text = "";
                txtHo.Text = "";
                txtTen.Text = "";
                cmbKhoa.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMasoupdate.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            txtMasoSV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtMavung.Enabled = false;
            cmbKhoa.Items.Clear();
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtMStimkiem.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMStimkiem.ForeColor = System.Drawing.Color.Green;
                txtMasoSV.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbKhoa.Items.Add(readStd["deptname"].ToString());
                        cmbLop.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbKhoa.SelectedIndex = 0;
                cmbLop.SelectedIndex = 0;
                txtHo.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtMasoSV.Text = "";
                txtHo.Text = "";
                txtTen.Text = "";
                cmbKhoa.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMasoupdate.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //Check box with database
            //Check box with database
            txtMasoSV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtMavung.Enabled = false;
            cmbKhoa.Items.Clear();
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (txtMSxoa.Text == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMSxoa.ForeColor = System.Drawing.Color.Green;
                txtMasoSV.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbKhoa.Items.Add(readStd["deptname"].ToString());
                        cmbLop.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbKhoa.SelectedIndex = 0;
                cmbLop.SelectedIndex = 0;
                txtHo.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtMasoSV.Text = "";
                txtHo.Text = "";
                txtTen.Text = "";
                cmbKhoa.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMasoupdate.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
              OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "SELECT c.deptid as coursedept, c.courseid as cID , d.dname as dename, d.deptid as deptnum,  c.coursetitle as coursename  FROM Course c, Department d where c.deptid = d.deptid";
                OleDbDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    if (cmbKhoa.SelectedItem.ToString() == read["dename"].ToString())
                    {
                        cmbKhoahoc.Items.Add(read["coursename"].ToString());
                    }
                }
                OleDbCommand com1 = new OleDbCommand();
                com1.Connection = con;
                com1.CommandText = "SELECT c.className as cName, d.deptid as dptid, d.dname as depname from class c, department d where d.deptid = c.deptid ";
                OleDbDataReader readclass = com1.ExecuteReader();
                while (readclass.Read())
                {
                    if(cmbKhoa.SelectedItem.ToString() == readclass["depname"].ToString())
                    {
                        cmbLop.Items.Add(readclass["cName"].ToString());
                        cmbLop.SelectedIndex = 0;
                        break;
                    }
                }
        }

        private void cmbMScapnhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update combobox
            txtMasoSV.Enabled = false;
            cmbKhoa.Items.Clear();
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbMScapnhat.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMasoupdate.ForeColor = System.Drawing.Color.Green;
                txtMasoSV.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbKhoa.Items.Add(readStd["deptname"].ToString());
                        cmbLop.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbKhoa.SelectedIndex = 0;
                cmbLop.SelectedIndex = 0;
                txtHo.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtMasoSV.Text = "";
                txtHo.Text = "";
                txtTen.Text = "";
                cmbKhoa.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMasoupdate.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //Add check box
            if (ckbThem.Checked == true)
            {
                cmbKhoa.Items.Clear();
                OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = "Select dname from department";
                OleDbDataReader reDeptid = com.ExecuteReader();
                while (reDeptid.Read())
                {
                    cmbKhoa.Items.Add(reDeptid["dname"].ToString());
                }
                txtMasoSV.Enabled = true;
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                txtDiachi.Enabled = true;
                txtMavung.Enabled = true;
                cmbKhoa.Items.Clear();
                cmbKhoahoc.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT DNAME FROM DEPARTMENT";
                OleDbDataReader dept = com2.ExecuteReader();
                while (dept.Read())
                {
                    cmbKhoa.Items.Add(dept["dname"].ToString());
                }
                cmbGioitinh.Items.Add("Male");
                cmbGioitinh.Items.Add("Female");
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

        private void txtMavung_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cmbMStimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update combobox
            txtMasoSV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtMavung.Enabled = false;
            cmbKhoa.Items.Clear();
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbMStimkiem.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMasoupdate.ForeColor = System.Drawing.Color.Green;
                txtMasoSV.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbKhoa.Items.Add(readStd["deptname"].ToString());
                        cmbLop.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbKhoa.SelectedIndex = 0;
                cmbLop.SelectedIndex = 0;
                txtHo.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtMasoSV.Text = "";
                txtHo.Text = "";
                txtTen.Text = "";
                cmbKhoa.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMasoupdate.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            if (txtMScapnhat.Text != "" || cmbMScapnhat.SelectedItem != null)
            {
                if (txtMScapnhat.Enabled == true && cmbMScapnhat.Enabled == false)
                {
                    try
                    {
                        com.CommandText = "Update Person set fname ='" + txtHo.Text + "', lname ='" + txtTen.Text + "', address ='" + txtDiachi.Text + "', postalcode = " + int.Parse(txtMavung.Text) + " where personid =" + int.Parse(txtMasoSV.Text) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can Not be Updated");
                    }
                }
                else
                {
                    try
                    {
                        com.CommandText = "Update Person set fname ='" + txtHo.Text + "', lname ='" + txtTen.Text + "', address ='" + txtDiachi.Text + "', postalcode = " + int.Parse(txtMavung.Text) + " where personid =" + int.Parse(cmbMScapnhat.SelectedItem.ToString()) + "";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated");
                    }
                    catch
                    {
                        MessageBox.Show("Can Not be Updated");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Values");
            }
        }

        private void cmbMSxoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMasoSV.Enabled = false;
            cmbKhoa.Items.Clear();
            cmbKhoahoc.Items.Clear();
            cmbLop.Items.Clear();
            cmbGioitinh.Items.Clear();
            bool flag = false;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            command1.CommandText = "SELECT p.PersonId as personnum, p.fname as perfname, p.lname as perlname, p.gender as pergen, p.dob as perdob, p.postalcode as perpost, p.address as peradd, s.class as stdclass, s.Deptid as stddept  FROM PERSON p, student s where p.PersonId = s.studentid";
            OleDbDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                if (cmbMSxoa.SelectedItem.ToString() == reader["personnum"].ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                lblMasoupdate.ForeColor = System.Drawing.Color.Green;
                txtMasoSV.Text = reader["personnum"].ToString();
                //Student Department
                OleDbCommand com2 = new OleDbCommand();
                com2.Connection = con;
                com2.CommandText = "SELECT  d.dname as deptname, s.deptid as stddept, s.class as stclass from department d, student s where s.deptid = d.deptid";
                OleDbDataReader readStd = com2.ExecuteReader();
                while (readStd.Read())
                {
                    if (reader["stdclass"].ToString() == readStd["stclass"].ToString())
                    {
                        cmbKhoa.Items.Add(readStd["deptname"].ToString());
                        cmbLop.Items.Add(readStd["stclass"].ToString());
                        break;
                    }
                }
                cmbKhoa.SelectedIndex = 0;
                cmbLop.SelectedIndex = 0;
                txtHo.Text = reader["perfname"].ToString();
                txtTen.Text = reader["perlname"].ToString();
                cmbGioitinh.Items.Add(reader["pergen"].ToString());
                cmbGioitinh.SelectedIndex = 0;
                txtMavung.Text = reader["perpost"].ToString();
                txtDiachi.Text = reader["peradd"].ToString();
                dtNgaysinh.Value = Convert.ToDateTime(reader["perdob"]);

            }
            else
            {
                txtMasoSV.Text = "";
                txtHo.Text = "";
                txtTen.Text = "";
                cmbKhoa.Items.Clear();
                cmbLop.Items.Clear();
                cmbGioitinh.Items.Clear();
                txtDiachi.Text = "";
                txtMavung.Text = "";
                dtNgaysinh.Value = DateTime.Now;
                lblMasoupdate.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            OleDbCommand com1 = new OleDbCommand();
            OleDbCommand com2 = new OleDbCommand();
            OleDbCommand com3 = new OleDbCommand();
            com3.Connection = con;
            com2.Connection = con;
            com1.Connection = con;
            if (txtMSxoa.Text != "" || cmbMSxoa.SelectedItem != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa? Dữ liệu sẽ không thể phục hồi!", "Cảnh báo", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMSxoa.Enabled == true && cmbMSxoa.Enabled == false)
                    {
                        try
                        {
                            com3.CommandText = "Delete from Register where studentid =" + int.Parse(txtMSxoa.Text) + "";
                            com1.CommandText = "Delete  from Student where studentid =" + int.Parse(txtMSxoa.Text) + "";
                            com2.CommandText = "Delete  from Person where PersonId =" + int.Parse(txtMSxoa.Text) + "";
                            com3.ExecuteNonQuery();
                            com1.ExecuteNonQuery();
                            com2.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Không thể xóa");
                        }
                    }
                    else
                    {
                        try
                        {
                            com3.CommandText = "Delete from Register where studentid =" + int.Parse(cmbMSxoa.SelectedItem.ToString()) + "";
                            com1.CommandText = "Delete  from Student where studentid =" + int.Parse(cmbMSxoa.SelectedItem.ToString()) + "";
                            com2.CommandText = "Delete  from Person where PersonId =" + int.Parse(cmbMSxoa.SelectedItem.ToString()) + "";
                            com3.ExecuteNonQuery();
                            com1.ExecuteNonQuery();
                            com2.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Không thể xóa");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập một giá trị");
            }
            
            
        }

    }
}
