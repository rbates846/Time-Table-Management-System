using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class ManageSubject : Form
    {
        public ManageSubject()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int Subject_ID;
        string semester;

        private void ManageSubject_Load(object sender, EventArgs e)
        {
            GetSubjectRecord();
        }

        private void GetSubjectRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from ManageSubject", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            GrdSubjectData.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ManageSubject VALUES(@Offered_Year, @Offered_Semester, @Subject_Name, @Subject_Code, @Number_Of_Lecture_Hours, @Number_Of_Tutotial_Hours, @Number_Of_Lab_Hours, @Number_Of_Evaluation_Hours)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Offered_Year", cmbOffered.Text.ToString());
                cmd.Parameters.AddWithValue("@Offered_Semester", semester);
                cmd.Parameters.AddWithValue("@Subject_Name", txtSubtName.Text);
                cmd.Parameters.AddWithValue("@Subject_Code", txtSubCode.Text);
                cmd.Parameters.AddWithValue("@Number_Of_Lecture_Hours", numLecHourse.Text.ToString());
                cmd.Parameters.AddWithValue("@Number_Of_Tutotial_Hours", numTuteHours.Text.ToString());
                cmd.Parameters.AddWithValue("@Number_Of_Lab_Hours", numLabHourse.Text.ToString());
                cmd.Parameters.AddWithValue("@Number_Of_Evaluation_Hours", numEvaHours.Text.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New subject detail is saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSubjectRecord();
                ReasetFormControls();
            }
        }
        private bool IsValid()
        {
            if (cmbOffered.Text == String.Empty)
            {
                MessageBox.Show("Offered year is required...!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReasetFormControls();
        }

        private void ReasetFormControls()
        {
            Subject_ID = 0;

            cmbOffered.ResetText();
            radioButton1st.Checked = false;
            radioButton2nd.Checked = false;
            txtSubtName.Clear();
            txtSubCode.Clear();
            numLecHourse.Value = 0;
            numTuteHours.Value = 0;
            numLabHourse.Value = 0;
            numEvaHours.Value = 0;

            cmbOffered.Focus();
        }

        private void radioButton1st_CheckedChanged(object sender, EventArgs e)
        {
            semester = "1";
        }

        private void radioButton2nd_CheckedChanged(object sender, EventArgs e)
        {
            semester = "2";
        }

        private void GrdSubjectData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Subject_ID = Convert.ToInt32(GrdSubjectData.SelectedRows[0].Cells[0].Value);
            cmbOffered.Text = GrdSubjectData.SelectedRows[0].Cells[1].Value.ToString();
            semester = GrdSubjectData.SelectedRows[0].Cells[2].Value.ToString();
            txtSubtName.Text = GrdSubjectData.SelectedRows[0].Cells[3].Value.ToString();
            txtSubCode.Text = GrdSubjectData.SelectedRows[0].Cells[4].Value.ToString();
            numLecHourse.Text = GrdSubjectData.SelectedRows[0].Cells[5].Value.ToString();
            numTuteHours.Text = GrdSubjectData.SelectedRows[0].Cells[6].Value.ToString();
            numLabHourse.Text = GrdSubjectData.SelectedRows[0].Cells[7].Value.ToString();
            numEvaHours.Text = GrdSubjectData.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Subject_ID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE ManageSubject SET Offered_Year=@Offered_Year, Offered_Semester = @Offered_Semester, Subject_Name = @Subject_Name, Subject_Code = @Subject_Code, Number_Of_Lecture_Hours = @Number_Of_Lecture_Hours, Number_Of_Tutotial_Hours = @Number_Of_Tutotial_Hours, Number_Of_Lab_Hours = @Number_Of_Lab_Hours, Number_Of_Evaluation_Hours = @Number_Of_Evaluation_Hours WHERE Subject_ID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Offered_Year", cmbOffered.Text.ToString());
                cmd.Parameters.AddWithValue("@Offered_Semester", semester);
                cmd.Parameters.AddWithValue("@Subject_Name", txtSubtName.Text);
                cmd.Parameters.AddWithValue("@Subject_Code", txtSubCode.Text);
                cmd.Parameters.AddWithValue("@Number_Of_Lecture_Hours", numLecHourse.Text.ToString());
                cmd.Parameters.AddWithValue("@Number_Of_Tutotial_Hours", numTuteHours.Text.ToString());
                cmd.Parameters.AddWithValue("@Number_Of_Lab_Hours", numLabHourse.Text.ToString());
                cmd.Parameters.AddWithValue("@Number_Of_Evaluation_Hours", numEvaHours.Text.ToString());
                cmd.Parameters.AddWithValue("@ID", this.Subject_ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Subject information updated successfully...!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetSubjectRecord();
                ReasetFormControls();
            }
            else
            {

                MessageBox.Show("Please select a row to update his information...!", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (Subject_ID > 0)
            {

                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM ManageSubject WHERE Subject_ID = @ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.Subject_ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Subject information deleted successfully...!", "Deleted");

                    GetSubjectRecord();
                    ReasetFormControls();
                }

            }
            else
            {

                MessageBox.Show("Please select a row to delete his information...!", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           /* SqlCommand cmd = new SqlCommand("Select * from ManageSubject WHERE Subject_Name='" + txtboxSearch.Text + "' ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            GrdSubjectData.DataSource = dt;*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            ///Get the Value from Text Box
            string keyword = txtboxSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ManageSubject WHERE Offered_Year LIKE '%" + keyword + "%' OR Offered_Semester LIKE '%" + keyword + "%' OR Subject_Name LIKE '%" + keyword + "%' OR Subject_Code LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GrdSubjectData.DataSource = dt;
        }

        private void cmbOffered_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrdSubjectData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
