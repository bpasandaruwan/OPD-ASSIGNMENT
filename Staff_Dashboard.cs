using OPD_ASSIGNMENT.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPD_ASSIGNMENT
{
    public partial class Staff_Dashboard : Form
    {
        public Staff_Dashboard()
        {
            InitializeComponent();

        }
 

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void BTN_User_Role_Click(object sender, EventArgs e)
        {
            User_Role_Form URF = new User_Role_Form();
            URF.ShowDialog();
        }

        private void BTN_Users_Click(object sender, EventArgs e)
        {
            User_Form UF = new User_Form();
            UF.ShowDialog();
        }







        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    lbl_d_username.Text = Login_User_Details.Logged_Username;
        //}


    }
}
