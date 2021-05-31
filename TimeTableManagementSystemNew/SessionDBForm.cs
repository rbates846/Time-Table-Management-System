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
    public partial class SessionDBForm : Form
    {
        public SessionDBForm()
        {
            InitializeComponent();
            FillCombo1();
            FillCombo2();
            FillCombo3();

        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");

        public int ID;


        private void FillCombo1()
        {
            string sql = "Select * from Session_Location";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(1);
                    cmbFull.Items.Add(subCode);
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
            string sql = "Select * from tbl_Timeslots";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(1);
                    comboBox2.Items.Add(subCode);
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

            string sql = "Select * from tbl_Timeslots";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(2);
                    comboBox4.Items.Add(subCode);
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

        private void SessionDBForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string start = comboBox2.Text;
            string end = comboBox4.Text;
            string timeslot = start + " - " + end;

            textBox1.Text = timeslot;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into sessionsDB values (@Format , @time, @day)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Format", cmbFull.Text.ToString());
         
                cmd.Parameters.AddWithValue("@time", textBox1.Text);
                cmd.Parameters.AddWithValue("@day", comboBox3.Text.ToString());



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                ResetFormControls();
            }

            this.Close();
            TimeTableGenerate FRM = new TimeTableGenerate();
            FRM.Show();



        }


        private bool IsValid()
        {
            if (cmbFull.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Full Format is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void ResetFormControls()
        {

            cmbFull.ResetText();
            comboBox3.ResetText();
            comboBox2.ResetText();
            comboBox4.ResetText();
            textBox1.Clear();

            cmbFull.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageNotAvailableLocation back = new ManageNotAvailableLocation();
            back.Show();
        }
    }
}
