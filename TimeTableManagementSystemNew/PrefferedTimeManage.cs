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
    public partial class PrefferedTimeManage : Form
    {
        public PrefferedTimeManage()
        {
            InitializeComponent();
            //filter data from database
            fillcombo();
            fillcombo2();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int PrefId;

        void fillcombo()
        {
            String sql = "SELECT * FROM ManageSessionN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Sname = myreader.GetString(9);
                    comboBox2.Items.Add(Sname);
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


        void fillcombo2()
        {
            String sql = "SELECT * FROM ManageEmployeeN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Sname = myreader.GetString(2);
                    comboBox1.Items.Add(Sname);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void end_time_ValueChanged(object sender, EventArgs e)
        {

        }


        private void GetPreferredTimeRecord()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Preferred_Time", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            PrefGrid.DataSource = dt;
        }

        private void PrefferedTimeManage_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Value = new DateTime(2021, 12, 12, 8, 0, 0);
            dateTimePicker2.Value = new DateTime(2021, 12, 12, 16, 0, 0);
            GetPreferredTimeRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Preferred_Time VALUES(@Session, @Lecturer, @Start_Time, @End_Time,@Day)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Session", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Lecturer", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Start_Time", dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@End_Time", dateTimePicker2.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@Day", comboBox4.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPreferredTimeRecord();
                ResetValue();
            }
        }

        private bool isValid()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Session is default", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PrefId > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Preferred_Time SET Session=@Session,Lecturer=@Lecturer,Start_Time=@Start_Time,End_Time=@End_Time,Day=@Day WHERE Preferred_ID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Session", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Lecturer", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Start_Time", dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@End_Time", dateTimePicker2.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@Day",comboBox4.Text);

                cmd.Parameters.AddWithValue("@ID", this.PrefId);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated Preferred Time", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPreferredTimeRecord();
                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull Please check again", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetValue()
        {
            PrefId = 0;
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox4.Text = "";

            comboBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void PrefGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrefId = Convert.ToInt32(PrefGrid.SelectedRows[0].Cells[0].Value);
            comboBox2.Text = PrefGrid.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = PrefGrid.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = PrefGrid.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Text = PrefGrid.SelectedRows[0].Cells[4].Value.ToString();
            comboBox4.Text = PrefGrid.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PrefId > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Preferred_Time WHERE Preferred_ID=@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.PrefId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                   
                    GetPreferredTimeRecord();


                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAcademicYearAndSemester_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Preferred_Time WHERE Session LIKE '%" + keyword + "%' OR Lecturer LIKE '%" + keyword + "%' OR Start_Time LIKE '%" + keyword + "%' OR End_Time LIKE '%" + keyword + "%' OR Day LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PrefGrid.DataSource = dt;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
        }
    }
}
