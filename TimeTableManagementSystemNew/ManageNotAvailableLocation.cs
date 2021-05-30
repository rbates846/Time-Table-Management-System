using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class ManageNotAvailableLocation : Form
    {
        public ManageNotAvailableLocation()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeSlotGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSessionLocation2.Show();
            notAvailableLocation1.Hide();
            add_Consecutive_Session_Location1.Hide();
        }

        private void ManageNotAvailableLocation_Load(object sender, EventArgs e)
        {
            notAvailableLocation1.Hide();
            add_Consecutive_Session_Location1.Hide();
            addSessionLocation2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            notAvailableLocation1.Show();
            addSessionLocation2.Hide();
            add_Consecutive_Session_Location1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void notAvailableLocation1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSessionLocation1_Load(object sender, EventArgs e)
        {

        }

        private void addConsecutiveSessionLocation1_Load(object sender, EventArgs e)
        {

        }

        private void notAvailableLocation1_Load_1(object sender, EventArgs e)
        {
    
            addSessionLocation2.Show();
            notAvailableLocation1.Hide();
        }

        private void manageSessionLocation1_Load(object sender, EventArgs e)
        {

            addSessionLocation2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            notAvailableLocation1.Hide();
            addSessionLocation2.Hide();
            add_Consecutive_Session_Location1.Show();
        }

        private void add_Consecutive_Session_Location1_Load(object sender, EventArgs e)
        {
      
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SessionDBForm frm = new SessionDBForm();
            frm.Show();
            this.Close();
        }
    }
}
