using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTableManagementSystemNew
{
    public partial class AddSessionLocation: UserControl
    {
        public AddSessionLocation()
        {
            InitializeComponent();
            FillCombo1();
            FillCombo2();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int SessionRoomID;

        private void FillCombo1()
        {
            string sql = "Select * from ManageSessionN";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(9);
                    session.Items.Add(subCode);
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
            string sql = "Select * from tbl_Room";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(2);
                    RoomL.Items.Add(subCode);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddSessionLocation_Load(object sender, EventArgs e)
        {
            GetManageSessionRecord();
        }

        private void GetManageSessionRecord()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Session_Location", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
            }
            finally
            {

                con.Close();
            }

        }

        private void btnGenerateId_Click(object sender, EventArgs e)
        {
            string Session = session.Text;
            string Room = RoomL.Text;

            string Genarate = Session + " - " + Room;

            richTextBox1.Text = Genarate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Session_Location VALUES (@Selected_Session,@Preferred) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Selected_Session ", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@Preferred ", checkBox1.Checked);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetManageSessionRecord();
                ResetValue();
            }
        }

        private bool isValid()
        {
            if (richTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Selected Session is default ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ResetValue()
        {
            SessionRoomID = 0;
            session.Text = "";
            RoomL.Text = "";
            richTextBox1.Clear();
            checkBox1.Checked = false;

            richTextBox1.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SessionRoomID > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Session_Location WHERE SID=@ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.SessionRoomID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    GetManageSessionRecord();


                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
