using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class DashBoard1 : Form
    {
        public DashBoard1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard1_Load(object sender, EventArgs e)
        {
            getSubject();
            getgroupID();
            getLecture();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            String query = "Select count (EID) from ManageEmployeeN";



            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                label1.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {

            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            String query = "Select count (RoomID) from tbl_Room";



            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                label4.Text = rows_count.ToString();





            }
            catch (Exception ex)
            {






            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            String query = "Select count (StudentID) from tbl_student";



            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                label2.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {

            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;
            String query = "Select count (Subject_ID) from ManageSubject ";



            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                label3.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {

            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void getLecture()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader sr = null;
            cmd.Connection = con;
            cmd.CommandText = "Select Top(1) EmployeeName from ManageEmployeeN ";
            con.Open();
            sr = cmd.ExecuteReader();
            if (sr.Read())
            {
                textBox1.Text = sr.GetValue(0).ToString();
            }

            con.Close();
        }


        public void getgroupID()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader sr = null;
            cmd.Connection = con;
            cmd.CommandText = "Select Top(1) SubGroupId from tbl_student ";
            con.Open();
            sr = cmd.ExecuteReader();
            if (sr.Read())
            {
                textBox2.Text = sr.GetValue(0).ToString();
            }

            con.Close();
        }

        public void getSubject()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader sr = null;
            cmd.Connection = con;
            cmd.CommandText = "Select Top(1) Subject_Name from ManageSubject ";
            con.Open();
            sr = cmd.ExecuteReader();
            if (sr.Read())
            {

                textBox3.Text = sr.GetValue(0).ToString();
            }

            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }
    }
}
