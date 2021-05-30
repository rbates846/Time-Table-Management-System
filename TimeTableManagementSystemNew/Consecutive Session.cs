using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class Consecutive_Session : UserControl
    {
        public Consecutive_Session()
        {
            InitializeComponent();
            FillCombo();
            FillCombo2();

        }

        void FillCombo()
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
                    string sname = myreader.GetString(9);
                    comboBox1.Items.Add(sname);
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

        void FillCombo2()
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
                    string sname = myreader.GetString(9);
                    comboBox2.Items.Add(sname);
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");

        public int ConsecutiveId;
        private void Consecutive_Session_Load(object sender, EventArgs e)
        {
            GetConsecutiveRecords();
            
        }

        private void GetConsecutiveRecords()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_Consecutive", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvConsecutivelList.DataSource = dt;

        }

       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_Consecutive values (@ConsecutiveSession1, @ConsecutiveSession2)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ConsecutiveSession1", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@ConsecutiveSession2", comboBox2.Text.ToString());
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Consecutive Session Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetConsecutiveRecords();

                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Session is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            ConsecutiveId = 0;
            comboBox1.ResetText();
            comboBox2.ResetText();

            comboBox1.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ConsecutiveId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_Consecutive SET ConsecutiveSession1 = @ConsecutiveSession1, ConsecutiveSession2 = @ConsecutiveSession2 WHERE ConsecutiveId = @ConsecutiveId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ConsecutiveSession1", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@ConsecutiveSession2", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@ConsecutiveId", this.ConsecutiveId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Consecutive Session Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetConsecutiveRecords();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Session to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ConsecutiveId > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Consecutive WHERE ConsecutiveId = @ConsecutiveId", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ConsecutiveId", this.ConsecutiveId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                   

                    GetConsecutiveRecords();

                    ResetFormControls();
                }
            }
            else
            {
                MessageBox.Show("Select Session to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsecutivelList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ConsecutiveId = Convert.ToInt32(dgvConsecutivelList.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dgvConsecutivelList.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dgvConsecutivelList.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
