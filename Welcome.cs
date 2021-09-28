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
    public partial class Welcome_Form : Template_Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {

        }

        private void Btn_wel_staff_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form_Staff lfs = new Login_Form_Staff();
            lfs.ShowDialog();
        }

        private void Btn_wel_patient_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form_Patient lfs = new Login_Form_Patient();
            lfs.ShowDialog();
        }
    }
}
