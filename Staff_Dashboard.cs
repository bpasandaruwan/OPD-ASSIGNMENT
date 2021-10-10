using OPD_ASSIGNMENT.General;
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
 

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM user_previleges WHERE user_role_id = @User_Role_Id AND status = 'Active'", con))
                {

                    cmd.Parameters.AddWithValue("@User_Role_Id", Login_User_Details.Logged_UserRole_ID);

                    if (con.State != ConnectionState.Open)
                    { 
                        con.Open();
 
                        DataTable dt = new DataTable();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine(row["name"].ToString(), Environment.CommandLine);
                            //BTN_Options.Visible = false;
                            //MessageBox.Show(row["name"].ToString());
                            // Response.Write("some text");
                            // row["name"].ToString();
                        }
                    }

                }
            }
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

        private void BTN_Appointment_Click(object sender, EventArgs e)
        {
            Appointment_From UF = new Appointment_From();
            UF.ShowDialog();
        }

        private void BTN_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Options_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Complaint_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Patient_Click(object sender, EventArgs e)
        {

        }







        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    lbl_d_username.Text = Login_User_Details.Logged_Username;
        //}


    }
}
