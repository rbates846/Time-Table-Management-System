using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TimeTableManagementSystemNew
{
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int StudentID;
        

        private void GetStudentsRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from tbl_student" , con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvStudentList.DataSource = dt;

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid()) 
            {
                SqlCommand cmd = new SqlCommand("Insert into tbl_student values (@AcademicYearAndSemester, @Programme, @GroupNumber, @SubGroupNumber, @GroupId, @SubGroupId)" , con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AcademicYearAndSemester", txtBoxAcedemicYearAndSemester.Text);
                cmd.Parameters.AddWithValue("@Programme", txtBoxProgramme.Text.ToString());
                cmd.Parameters.AddWithValue("@GroupNumber", GroupNumber.Value);
                cmd.Parameters.AddWithValue("@SubGroupNumber", SubGroupNumber.Value);
                cmd.Parameters.AddWithValue("@GroupId", txtBoxGroupId.Text);
                cmd.Parameters.AddWithValue("@SubGroupId", txtBoxSubGroupId.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student Successfully Inserted", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();

                ResetFormControls();

            }

        }

        private bool IsValid()
        {
            if (txtBoxAcedemicYearAndSemester.Text == string.Empty)
            {
                MessageBox.Show("Acedemic Year And Semester is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnGenerateId_Click(object sender, EventArgs e)
        {
            string a = txtBoxAcedemicYearAndSemester.Text;
            int b = (int)GroupNumber.Value;
            int c = (int)SubGroupNumber.Value;

            string d = a + "." + b;
            string f = d + "." + c;

            txtBoxGroupId.Text = d;
            txtBoxSubGroupId.Text = f;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFormControls();

        }

        private void ResetFormControls()
        {
            StudentID = 0;
            txtBoxAcedemicYearAndSemester.Clear();
            txtBoxProgramme.ResetText();
            GroupNumber.Value = 0;
            SubGroupNumber.Value = 0;
            txtBoxGroupId.Clear();
            txtBoxSubGroupId.Clear();

            txtBoxAcedemicYearAndSemester.Focus();
        }

        private void dgvStudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentID = Convert.ToInt32 (dgvStudentList.SelectedRows[0].Cells[0].Value);
            txtBoxAcedemicYearAndSemester.Text = dgvStudentList.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxProgramme.Text = dgvStudentList.SelectedRows[0].Cells[2].Value.ToString();
            GroupNumber.Text = dgvStudentList.SelectedRows[0].Cells[3].Value.ToString();
            SubGroupNumber.Text = dgvStudentList.SelectedRows[0].Cells[4].Value.ToString();
            txtBoxGroupId.Text = dgvStudentList.SelectedRows[0].Cells[5].Value.ToString();
            txtBoxSubGroupId.Text = dgvStudentList.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtBoxStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_student SET AcademicYearAndSemester = @AcademicYearAndSemester, Programme = @Programme, GroupNumber = @GroupNumber, SubGroupNumber = @SubGroupNumber, GroupId = @GroupId, SubGroupId = @SubGroupId WHERE StudentID = @StudentID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@AcademicYearAndSemester", txtBoxAcedemicYearAndSemester.Text);
                cmd.Parameters.AddWithValue("@Programme", txtBoxProgramme.Text.ToString());
                cmd.Parameters.AddWithValue("@GroupNumber", GroupNumber.Value);
                cmd.Parameters.AddWithValue("@SubGroupNumber", SubGroupNumber.Value);
                cmd.Parameters.AddWithValue("@GroupId", txtBoxGroupId.Text);
                cmd.Parameters.AddWithValue("@SubGroupId", txtBoxSubGroupId.Text);
                cmd.Parameters.AddWithValue("@StudentID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();

                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Select Student to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROm tbl_student WHERE StudentID = @StudentID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@StudentID", this.StudentID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    
                    GetStudentsRecord();

                    ResetFormControls();
                }
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_student WHERE AcademicYearAndSemester LIKE '%" + keyword + "%' OR Programme LIKE '%" + keyword + "%' OR GroupId LIKE '%" + keyword + "%' OR SubGroupId LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStudentList.DataSource = dt;


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
