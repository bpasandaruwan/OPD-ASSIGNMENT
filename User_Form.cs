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
using System.IO;

namespace OPD_ASSIGNMENT
{
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            Load_Data_In_To_User_Role_Combobox();

            Load_Data_In_To_Specialty_Area_Combobox();
        }

        private void Load_Data_In_To_Specialty_Area_Combobox()
        {
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM speciality_area WHERE status = 'Active'", con))
                {

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        DataTable dtRoles = new DataTable();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dtRoles.Load(sdr);
                        cob_u_specialy_area.DataSource = dtRoles;
                        cob_u_specialy_area.DisplayMember = "area_type";
                        cob_u_specialy_area.ValueMember = "id";
                        con.Close();
                    }

                }
            }
        }

        private void Load_Data_In_To_User_Role_Combobox()
        {
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM user_roles WHERE status = 'Active'", con))
                {
                    
                    if (con.State != ConnectionState.Open)
                    { 
                    con.Open();
                        DataTable dtRoles = new DataTable();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dtRoles.Load(sdr);
                        cob_u_userrole.DataSource = dtRoles;
                        cob_u_userrole.DisplayMember = "role_name";
                        cob_u_userrole.ValueMember = "id";
                    con.Close();
                    }

                }
            }
        }

        private void btn_ur_save_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO users (username,
                                                                                password,
                                                                                name,
                                                                                phone,
                                                                                id_card_number,
                                                                                gender,
                                                                                date_of_birth,
                                                                                address,
                                                                                marital_status,
                                                                                staff_id,
                                                                                staff_email,
                                                                                date_of_join, 
                                                                                photograph,
                                                                                specialty_area,
                                                                                role_id, 
                                                                                created_by,
                                                                                created_date)
                                                                             VALUES
                                                                                   (@username,
                                                                                   @password,
                                                                                   @name,
                                                                                   @phone,
                                                                                   @id_card,
                                                                                   @gender,
                                                                                   @date_of_birth,
                                                                                   @address,
                                                                                   @marital_status,
                                                                                   @staff_id,
                                                                                   @email,
                                                                                   @date_of_join, 
                                                                                   @images,
                                                                                   @specialy_area,
                                                                                   @role_id, 
                                                                                   @created_by,
                                                                                   @created_date)", con))
                    {
                        cmd.Parameters.AddWithValue("@name", txt_u_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@id_card", txt_u_id_card_no.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txt_u_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txt_u_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@staff_id", txt_u_staff_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_of_birth", dtp_dfb.Value.ToString());
                        cmd.Parameters.AddWithValue("@date_of_join", dtp_dfjoin.Value.ToString());
                        cmd.Parameters.AddWithValue("@gender", cob_u_gender.SelectedItem);
                        cmd.Parameters.AddWithValue("@marital_status", cob_u_marital_status.SelectedItem); 
                        cmd.Parameters.AddWithValue("@username", txt_u_username.Text.Trim()); 
                        cmd.Parameters.AddWithValue("@password", txt_u_password.Text.Trim()); 
                        cmd.Parameters.AddWithValue("@role_id", cob_u_userrole.SelectedValue);
                        cmd.Parameters.AddWithValue("@specialy_area", cob_u_specialy_area.SelectedValue);
                        cmd.Parameters.AddWithValue("@address", txt_u_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@created_by", Login_User_Details.Logged_UserID);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.Now);


                        byte[] images = null;
                        FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Stream);
                        images = brs.ReadBytes((int)Stream.Length);

                        cmd.Parameters.AddWithValue("@images", images);




                        if (con.State != ConnectionState.Open)
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                     

                    }
                }

            }
        }

        private bool IsFormValid()
        {

            if (txt_u_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_name.Focus();
                return false;
            }

            if (txt_u_id_card_no.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_id_card_no.Focus();
                return false;
            }

            if ((txt_u_id_card_no.Text.Length) != 10 && (txt_u_id_card_no.Text.Length) != 12)
            {
               
                MessageBox.Show("Invalid NIC", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_id_card_no.Focus();
                return false;
            }

            if (txt_u_phone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_phone.Focus();
                return false;
            }

            if (txt_u_email.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_email.Focus();
                return false;
            }
            
            if (txt_u_staff_id.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_staff_id.Focus();
                return false;
            }
            
            if (cob_u_gender.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cob_u_gender.Focus();
                return false;
            }
            
            if (cob_u_marital_status.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cob_u_marital_status.Focus();
                return false;
            }


            if (txt_u_username.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_username.Focus();
                return false;
            }
            
            if (txt_u_password.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_u_password.Focus();
                return false;
            } 
            
            if (cob_u_userrole.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cob_u_userrole.Focus();
                return false;
            }


            return true;
        }

        private void txt_u_id_card_no_TextChanged(object sender, EventArgs e)
        {
            txt_u_password.Text = txt_u_id_card_no.Text.Trim();
        }

        string imgLocation = "";
        private void btn_img_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pb_user_image.ImageLocation = imgLocation;
            }
        }
    }
}
