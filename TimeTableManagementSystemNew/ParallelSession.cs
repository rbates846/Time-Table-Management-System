using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace TimeTableManagementSystemNew
{
    public partial class ParallelSession : Form
    {
        public ParallelSession()
        {
            InitializeComponent();
            FillCombo();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2T13G7F\SQLEXPRESS;Initial Catalog=TimeTable;Integrated Security=True");
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
                    guna2ComboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ParallelSession_Load(object sender, EventArgs e)
        {
            GetPrallelRecords();
        }

        public int ParallelId;
        private void GetPrallelRecords()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_parallel", con);
                DataTable dt = new DataTable();
                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dgvParallelList.DataSource = dt;
            }
            catch (Exception ex)
            {

            }

            finally
            {
                con.Close();
            }
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_parallel values (@Category1, @Category2, @Category3)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Category1", guna2ComboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Category2", guna2ComboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Category3", guna2ComboBox3.Text.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Parallel Session Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPrallelRecords();

                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (guna2ComboBox1.Text == string.Empty)
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
            guna2ComboBox1.ResetText();
            guna2ComboBox2.ResetText();
            guna2ComboBox3.ResetText();

            guna2ComboBox1.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ParallelId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_parallel SET Category1 = @Category1, Category2 = @Category2, Category3 = @Category3 WHERE ParallelId = @ParallelId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Category1", guna2ComboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Category2", guna2ComboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Category3", guna2ComboBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@ParallelId", this.ParallelId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Parallel Session Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPrallelRecords();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Parallel Session to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ParallelId > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROm tbl_parallel WHERE ParallelId = @ParallelId", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ParallelId", this.ParallelId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Parallel Session Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPrallelRecords();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Student to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ///Get the Value from Text Box

            string keyword = txtBoxSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_parallel WHERE Category1 LIKE '%" + keyword + "%' OR Category2 LIKE '%" + keyword + "%' OR Category3 LIKE '%", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvParallelList.DataSource = dt;
        }

        private void dgvParallelList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvParallelList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ParallelId = Convert.ToInt32(dgvParallelList.SelectedRows[0].Cells[0].Value);
            guna2ComboBox1.Text = dgvParallelList.SelectedRows[0].Cells[1].Value.ToString();
            guna2ComboBox2.Text = dgvParallelList.SelectedRows[0].Cells[2].Value.ToString();
            guna2ComboBox3.Text = dgvParallelList.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
