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
    public partial class PopupLocation : Form
    {
        public PopupLocation()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddLocatio ad = new AddLocatio();
            ad.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageNotAvailableLocation ml = new ManageNotAvailableLocation();
            ml.Show();
        }
    }
}
