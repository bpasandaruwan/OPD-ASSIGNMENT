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
    public partial class Login_Form_Staff : Form
    {
        public Login_Form_Staff()
        {
            InitializeComponent();
        }

       

        private void Btn_l_login_Click(object sender, EventArgs e)
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
