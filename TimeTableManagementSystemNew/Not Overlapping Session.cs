using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class Not_Overlapping_Session : UserControl
    {
        public Not_Overlapping_Session()
        {
            InitializeComponent();
            FillCombo();
            FillCombo2();
        }

        void FillCombo()
        {
            string sql = "Select * from ManageSubject";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(3);
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
            string sql = "Select * from ManageSubject";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(3);
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

        private void Not_Overlapping_Session_Load(object sender, EventArgs e)
        {
            GetNonOverlappingRecords();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int NotOverlappingId;
        private void GetNonOverlappingRecords()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_not_overlapping", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvNonOverlappingList.DataSource = dt;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid()) 
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_not_overlapping values (@Category1, @Category2)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Category1", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Category2", comboBox2.Text.ToString());
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Non-Overlapping Session Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNonOverlappingRecords();

                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Category 1 is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            NotOverlappingId = 0;
            comboBox1.ResetText();
            comboBox2.ResetText();

            comboBox1.Focus();
        }

        private void dgvNonOverlappingList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NotOverlappingId = Convert.ToInt32(dgvNonOverlappingList.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dgvNonOverlappingList.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dgvNonOverlappingList.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NotOverlappingId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_not_overlapping SET Category1 = @Category1, Category2 = @Category2 WHERE NotOverlappingId = @NotOverlappingId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Category1", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Category2", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@NotOverlappingId", this.NotOverlappingId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Non-Overlapping Session Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNonOverlappingRecords();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Non-Overlapping Session to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (NotOverlappingId > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROm tbl_not_overlapping WHERE NotOverlappingId = @NotOverlappingId", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@NotOverlappingId", this.NotOverlappingId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Non-Overlapping Session Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNonOverlappingRecords();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Non-Overlapping Session to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
