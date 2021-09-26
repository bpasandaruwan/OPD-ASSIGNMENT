using OPD_ASSIGNMENT.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPD_ASSIGNMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MessageBox.Show("Connection Ok");
            }
        }
    }
}
