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
    public partial class PopupEmployee : Form
    {
        public PopupEmployee()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageEmployee emp = new ManageEmployee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AssignActiveHourse hrs = new AssignActiveHourse();
            hrs.Show();
            this.Hide();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PrefferedTimeManage pr = new PrefferedTimeManage();
            pr.Show();
            this.Hide();
        }
    }
}
