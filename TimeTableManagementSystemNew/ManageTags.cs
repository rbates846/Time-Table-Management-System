using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TimeTableManagementSystemNew
{
    public partial class ManageTags : Form
    {
        public ManageTags()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ///Get the Value from Text Box
            string keyword = txtBoxSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_tag WHERE TagName LIKE '%" + keyword + "%' OR TagCode LIKE '%" + keyword + "%' OR RelatedTag LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTagList.DataSource = dt;
        }

        private void ManageTags_Load(object sender, EventArgs e)
        {
            GetTagRecord();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");

        public int TagId;

        private void GetTagRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_tag", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvTagList.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_tag values (@TagName, @TagCode, @RelatedTag)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TagName", txtBoxTagName.Text);
                cmd.Parameters.AddWithValue("@TagCode", txtBoxTagCode.Text);
                cmd.Parameters.AddWithValue("@RelatedTag", txtBoxRelatedTag.Text.ToString());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Tag Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTagRecord();

                ResetFormControls();
            }

        }
        private bool IsValid()
        {
            if (txtBoxTagName.Text == string.Empty)
            {
                MessageBox.Show("Tag Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            TagId = 0;
            txtBoxTagName.Clear();
            txtBoxTagCode.Clear();
            txtBoxRelatedTag.ResetText();

            txtBoxTagName.Focus();
        }

        private void dgvTagList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TagId = Convert.ToInt32(dgvTagList.SelectedRows[0].Cells[0].Value);
            txtBoxTagName.Text = dgvTagList.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxTagCode.Text = dgvTagList.SelectedRows[0].Cells[2].Value.ToString();
            txtBoxRelatedTag.Text = dgvTagList.SelectedRows[0].Cells[3].Value.ToString();
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TagId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_tag SET TagName = @TagName, TagCode = @TagCode, RelatedTag = @RelatedTag WHERE TagId = @TagId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TagName", txtBoxTagName.Text);
                cmd.Parameters.AddWithValue("@TagCode", txtBoxTagCode.Text);
                cmd.Parameters.AddWithValue("@RelatedTag", txtBoxRelatedTag.Text.ToString());
                cmd.Parameters.AddWithValue("@TagId", this.TagId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Tag Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTagRecord();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Tag to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (TagId > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROm tbl_tag WHERE TagId = @TagId", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@TagId", this.TagId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    

                    GetTagRecord();

                    ResetFormControls();
                }
            }
            else
            {
                MessageBox.Show("Select Tag to Delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
