using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class TimeTableGenerate : Form
    {
        public TimeTableGenerate()
        {
            InitializeComponent();
        }

        private void location1_Load(object sender, EventArgs e)
        {

        }

        private void TimeTableGenerate_Load(object sender, EventArgs e)
        {
            location1.Hide();
            student1.Hide();
            lecturer1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lecturer1.Show();
            student1.Hide();
            location1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student1.Show();
            lecturer1.Hide();
            location1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            location1.Show();
            lecturer1.Hide();
            student1.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
