using System;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            PopupEmployee me = new PopupEmployee();
            me.Show();
            //this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            ManageSubject lo = new ManageSubject();
            lo.Show();
            this.Hide();
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            ManageTags lo = new ManageTags();
            lo.Show();
            this.Hide();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Add_Student lo = new Add_Student();
            lo.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Form1 lo = new Form1();
            lo.Show();
            //this.Hide();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            PopupLocation me = new PopupLocation();
            me.Show();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            PopupSessionM lo = new PopupSessionM();
            lo.Show();
            //this.Hide();
        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {
            TimeTableGenerate tb = new TimeTableGenerate();
            tb.Show();
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DashBoard1 me = new DashBoard1();
            me.Show();
            //this.Hide();
        }
    }
}
