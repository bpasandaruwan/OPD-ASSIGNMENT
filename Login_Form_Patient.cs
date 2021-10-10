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
    public partial class Login_Form_Patient : Template_Form
    {
        public Login_Form_Patient()
        {
            InitializeComponent();
        }

        private void Btn_l_login_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM patient WHERE username=@UserName AND password =@Password", con))
                    {

                        cmd.Parameters.AddWithValue("@UserName", txt_l_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_l_password.Text.Trim());

                        try
                        {


                            if (con.State != ConnectionState.Open)
                            {


                                con.Open();

                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                int i = cmd.ExecuteNonQuery();
                                if (dt.Rows.Count > 0)
                                {
                                    DataRow dataRow = dt.Rows[0];

                                    Login_User_Details.Logged_PatientID = Convert.ToInt32(dataRow["patient_id"]);
                                    Login_User_Details.Logged_Patient_Name = dataRow["username"].ToString();

                                    this.Hide();
                                    Patient_Dashboard SD = new Patient_Dashboard();
                                    SD.ShowDialog();

                                    //MessageBox.Show(dataRow["username"].ToString());

                                }
                                else
                                {
                                    MessageBox.Show("Username or Password is Incorrect", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }

                }

            }

        }


        private bool IsFormValid()
        {
            if (txt_l_username.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_l_username.Focus();
                return false;
            }

            if (txt_l_password.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_l_password.Focus();
                return false;
            }

            return true;
        }

    }
}
    