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
    public partial class Patient_Dashboard : Form
    {
        public Patient_Dashboard()
        {
            InitializeComponent();
        }

        private void BTN_Appointment_Click(object sender, EventArgs e)
        {
            Appointment_From UF = new Appointment_From();
            UF.ShowDialog();
        }

        private void BTN_Complaint_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Patient_Click(object sender, EventArgs e)
        {
            Patient_Edit UF = new Patient_Edit();
            UF.ShowDialog();
        }
    }
}
