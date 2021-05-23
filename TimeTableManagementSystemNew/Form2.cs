using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TimeTableManagementSystemNew
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

            public int RoomID;
        private void Form2_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void GetStudentRecord()
        {

            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP - LV9DA74K\SQLEXPRESS; Initial Catalog = TimeTable; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select * from tbl_Room", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            checkedListBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
