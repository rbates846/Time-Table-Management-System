using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class WorkingDaysandHours : Form
    {
        public WorkingDaysandHours()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int timeslotID;


        private void GetTimeSlotRecord()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM No_of_Working_Days", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            workgrid.DataSource = dt;
        }

        private void WorkingDaysandHours_Load(object sender, EventArgs e)
        {
            GetTimeSlotRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO  No_of_Working_Days VALUES(@NoofWorkDay, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday,@Working_Hours_W,@Working_Mins_W,@Saturday,@Sunday,@Working_Hours_WE,@Working_Mins_WE)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NoofWorkDay", NoOfWorkingDays.Value);
                cmd.Parameters.AddWithValue("@Monday", Monday.Checked);
                cmd.Parameters.AddWithValue("@Tuesday",Tuesday.Checked);
                cmd.Parameters.AddWithValue("@Wednesday",Wednesday.Checked);
                cmd.Parameters.AddWithValue("@Thursday", Thursday.Checked);
                cmd.Parameters.AddWithValue("@Friday", Friday.Checked);
                cmd.Parameters.AddWithValue("@Working_Hours_W", WeekHr.Value);
                cmd.Parameters.AddWithValue("@Working_Mins_W", weekM.Value);
                cmd.Parameters.AddWithValue("@Saturday", Saturday.Checked);
                cmd.Parameters.AddWithValue("@Sunday", Sunday.Checked);
                cmd.Parameters.AddWithValue("@Working_Hours_WE", WEHr.Value);
                cmd.Parameters.AddWithValue("@Working_Mins_WE", WEM.Value);

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
            if (NoOfWorkingDays.Text == string.Empty)
            {
                MessageBox.Show("Working Days is default ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ResetValue()
        {
            timeslotID = 0;
            NoOfWorkingDays.Value = 0;
            Monday.Checked = false;
            Tuesday.Checked = false;
            Wednesday.Checked = false;
            Thursday.Checked = false;
            Friday.Checked = false;
            WeekHr.Value = 0;
            weekM.Value = 0;
            Saturday.Checked = false;
            Sunday.Checked = false;
            WEHr.Value = 0;
            WEM.Value = 0;
        
            NoOfWorkingDays.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timeslotID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE No_of_Working_Days SET NoofWorkDay=@NoofWorkDay,Monday=@Monday, Tuesday=@Tuesday, Wednesday=@Wednesday,Thursday=@Thursday,Friday=@Friday, Working_Hours_W=@Working_Hours_W,Working_Mins_W=@Working_Mins_W, Saturday=@Saturday, Sunday=@Sunday, Working_Hours_WE=@Working_Hours_WE, Working_Mins_WE=@Working_Mins_WE  WHERE WorkID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NoofWorkDay", NoOfWorkingDays.Value);
                cmd.Parameters.AddWithValue("@Monday", Monday.Checked);
                cmd.Parameters.AddWithValue("@Tuesday", Tuesday.Checked);
                cmd.Parameters.AddWithValue("@Wednesday", Wednesday.Checked);
                cmd.Parameters.AddWithValue("@Thursday", Thursday.Checked);
                cmd.Parameters.AddWithValue("@Friday", Friday.Checked);
                cmd.Parameters.AddWithValue("@Working_Hours_W", WeekHr.Value);
                cmd.Parameters.AddWithValue("@Working_Mins_W", weekM.Value);
                cmd.Parameters.AddWithValue("@Saturday", Saturday.Checked);
                cmd.Parameters.AddWithValue("@Sunday", Sunday.Checked);
                cmd.Parameters.AddWithValue("@Working_Hours_WE", WEHr.Value);
                cmd.Parameters.AddWithValue("@Working_Mins_WE", WEM.Value);

                cmd.Parameters.AddWithValue("@ID", this.timeslotID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated Working Days and Hours", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTimeSlotRecord();
                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull Please check again", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void workgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timeslotID = Convert.ToInt32(workgrid.SelectedRows[0].Cells[0].Value);
            NoOfWorkingDays.Text = workgrid.SelectedRows[0].Cells[1].Value.ToString();
            Monday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[2].Value);
            Tuesday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[3].Value);
            Wednesday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[4].Value);
            Thursday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[5].Value);
            Friday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[6].Value);
            WeekHr.Text = workgrid.SelectedRows[0].Cells[7].Value.ToString();
            weekM.Text = workgrid.SelectedRows[0].Cells[8].Value.ToString();
            Saturday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[9].Value);
            Sunday.Checked = Convert.ToBoolean(workgrid.SelectedRows[0].Cells[10].Value);
            WEHr.Text = workgrid.SelectedRows[0].Cells[11].Value.ToString();
            WEM.Text = workgrid.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (timeslotID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM No_of_Working_Days WHERE WorkID=@ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.timeslotID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Deleted Working Days and Hours", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTimeSlotRecord();


                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string keyword = search.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM No_of_Working_Days WHERE WorkID LIKE '%" + keyword + "%' OR NoofWorkDay LIKE '%" + keyword + "%' OR Monday LIKE '%" + keyword + "%' OR Working_Hours_W LIKE '%" + keyword + "%' OR Working_Mins_W LIKE '%" + keyword + "%'  OR Saturday LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            workgrid.DataSource = dt;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
