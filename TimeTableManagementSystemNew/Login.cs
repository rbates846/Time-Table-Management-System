using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTableManagementSystemNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TimeTable.mdf;Integrated Security=True;");
            string query = "SELECT * FROM tbl_login WHERE username = '" + usernametxt.Text.Trim()+"' and password = '" + passwordtxt.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                HomePage objhome = new HomePage();
                this.Hide();
                objhome.Show();

            }
            else
            {
                MessageBox.Show("Check the username and password");
            }

            
               
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void username_leave(object sender, EventArgs e)
        {
            if (usernametxt.Text == "")
            {
                usernametxt.Text = "Username";
                usernametxt.ForeColor = Color.DarkGray;
            }
        }

        private void username_enter(object sender, EventArgs e)
        {
            if (usernametxt.Text == "Username")
            {
                usernametxt.Text = "";
                usernametxt.ForeColor = Color.Black;
            }
        }

        private void password_leave(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passwordtxt.Text = "Password";
                passwordtxt.ForeColor = Color.DarkGray;
               
            }
        }

        private void password_enter(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "Password")
            {
                passwordtxt.Text = "";
                passwordtxt.ForeColor = Color.Black;
        
            }
        }

        private void usernametxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(usernametxt.Text))
            {
                e.Cancel = true;
                usernametxt.Focus();
                errorProvider1.SetError(usernametxt, "Please enter username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(usernametxt, null);
            }
        }
    }
}
