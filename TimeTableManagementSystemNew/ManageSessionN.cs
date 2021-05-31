using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class ManageSessionN : Form
    {
        public ManageSessionN()
        {
           

            InitializeComponent();
            FillCombo1();
            FillCombo2();
            FillCombo3();
            FillCombo4();
            FillCombo5();
            FillCombo6();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");

        public int ID;
        

        private void FillCombo1()
        {
            string sql = "Select * from ManageEmployeeN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(2);
                    cmbSelEmp.Items.Add(subCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillCombo6()
        {

            string sql = "Select * from ManageEmployeeN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(2);
                    cmbSelected.Items.Add(subCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillCombo2()
        {
            string sql = "Select * from ManageSubject";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(4);
                    comSubCode.Items.Add(subCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillCombo3()
        {

            string sql = "Select * from ManageSubject";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subName = myreader.GetString(3);
                    cmbSub.Items.Add(subName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillCombo4()
        {
            string sql = "Select * from tbl_tag";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string relTag = myreader.GetString(3);
                    cmbSelTag.Items.Add(relTag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FillCombo5()
        {

            string sql = "Select * from tbl_student";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subGrpId = myreader.GetString(6);
                    cmbGrp.Items.Add(subGrpId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageSessionN_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 1;

            GetManageSessionRecord();
        }

        private void GetManageSessionRecord()
        {
            try { 
            SqlCommand cmd = new SqlCommand("Select * from ManageSessionN", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            GrdsessionData.DataSource = dt;

            }
            catch (Exception ex) { 
            
            }
            finally { 

            con.Close();
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession back = new AddSession();
            back.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ID = 0;
            ReasetAddSessionFormControls();

            cmbSelEmp.Focus();
        }
        private void ReasetAddSessionFormControls()
        {
            ID = 0;

            cmbSelEmp.ResetText();
            cmbSelected.ResetText();
            comSubCode.ResetText();
            cmbSub.ResetText();
            cmbSelTag.ResetText();
            cmbGrp.ResetText();
            numStudents.Value = 0;
            textBox2.ResetText();
            textBox1.Clear();


            cmbSelEmp.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (ID > 0)
            {

                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM ManageSessionN WHERE ID = @ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Session information deleted successfully...!", "Deleted");

                    GetManageSessionRecord();
                    ReasetAddSessionFormControls();

                }

            }
            else
            {

                MessageBox.Show("Please select a row to delete his information...!", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE ManageSessionN SET Employee_Name_S=@Employee_Name_S, Selected_Employee_S = @Selected_Employee_S, SubCode_S = @SubCode_S, Subject_S = @Subject_S, Tag_S = @Tag_S, Group_S = @Group_S,Num_Students=@Num_Students,DurationHrs=@DurationHrs,Format=@Format WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Employee_Name_S", cmbSelEmp.Text.ToString());
                cmd.Parameters.AddWithValue("@Selected_Employee_S", cmbSelected.Text.ToString());
                cmd.Parameters.AddWithValue("@SubCode_S", comSubCode.Text.ToString());
                cmd.Parameters.AddWithValue("@Subject_S", cmbSub.Text.ToString());
                cmd.Parameters.AddWithValue("@Tag_S", cmbSelTag.Text.ToString());
                cmd.Parameters.AddWithValue("@Group_S", cmbGrp.Text.ToString());
                cmd.Parameters.AddWithValue("@Num_Students", numStudents.Value);
                cmd.Parameters.AddWithValue("@DurationHrs", textBox2.Text.ToString()); 
                cmd.Parameters.AddWithValue("@Format", textBox1.Text);

                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated successfully...!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                GetManageSessionRecord();
                ReasetAddSessionFormControls();

            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            string LectureName = cmbSelEmp.Text;
            string SelLectureName = cmbSelected.Text;
            string SubCode = comSubCode.Text;
            string Subject = cmbSub.Text;
            string Tag = cmbSelTag.Text;
            string Group = cmbGrp.Text;
            string NumStudents = numStudents.Text;
            string NumDuration = textBox2.Text;

            string Format = LectureName + " - " + SelLectureName + " - " + SubCode + " - " + Subject + " - " + Tag + " - " + Group + " - " + NumStudents + " - " + NumDuration;

            textBox1.Text = Format;
        }

        private void GrdEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(GrdsessionData.SelectedRows[0].Cells[0].Value);
            cmbSelEmp.Text = GrdsessionData.SelectedRows[0].Cells[1].Value.ToString();
            cmbSelected.Text = GrdsessionData.SelectedRows[0].Cells[2].Value.ToString();
            comSubCode.Text = GrdsessionData.SelectedRows[0].Cells[3].Value.ToString();
            cmbSub.Text = GrdsessionData.SelectedRows[0].Cells[4].Value.ToString();
            cmbSelTag.Text = GrdsessionData.SelectedRows[0].Cells[5].Value.ToString();
            cmbGrp.Text = GrdsessionData.SelectedRows[0].Cells[6].Value.ToString();
            numStudents.Text = GrdsessionData.SelectedRows[0].Cells[7].Value.ToString();
            textBox2.Text = GrdsessionData.SelectedRows[0].Cells[8].Value.ToString();
            textBox1.Text = GrdsessionData.SelectedRows[0].Cells[9].Value.ToString();


        }

        private void GrdEmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSelEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text == "Employee name")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_Name_S,Selected_Employee_S,SubCode_S,Subject_S,Tag_S,Group_S FROM ManageSessionN WHERE Employee_Name_S LIKE '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GrdsessionData.DataSource = dt;

            } else if (comboBox3.Text == "Selected employee name")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_Name_S,Selected_Employee_S,SubCode_S,Subject_S,Tag_S,Group_S FROM ManageSessionN WHERE Selected_Employee_S LIKE '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GrdsessionData.DataSource = dt;


            }
            else if (comboBox3.Text == "Subject code")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_Name_S,Selected_Employee_S,SubCode_S,Subject_S,Tag_S,Group_S FROM ManageSessionN WHERE SubCode_S LIKE '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GrdsessionData.DataSource = dt;


            }
            else if (comboBox3.Text == "Subject")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_Name_S,Selected_Employee_S,SubCode_S,Subject_S,Tag_S,Group_S FROM ManageSessionN WHERE Subject_S LIKE '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GrdsessionData.DataSource = dt;


            }
            else if (comboBox3.Text == "Tag")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_Name_S,Selected_Employee_S,SubCode_S,Subject_S,Tag_S,Group_S FROM ManageSessionN WHERE Tag_S LIKE '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GrdsessionData.DataSource = dt;


            }
            else if (comboBox3.Text == "Group")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee_Name_S,Selected_Employee_S,SubCode_S,Subject_S,Tag_S,Group_S FROM ManageSessionN WHERE Group_S LIKE '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GrdsessionData.DataSource = dt;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
