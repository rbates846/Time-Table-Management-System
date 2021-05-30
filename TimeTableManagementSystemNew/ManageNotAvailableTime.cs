using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class ManageNotAvailableTime : Form
    {
        public ManageNotAvailableTime()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ManageNotAvailableTime_Load(object sender, EventArgs e)
        {
            notAvailableTime1.Hide();
            parallel_Session1.Hide();
            not_Overlapping_Session1.Hide();
            consecutive_Session1.Show();
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            notAvailableTime1.Show();
            consecutive_Session1.Hide();
            not_Overlapping_Session1.Hide();
            parallel_Session1.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            consecutive_Session1.Show();
            notAvailableTime1.Hide();
            not_Overlapping_Session1.Hide();
            parallel_Session1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parallel_Session1.Show();
            notAvailableTime1.Hide();
            not_Overlapping_Session1.Hide();
            consecutive_Session1.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            not_Overlapping_Session1.Show();
            consecutive_Session1.Hide();
            notAvailableTime1.Hide();
            parallel_Session1.Hide();
        }

        private void nor_Overlapping1_Load(object sender, EventArgs e)
        {

        }

        private void notAvailableTime1_Load(object sender, EventArgs e)
        {

        }



        private void cosecutiveTime1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }
    }
}
