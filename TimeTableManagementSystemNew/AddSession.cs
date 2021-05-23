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

    public partial class AddSession : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True;");
       
        public int ID;
        SqlCommand cmd;

        public AddSession()
        {
            InitializeComponent();
            FillCombo1();
            FillCombo2();
            FillCombo3();
            FillCombo4();
            FillCombo5();
            FillCombo6();
            FillCombo7();
        }

        

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
            finally {
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

        private void FillCombo7()
        {

            string sql = "Select * from AssignActiveHrs";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subGrpId = myreader.GetInt32(5) + ":" + myreader.GetInt32(6);
                    cmbDuration.Items.Add(subGrpId);
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

        private void dataGridFormat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddSession_Load(object sender, EventArgs e)
        {
          

        }

        private void cmbSelEmp_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        

        private void cmbSelTag_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbselectedEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comSubCode_SelectedIndexChanged(object sender, EventArgs e)
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
            string NumDuration = cmbDuration.Text;
          
            string Format = LectureName + " - "+ SelLectureName + " - " + SubCode+" - "+ Subject + " - " + Tag + " - " + Group + " - " + NumStudents + " - " + NumDuration ;

            textBox1.Text = Format; 
        }

        private void lblAddSession_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectEmp_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            cmbDuration.ResetText();
            textBox1.ResetText();

            cmbSelEmp.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
               SqlCommand cmd = new SqlCommand("INSERT INTO ManageSessionN VALUES(@Employee_Name_S, @Selected_Employee_S, @SubCode_S, @Subject_S, @Tag_S, @Group_S, @Num_Students, @DurationHrs,@Format)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Employee_Name_S", cmbSelEmp.Text.ToString());
                cmd.Parameters.AddWithValue("@Selected_Employee_S", cmbSelected.Text.ToString());
                cmd.Parameters.AddWithValue("@SubCode_S", comSubCode.Text.ToString());
                cmd.Parameters.AddWithValue("@Subject_S", cmbSub.Text.ToString());
                cmd.Parameters.AddWithValue("@Tag_S", cmbSelTag.Text.ToString());
                cmd.Parameters.AddWithValue("@Group_S", cmbGrp.Text.ToString());
                cmd.Parameters.AddWithValue("@Num_Students", numStudents.Text.ToString());
                cmd.Parameters.AddWithValue("@DurationHrs", cmbDuration.Text.ToString()); 
                cmd.Parameters.AddWithValue("@Format", textBox1.Text.ToString());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New session is saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                ReasetAddSessionFormControls();

                this.Hide();
                ManageSessionN next = new ManageSessionN();
                next.Show();
            }
        }


        private bool IsValid()
        {
            if (cmbSelEmp.Text == String.Empty)
            {
                MessageBox.Show("Employee name is required...!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
