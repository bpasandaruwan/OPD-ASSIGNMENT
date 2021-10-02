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

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PNL_Container.Controls.Clear();
            PNL_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BTN_Dashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard UC = new UC_Dashboard();
            addUserControl(UC);
        }

        private void BTN_users_Click(object sender, EventArgs e)
        {
            UC_Users UC = new UC_Users();
            addUserControl(UC);
        }
 

        private void BTN_Patient_Click(object sender, EventArgs e)
        {
            UC_Patient UC = new UC_Patient();
            addUserControl(UC);
        }

        private void Staff_Dashboard_Load(object sender, EventArgs e)
        {
             
            UC_Dashboard UC = new UC_Dashboard();
            addUserControl(UC);
        }

        private void BTN_Appointment_Click(object sender, EventArgs e)
        {
            UC_Appointment UC = new UC_Appointment();
            addUserControl(UC);
        }

        private void BTN_Complaint_Click(object sender, EventArgs e)
        {
            UC_Complaint UC = new UC_Complaint();
            addUserControl(UC);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //lbl_d_username.Text = Login_User_Details.Logged_Username;
        }
    }
}
