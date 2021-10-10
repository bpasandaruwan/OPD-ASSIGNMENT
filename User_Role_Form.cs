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
    public partial class User_Role_Form : Form
    {
        public User_Role_Form()
        {
            InitializeComponent();
        }

        private void btn_ur_save_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {


                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO user_roles (role_name, created_by, created_date) VALUES (@UserRole, @created_by, @created_date)", con))
                    {

                        cmd.Parameters.AddWithValue("@UserRole", txt_userrole.Text.Trim());
                        cmd.Parameters.AddWithValue("@created_by", Login_User_Details.Logged_UserID);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.Now);

                        try
                        {


                            if (con.State != ConnectionState.Open)
                            { 
                                con.Open(); 
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txt_userrole.Clear(); 
                                txt_userrole.Focus();
                                User_Role_Grid_Load();

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
            if (txt_userrole.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userrole.Focus();
                return false;
            }
             
            return true;
        }

        private void User_Role_Form_Load(object sender, EventArgs e)
        {
            User_Role_Grid_Load();
        }

        private void User_Role_Grid_Load()
        {

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand("SELECT id AS ID, role_name AS ROLE, status AS STATUS, created_date AS DATE FROM user_roles  ORDER BY id DESC", con))
                { 
                    try
                    {


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open(); 
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dt_user_role.DataSource = dt;
                            con.Close();
 
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

            }

        }

        private void dt_user_role_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int set_user_role_id = Convert.ToInt32(dt_user_role.SelectedRows[0].Cells[0].Value);
            //MessageBox.Show(set_user_id.ToString());

            User_Role_Edit userRoleEdit = new User_Role_Edit();
            userRoleEdit.RoleId = set_user_role_id;
            userRoleEdit.ShowDialog();
            User_Role_Grid_Load();
        }
    }
}
