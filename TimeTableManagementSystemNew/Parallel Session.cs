using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class Parallel_Session : UserControl
    {
        public Parallel_Session()
        {
           InitializeComponent();
           FillCombo();
           FillCombo2();
           FillCombo3();

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

        void FillCombo3()
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
                    comboBox3.Items.Add(sname);
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

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void Parallel_Session_Load(object sender, EventArgs e)
        {
            GetParallelRecord();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int ParallelId;

        private void GetParallelRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_parallel", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvParallelList.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid()) 
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_parallel values (@Category1, @Category2, @Category3)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Category1", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Category2", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Category3", comboBox3.Text.ToString());
               
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Parallel Session Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetParallelRecord();

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
            ParallelId = 0;
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();

            comboBox1.Focus();
        }

        private void dgvStudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ParallelId = Convert.ToInt32(dgvParallelList.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dgvParallelList.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dgvParallelList.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.Text = dgvParallelList.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ParallelId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_parallel SET Category1 = @Category1, Category2 = @Category2, Category3 = @Category3 WHERE ParallelId = @ParallelId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Category1", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Category2", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Category3", comboBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@ParallelId", this.ParallelId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Parallel Session Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetParallelRecord();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Parallel Session to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ParallelId > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROm tbl_parallel WHERE ParallelId = @ParallelId", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ParallelId", this.ParallelId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    GetParallelRecord();

                    ResetFormControls();
                }
            }
            else
            {
                MessageBox.Show("Select Parallel Session to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvParallelList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
