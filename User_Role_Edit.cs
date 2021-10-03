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
    public partial class User_Role_Edit : Form
    {
        public User_Role_Edit()
        {
            InitializeComponent();
        }

        public int RoleId { get; set; }

        private void User_Role_Edit_Load(object sender, EventArgs e)
        {
            // lbl_userrole.Text = RoleId.ToString();

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM user_roles WHERE id = @RoleId ", con))
                {
               
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    DataTable dtRole = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtRole.Load(sdr);

                    DataRow row = dtRole.Rows[0];

                    txt_userrole.Text = row["role_name"].ToString(); 
                    cob_ur_status.Text = row["status"].ToString();


 
                    con.Close();
                }
            }



        }

        private void btn_ur_update_Click(object sender, EventArgs e)
        {
            if( IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE user_roles SET role_name = @role_name, status = @status WHERE id = @id", con))
                    {
                     
                        cmd.Parameters.AddWithValue("@id", this.RoleId);
                        cmd.Parameters.AddWithValue("@role_name", txt_userrole.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cob_ur_status.SelectedItem);
                        cmd.Parameters.AddWithValue("@created_by", Login_User_Details.Logged_UserID);


                        if (con.State != ConnectionState.Open)
                        { 
                          con.Open(); 
                          cmd.ExecuteNonQuery();

                          MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          con.Close();
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

        private void btn_ur_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this role?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM user_roles WHERE id = @id", con))
                    {
                    
                        cmd.Parameters.AddWithValue("@id", this.RoleId); 
                        if (con.State != ConnectionState.Open)
                        { 
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        }
                    }
                }

            }
        }
    }
}
