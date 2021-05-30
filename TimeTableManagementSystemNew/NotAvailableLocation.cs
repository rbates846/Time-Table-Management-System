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
    public partial class NotAvailableLocation : UserControl
    {
        public NotAvailableLocation()
        {
            InitializeComponent();
            fillcombo();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int NotALid;


        void fillcombo()
        {
            String sql = "SELECT * FROM tbl_Room";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Rname = myreader.GetString(2);
                    comboBox1.Items.Add(Rname);
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




        private void NotAvailableLocation_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2021, 12, 12, 8, 0, 0);
            dateTimePicker2.Value = new DateTime(2021, 12, 12, 16, 0, 0);
            GetNotAvailableLocationRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Not_Available_Location VALUES(@Room, @Day, @Start_Time, @End_Time)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Day", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Start_Time", dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@End_Time", dateTimePicker2.Value.ToString("hh:mm tt"));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetNotAvailableLocationRecord();
                ResetValue();
            }
        }

        private bool isValid()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Room is default", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            NotALid = 0;
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";

            comboBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NotALid > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Not_Available_Location SET Room=@Room,Day=@Day,Start_Time=@Start_Time,End_Time=@End_Time WHERE Not_Available_LocID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Day", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Start_Time", dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@End_Time", dateTimePicker2.Value.ToString("hh:mm tt"));

                cmd.Parameters.AddWithValue("@ID", this.NotALid);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated Not Available Location", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetNotAvailableLocationRecord();
                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull Please check again", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNotAvailableLocationRecord()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Not_Available_Location", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NotALid = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NotALid > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Not_Available_Location WHERE Not_Available_LocID=@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.NotALid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                  
                    GetNotAvailableLocationRecord();


                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
