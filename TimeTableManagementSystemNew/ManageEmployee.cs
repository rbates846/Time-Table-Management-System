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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        public int EID;

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            GetEmployeeRecord();
        }

        private void GetEmployeeRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from ManageEmployeeN", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            GrdEmployeeData.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ManageEmployeeN VALUES(@EmployeeID, @EmployeeName, @Faculty, @Department, @Center, @Building, @EmpLevel, @Rank)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@EmployeeID", txtboxEmpID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@Faculty", cmbFaculty.Text.ToString());
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text.ToString());
                cmd.Parameters.AddWithValue("@Center", cmbCenter.Text.ToString());
                cmd.Parameters.AddWithValue("@Building", cmbBuilding.Text.ToString());
                cmd.Parameters.AddWithValue("@EmpLevel", cmbLevel.Text.ToString());
                cmd.Parameters.AddWithValue("@Rank", txtGenRank.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Employee is saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ReasetFormControls();
            }
        }
        private bool IsValid()
        {
            if (txtboxEmpID.Text == String.Empty)
            {
                MessageBox.Show("Employee ID is required...!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            EID = 0;
            txtboxEmpID.Clear();
            txtEmpName.Clear();
            cmbFaculty.ResetText();
            cmbDepartment.ResetText();
            cmbCenter.ResetText();
            cmbBuilding.ResetText();
            cmbLevel.ResetText();
            txtGenRank.Clear();

            txtboxEmpID.Focus();
        }

        private void GrdEmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE ManageEmployeeN SET EmployeeID=@EmployeeID, EmployeeName = @EmployeeName, Faculty = @Faculty, Department = @Department, Center = @Center, Building = @Building, EmpLevel = @EmpLevel, Rank = @Rank WHERE EID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EmployeeID", txtboxEmpID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@Faculty", cmbFaculty.Text.ToString());
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text.ToString());
                cmd.Parameters.AddWithValue("@Center", cmbCenter.Text.ToString());
                cmd.Parameters.AddWithValue("@Building", cmbBuilding.Text.ToString());
                cmd.Parameters.AddWithValue("@EmpLevel", cmbLevel.Text.ToString());
                cmd.Parameters.AddWithValue("@Rank", txtGenRank.Text);
                cmd.Parameters.AddWithValue("@ID", this.EID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee information updated successfully...!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ReasetFormControls();
            }
            else
            {

                MessageBox.Show("Please select an employee to update his information...!", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EID > 0)
            {

                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM ManageEmployeeN WHERE EID = @ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.EID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee information deleted successfully...!", "Deleted");

                    GetEmployeeRecord();
                    ReasetFormControls();
                }

            }
            else
            {

                MessageBox.Show("Please select an employee to delete his information...!", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /*SqlCommand cmd = new SqlCommand("Select * from ManageEmployeeN WHERE EmployeeName='" + txtboxSearch.Text + "' ", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            GrdEmployeeData.DataSource = dt;*/
        }

        private void btnGen_Click(object sender, EventArgs e)
        {

            string level = cmbLevel.Text;
            string empid = txtboxEmpID.Text;
            string rank = level + "." + empid;

            txtGenRank.Text = rank;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //    this.Hide();
           // Assign_Active_Hours back = new Assign_Active_Hours();
            //back.Show();
        }

        private void cmbLevel_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            ///Get the Value from Text Box
            string keyword = txtboxSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ManageEmployeeN WHERE EmployeeID LIKE '%" + keyword + "%' OR EmployeeName LIKE '%" + keyword + "%' OR Faculty LIKE '%" + keyword + "%' OR Department LIKE '%" + keyword + "%' OR Center LIKE '%" + keyword + "%'  OR Building LIKE '%" + keyword + "%' OR EmpLevel LIKE '%" + keyword + "%' OR Rank LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GrdEmployeeData.DataSource = dt;
        }

        private void txtGenRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrdEmployeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EID = Convert.ToInt32(GrdEmployeeData.SelectedRows[0].Cells[0].Value);
            txtboxEmpID.Text = GrdEmployeeData.SelectedRows[0].Cells[1].Value.ToString();
            txtEmpName.Text = GrdEmployeeData.SelectedRows[0].Cells[2].Value.ToString();
            cmbFaculty.Text = GrdEmployeeData.SelectedRows[0].Cells[3].Value.ToString();
            cmbDepartment.Text = GrdEmployeeData.SelectedRows[0].Cells[4].Value.ToString();
            cmbCenter.Text = GrdEmployeeData.SelectedRows[0].Cells[5].Value.ToString();
            cmbBuilding.Text = GrdEmployeeData.SelectedRows[0].Cells[6].Value.ToString();
            cmbLevel.Text = GrdEmployeeData.SelectedRows[0].Cells[7].Value.ToString();
            txtGenRank.Text = GrdEmployeeData.SelectedRows[0].Cells[8].Value.ToString();
        }
    }
}
