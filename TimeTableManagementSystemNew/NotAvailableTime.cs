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
    public partial class NotAvailableTime : UserControl
    {
        public NotAvailableTime()
        {
            InitializeComponent();
            fillcombo();
            fillcombo1();
            fillcombo2();
            fillcombo3();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int NotATid;

        void fillcombo()
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
                    string lname = myreader.GetString(2);
                    comboBox1.Items.Add(lname);
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

        void fillcombo1()
        {
            String sql = "SELECT * FROM tbl_student";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string lname = myreader.GetString(5);
                    comboBox2.Items.Add(lname);
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
            String sql = "SELECT * FROM tbl_student";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string lname = myreader.GetString(6);
                    comboBox3.Items.Add(lname);
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

        void fillcombo3()
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
                    string lname = myreader.GetString(9);
                    comboBox4.Items.Add(lname);
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



        private void NotAvailableTime_Load(object sender, EventArgs e)
        {
            GetNotAvailableTimeRecord();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Not_Available_Time VALUES(@Lecturer, @Group_, @Sub_Group, @Session, @Duration_Hours, @Duration_Minitues)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Group_", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Sub_Group", comboBox3.Text);
                cmd.Parameters.AddWithValue("@Session", comboBox4.Text);
                cmd.Parameters.AddWithValue("@Duration_Hours",DueH.Value);
                cmd.Parameters.AddWithValue("@Duration_Minitues",DueM.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetNotAvailableTimeRecord();
                ResetValue();
            }
        }


        private bool isValid()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Lecturer is default ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void ResetValue()
        {
            NotATid = 0;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            DueH.Value = 0;
            DueM.Value = 0;

            comboBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NotATid > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Not_Available_Time SET Lecturer=@Lecturer, Group_=@Group_, Sub_Group=@Sub_Group, Session=@Session,Duration_Hours=@Duration_Hours, Duration_Minitues=@Duration_Minitues WHERE NotAvailableId= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Group_", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Sub_Group",comboBox3.Text);
                cmd.Parameters.AddWithValue("@Session", comboBox4.Text);
                cmd.Parameters.AddWithValue("@Duration_Hours", DueH.Value);
                cmd.Parameters.AddWithValue("@Duration_Minitues", DueM.Value);
                cmd.Parameters.AddWithValue("@ID", this.NotATid);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated Not Available Time", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetNotAvailableTimeRecord();
                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull Please check again", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNotAvailableTimeRecord()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Not_Available_Time", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NotATid = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            comboBox4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            DueH.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            DueM.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NotATid > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Not_Available_Time WHERE NotAvailableId=@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.NotATid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully Deleted Not Available Time", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetNotAvailableTimeRecord();


                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Not_Available_Time WHERE Lecturer LIKE '%" + keyword + "%' OR Group_ LIKE '%" + keyword + "%' OR Sub_Group LIKE '%" + keyword + "%' OR Session LIKE '%" + keyword + "%' OR Duration_Hours LIKE '%" + keyword + "%'  OR Duration_Minitues LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
