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
    public partial class AssignActiveHourse : Form
    {
        public AssignActiveHourse()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");

        public int ID;
        SqlCommand cmd;

        private void WeekPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignActiveHourse_Load(object sender, EventArgs e)
        {
            cmbEmpName.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT EmployeeName FROM ManageEmployeeN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                cmbEmpName.Items.Add(dr["EmployeeName"].ToString());
            }
            con.Close();

            GetAssignActiveHrsRecord();
        }

        private void GetAssignActiveHrsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from AssignActiveHrs", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            GrdActiveHrs.DataSource = dt;
        }

        private void cmbEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM ManageEmployeeN WHERE EmployeeName='" + cmbEmpName.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                String rank = (string)dr["Rank"].ToString();
                textRank.Text = rank;
            }

            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO AssignActiveHrs VALUES(@EmployeeName_A, @Rank_A, @Num_Days, @Working_Days, @Active_Hrs, @Active_mins)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@EmployeeName_A", cmbEmpName.Text.ToString());
                cmd.Parameters.AddWithValue("@Rank_A", textRank.Text);
                cmd.Parameters.AddWithValue("@Num_Days", numDays.Value);

                string s = string.Empty;
                foreach (object li in WeekPanel.CheckedItems)
                {
                    s += li + ",";
                }
                cmd.Parameters.AddWithValue("@Working_Days", s);

                cmd.Parameters.AddWithValue("@Active_Hrs", numHrs.Value);
                cmd.Parameters.AddWithValue("@Active_mins", numMin.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New record is saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < WeekPanel.Items.Count; i++)
                {

                    WeekPanel.SetItemChecked(i, false);
                }

                GetAssignActiveHrsRecord();
                ResetAssignActiveHrsFormContrils();
            }
        }
        private bool IsValid()
        {
            if (cmbEmpName.Text == String.Empty)
            {
                MessageBox.Show("Employee name is required...!", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ID = 0;
            ResetAssignActiveHrsFormContrils();

            cmbEmpName.Focus();
        }

        private void ResetAssignActiveHrsFormContrils()
        {
            ID = 0;

            cmbEmpName.ResetText();
            textRank.Clear();
            numDays.Value = 0;
            // WeekPanel.ClearSelected();
            numHrs.Value = 0;
            numMin.Value = 0;

            for (int i = 0; i < WeekPanel.Items.Count; i++)
            {

                WeekPanel.SetItemChecked(i, false);

            }

            cmbEmpName.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (ID > 0)
            {

                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM AssignActiveHrs WHERE ID = @ID", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@ID", this.ID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee information deleted successfully...!", "Deleted");

                    GetAssignActiveHrsRecord();
                    ResetAssignActiveHrsFormContrils();
                }

            }
            else
            {

                MessageBox.Show("Please select a row to delete his information...!", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE AssignActiveHrs SET EmployeeName_A=@EmployeeName_A, Rank_A = @Rank_A, Num_Days = @Num_Days, Working_Days = @Working_Days, Active_Hrs = @Active_Hrs, Active_mins = @Active_mins WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@EmployeeName_A", cmbEmpName.Text.ToString());
                cmd.Parameters.AddWithValue("@Rank_A", textRank.Text);
                cmd.Parameters.AddWithValue("@Num_Days", numDays.Value);

                string s = string.Empty;
                foreach (object li in WeekPanel.CheckedItems)
                {
                    s += li + "-";
                }
                cmd.Parameters.AddWithValue("@Working_Days", s);

                cmd.Parameters.AddWithValue("@Active_Hrs", numHrs.Value);
                cmd.Parameters.AddWithValue("@Active_mins", numMin.Value);

                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated successfully...!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                GetAssignActiveHrsRecord();
                ResetAssignActiveHrsFormContrils();

                for (int i = 0; i < WeekPanel.Items.Count; i++)
                {

                    WeekPanel.SetItemChecked(i, false);

                }


            }
            else
            {
                MessageBox.Show("UnSuccessfull", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void GrdActiveHrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void getAllDetails()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM AssignActiveHrs WHERE ID ='" + this.ID + "'", con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {

                string days = dataTable.Rows[0]["Working_Days"].ToString();

                string[] dayss = days.Split(',');
                foreach (string d in dayss)
                {
                    foreach (Object l in WeekPanel.Items)
                    {

                        if (d.Equals(l.ToString()))
                        {
                            // MessageBox.Show(l.ToString());
                            switch (l.ToString())
                            {
                                case "Monday":
                                    WeekPanel.SetItemChecked(0, true);
                                    break;
                                case "Tuesday":
                                    WeekPanel.SetItemChecked(1, true);
                                    break;
                                case "Wednesday":
                                    WeekPanel.SetItemChecked(2, true);
                                    break;
                                case "Thursday":
                                    WeekPanel.SetItemChecked(3, true);
                                    break;
                                case "Friday":
                                    WeekPanel.SetItemChecked(4, true);
                                    break;
                                case "Saturday":
                                    WeekPanel.SetItemChecked(5, true);
                                    break;
                                case "Sunday":
                                    WeekPanel.SetItemChecked(6, true);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }
                    }

                }


            }
            con.Close();

        }

        private void GrdActiveHrs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(GrdActiveHrs.SelectedRows[0].Cells[0].Value);
            cmbEmpName.Text = GrdActiveHrs.SelectedRows[0].Cells[1].Value.ToString();
            textRank.Text = GrdActiveHrs.SelectedRows[0].Cells[2].Value.ToString();
            numDays.Text = GrdActiveHrs.SelectedRows[0].Cells[3].Value.ToString();
            getAllDetails();

            numHrs.Text = GrdActiveHrs.SelectedRows[0].Cells[5].Value.ToString();
            numMin.Text = GrdActiveHrs.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            ///Get the Value from Text Box
            string keyword = txtboxSearch.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM AssignActiveHrs WHERE EmployeeName_A LIKE '%" + keyword + "%' OR Rank_A LIKE '%" + keyword + "%' OR Num_Days LIKE '%" + keyword + "%' OR Working_Days LIKE '%" + keyword + "%' OR Working_Days LIKE '%" + keyword + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GrdActiveHrs.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void AssID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
