using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTableManagementSystemNew
{
    public partial class ManageTimeSlots : Form
    {
        public ManageTimeSlots()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int slotid;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Timeslots VALUES(@StartTime,@EndTime,@Type)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StartTime",dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@EndTime",dateTimePicker2.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@Type",type.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTimeSlotRecord();
                ResetValue();
            }
        }

        private bool isValid()
        {
           if(dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("Time Slot is default ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            slotid = 0;
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            type.Text = "";

            dateTimePicker1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (slotid > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Timeslots WHERE TimeSlotID=@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.slotid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                   

                    GetTimeSlotRecord();
                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
              if(slotid > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE tbl_Timeslots SET Start_Time=@StartTime,End_Time=@EndTime,Type=@Type WHERE TimeSlotID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StartTime", dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@EndTime", dateTimePicker2.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@Type", type.Text);
                cmd.Parameters.AddWithValue("@ID",this.slotid);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTimeSlotRecord();
                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = search.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Timeslots WHERE TimeSlotID LIKE '%" + keyword + "%' OR Start_Time LIKE '%" + keyword + "%' OR End_Time LIKE '%" + keyword + "%' OR Type LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            timeSlotGrid.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Timeslots WHERE TimeSlotID='" + int.Parse(search.Text) + "' ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            timeSlotGrid.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageTimeSlots_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Value = new DateTime(2021, 12, 12, 8, 0, 0);
            dateTimePicker2.Value = new DateTime(2021, 12, 12, 16, 0, 0);
            GetTimeSlotRecord();


        }

        private void GetTimeSlotRecord()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Timeslots", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            timeSlotGrid.DataSource = dt;
        }


        //Method to clear fields
        public void Clear()
        {
           
        }

        private void timeSlotGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeSlotGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            slotid = Convert.ToInt32(timeSlotGrid.SelectedRows[0].Cells[0].Value);
            dateTimePicker1.Text = timeSlotGrid.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker2.Text = timeSlotGrid.SelectedRows[0].Cells[2].Value.ToString();
            type.Text = timeSlotGrid.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void end_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void end_time_min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
