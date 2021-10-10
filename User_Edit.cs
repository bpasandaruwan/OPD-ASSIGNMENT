using OPD_ASSIGNMENT.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPD_ASSIGNMENT
{
    public partial class User_Edit : Form
    {
        public User_Edit()
        {
            InitializeComponent();
        }
        public int Edit_User_ID { get; set; }
        private void User_Edit_Load(object sender, EventArgs e)
        {


            Load_Data_In_To_User_Role_Combobox();

            Load_Data_In_To_Specialty_Area_Combobox();


            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM users WHERE id = @UserId", con))
                {
                      
                    cmd.Parameters.AddWithValue("@UserId", Edit_User_ID);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    DataTable dtUser = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtUser.Load(sdr);

                    DataRow row = dtUser.Rows[0];

                    txt_u_name.Text = row["name"].ToString();
                    txt_u_id_card_no.Text = row["id_card_number"].ToString();
                    txt_u_phone.Text = row["phone"].ToString();
                    txt_u_email.Text = row["staff_email"].ToString();
                    txt_u_staff_id.Text = row["staff_id"].ToString();
                    dtp_dfb.Text = row["date_of_birth"].ToString();
                    dtp_dfjoin.Text = row["date_of_join"].ToString();


                    cob_u_gender.Text = row["gender"].ToString();
                    cob_u_marital_status.Text = row["marital_status"].ToString();
                    txt_u_username.Text = row["username"].ToString();
                    txt_u_password.Text = row["password"].ToString();
                    cob_u_userrole.SelectedValue = row["role_id"];
 
                    cob_u_specialy_area.SelectedValue = row["specialty_area"].ToString(); 
                    txt_u_address.Text = row["address"].ToString();

                    


                    if (DBNull.Value == row["photograph"])
                    {
                        
                    }else
                    {
                        pb_user_image.Image = ConvertByteArrayToImage((byte[])row["photograph"]);
                    }







                    }
            }




        }


        public Image ConvertByteArrayToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
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

        private void btn_ur_update_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {

                if (string.IsNullOrEmpty(imgLocation))
                {
                    using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"UPDATE users SET username     = @username,
                                                                                password       = @password,
                                                                                name           = @name,
                                                                                phone          = @phone,
                                                                                id_card_number = @id_card,
                                                                                gender         = @gender,
                                                                                date_of_birth  = @date_of_birth,
                                                                                address        = @address,
                                                                                marital_status = @marital_status,
                                                                                staff_id       = @staff_id,
                                                                                staff_email    = @email,
                                                                                date_of_join   = @date_of_join, 
                                                                                specialty_area = @specialy_area,
                                                                                role_id        = @role_id WHERE id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", this.Edit_User_ID);
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
 

                            if (con.State != ConnectionState.Open)
                                con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            con.Close();


                        }
                    }

                }
                else
                {

                    using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"UPDATE users SET username     = @username,
                                                                                password       = @password,
                                                                                name           = @name,
                                                                                phone          = @phone,
                                                                                id_card_number = @id_card,
                                                                                gender         = @gender,
                                                                                date_of_birth  = @date_of_birth,
                                                                                address        = @address,
                                                                                marital_status = @marital_status,
                                                                                staff_id       = @staff_id,
                                                                                staff_email    = @email,
                                                                                date_of_join   = @date_of_join, 
                                                                                photograph     = @images,
                                                                                specialty_area = @specialy_area,
                                                                                role_id        = @role_id WHERE id = @id", con))
                        {
                            cmd.Parameters.AddWithValue("@id", this.Edit_User_ID);
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


                            byte[] images = null;
                            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                            BinaryReader brs = new BinaryReader(Stream);
                            images = brs.ReadBytes((int)Stream.Length);

                            cmd.Parameters.AddWithValue("@images", images);






                            if (con.State != ConnectionState.Open)
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
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pb_user_image.ImageLocation = imgLocation;
            }
        }

        private void btn_ur_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id = @id", con))
                    {

                        cmd.Parameters.AddWithValue("@id", this.Edit_User_ID);
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
