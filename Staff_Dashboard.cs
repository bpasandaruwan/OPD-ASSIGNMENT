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
    public partial class Staff_Dashboard : Template_Form
    {
        public Staff_Dashboard()
        {
            InitializeComponent();
        }

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
            Logged_username.Text = Login_User_Details.Logged_Username;
        }
    }
}
