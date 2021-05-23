using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTableManagementSystemNew
{
    public partial class CosecutiveTime : UserControl
    {
        public CosecutiveTime()
        {
            InitializeComponent();
        }

        private void CosecutiveTime_Load(object sender, EventArgs e)
        {
            GetConsecutiveRecord();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2T13G7F\SQLEXPRESS;Initial Catalog=TimeTable;Integrated Security=True");

        private void GetConsecutiveRecord()
        {
            
        }
    }
}
