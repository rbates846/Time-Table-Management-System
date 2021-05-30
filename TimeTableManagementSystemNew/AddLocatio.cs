using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TimeTableManagementSystemNew
{
    public partial class AddLocatio : Form
    {
        public AddLocatio()
        {
            InitializeComponent();
        }

        string loc;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int RoomID;


        private void GetlocationRecord()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Room", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void AddLocatio_Load(object sender, EventArgs e)
        {
            GetlocationRecord();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO  tbl_Room VALUES(@BuildingName, @RoomName, @LectureHall, @Laboratory, @Capacity)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@BuildingName", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@RoomName", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@LectureHall", checkBox1.Checked);
                cmd.Parameters.AddWithValue("@Laboratory", checkBox2.Checked);
                cmd.Parameters.AddWithValue("@Capacity", textBox5.Text);
        
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetlocationRecord();
                ResetValue();
            }
        }


        private bool isValid()
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Buildin name is default ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RoomID > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Room WHERE RoomID=@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.RoomID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                   
                    GetlocationRecord();

                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RoomID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE tbl_Room SET BuildingName=@BuildingName,RoomName=@RoomName,LectureHall= @LectureHall,Laboratory=@Laboratory,Capacity=@Capacity WHERE RoomID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@BuildingName",textBox2.Text);
                cmd.Parameters.AddWithValue("@RoomName",textBox3.Text);
                cmd.Parameters.AddWithValue("@LectureHall",checkBox1.Checked);
                cmd.Parameters.AddWithValue("@Laboratory",checkBox2.Checked);
                cmd.Parameters.AddWithValue("@Capacity",textBox5.Text);

                cmd.Parameters.AddWithValue("@ID", this.RoomID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated locations", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetlocationRecord();
                ResetValue();
            }
            else
            {
                MessageBox.Show("UnSuccessfull Please check again", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void ResetValue()
        {
            RoomID = 0;
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox5.Clear();
            textBox2.Focus();
        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[3].Value);
            checkBox2.Checked = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[4].Value);
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
