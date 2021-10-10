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
    public partial class SPECIALITY_AREA_EDIT : Form
    {
      

        public SPECIALITY_AREA_EDIT()
        {
            InitializeComponent();
        }

        public int AreaId { get; set; }

        private void SPECIALITY_AREA_EDIT_Load(object sender, EventArgs e)

        {
            // lbl_area_type.Text = AreaId.ToString();

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM speciality_area WHERE id = @AreaId ", con))
                {

                    cmd.Parameters.AddWithValue("@area_type", AreaId);

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    DataTable dtRole = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtRole.Load(sdr);

                    DataRow row = dtRole.Rows[0];

                    txt_area_type.Text = row["area_type"].ToString();
                    cob_status.Text = row["status"].ToString();



                    con.Close();
                }
            }



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE speciality_area SET area_type = @area_type,status = @status WHERE id = @id", con))
                    {
                        {
                            cmd.Parameters.AddWithValue("@id", this.AreaId);
                            cmd.Parameters.AddWithValue("@area_type", txt_area_type.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", cob_status.SelectedItem);
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

        

    
    }

 

            private bool IsFormValid()
        {
            if (txt_area_type.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_area_type.Focus();
                return false;
            }

            return true;
        }


        private void btn_delete_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure you want to delete this role?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM speciality_area WHERE area_type= @area_type", con))
                {

                    cmd.Parameters.AddWithValue("@id", this.AreaId);
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
