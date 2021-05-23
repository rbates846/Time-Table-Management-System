using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemNew
{
    public partial class Lecturer : UserControl
    {
        SqlConnection con;

        public Lecturer()
        {
            InitializeComponent();
          
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            createLecTable();
        }


        private DataTable createLecTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TimeSlots");
            dt.Columns.Add("Sunday");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("WednesDay");
            dt.Columns.Add("ThursDay");
            dt.Columns.Add("Friday");
            dt.Columns.Add("Satday");

            DataRow dr = dt.NewRow();
            dr["TimeSlots"] = "8.30-9.30";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["TimeSlots"] = "9.30-10.30";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["TimeSlots"] = "10.30-11.30";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["TimeSlots"] = "11.30-12.30";
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["TimeSlots"] = "12.30-1.30";
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["TimeSlots"] = "1.30-2.30";
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["TimeSlots"] = "2.30-3.30";
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["TimeSlots"] = "3.30-4.30";
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["TimeSlots"] = "4.30-5.30";
            dt.Rows.Add(dr8);

            return dt;
        }
    }
}
