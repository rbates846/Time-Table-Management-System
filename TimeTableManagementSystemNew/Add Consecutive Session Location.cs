using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class Add_Consecutive_Session_Location : UserControl
    {
        public Add_Consecutive_Session_Location()
        {
            InitializeComponent();
            FillCombo1();
            FillCombo2();
            FillCombo3();
            FillCombo4();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int ConsecutiveID;

        private void FillCombo1()
        {
            string sql = "Select * from tbl_Consecutive";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(1);
                    comboBox1.Items.Add(subCode);
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
            string sql = "Select * from tbl_Consecutive";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string subCode = myreader.GetString(2);
                    comboBox3.Items.Add(subCode);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Add_Consecutive_Session_Location_Load(object sender, EventArgs e)
        {
            GetManagecon();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Manage_Consecutive_Location VALUES (@Session_Location1,@Session_Location2) ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Session_Location1 ", textBox1.Text);
                cmd.Parameters.AddWithValue("@Session_Location2 ", textBox2.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetValue();


                GetManagecon();

            }
        }

        private bool isValid()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Selected Session is default ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void GetManagecon()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Manage_Consecutive_Location", con);
                DataTable dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dgvConsecutiveLocationlList.DataSource = dt;

            }
            catch (Exception ex)
            {
            }
            finally
            {

                con.Close();
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        
        }

        private void ResetValue()
        {
            ConsecutiveID = 0;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox1.Clear();
            textBox2.Clear();



            comboBox1.Focus();
        }

        private void btnGenerateId_Click(object sender, EventArgs e)
        {
            string Session1 = comboBox1.Text;
            string Room1 = comboBox2.Text;
            string Session2 = comboBox3.Text;
            string Room2 = comboBox4.Text;

            string Genarate1 = Session1 + " - " + Room1;
            string Genarate2 = Session2 + " - " + Room2;

            textBox1.Text = Genarate1;
            textBox2.Text = Genarate2;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ConsecutiveID > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROm Manage_Consecutive_Location WHERE CId = @CId", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@CId", this.ConsecutiveID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    GetManagecon();

                    ResetValue();
                }
            }
            else
            {
                MessageBox.Show("Select Session to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsecutiveLocationlList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ConsecutiveID = Convert.ToInt32(dgvConsecutiveLocationlList.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dgvConsecutiveLocationlList.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dgvConsecutiveLocationlList.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void dgvConsecutiveLocationlList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
