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
    public partial class Patient_Edit : Form
    {
        public Patient_Edit()
        {
            InitializeComponent();

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM patient WHERE patient_Id = @Patient_Id", con))
                {


                    try
                    {

                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd.Parameters.AddWithValue("@Patient_Id", Edit_Patient_Id);
                        DataTable dtUser = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        dtUser.Load(sdr);

                        DataRow row = dtUser.Rows[0];

                        txtfname.Text = row["full_name"].ToString();
                        txtaddress.Text = row["address"].ToString();
                        txtNic.Text = row["nic"].ToString();
                        txtphno.Text = row["phone"].ToString();
                        txtpurpose.Text = row["purpose"].ToString();
                        txtallergies.Text = row["allergies"].ToString();
                        txtNote.Text = row["note"].ToString();
                        comBlood.SelectedValue = row["blood_group"].ToString();
                        txtuname.Text = row["username"].ToString();
                        txtpassword.Text = row["password"].ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
        public int Edit_Patient_Id { get; set; }


        private void Patient_Edit_Load(object sender, EventArgs e)
        {
           
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE patient SET 
                                                                                full_name  = @full_name,
                                                                                address    =@address,
                                                                                nic         =@nic,
                                                                                phone       =@phone,
                                                                                purpose     =@purpose,
                                                                                allergies   =@allergies,
                                                                                note        =@note,
                                                                                blood_group =@blood_group
                                                                                username    =@username, 
                                                                                password     =@password
                                                                                WHERE patient_Id =@Patient_Id)", con))


                    {
                        cmd.Parameters.AddWithValue("@Patient_Id", this.Edit_Patient_Id);
                        cmd.Parameters.AddWithValue("@full_name", txtfname.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtaddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtphno.Text.Trim());
                        cmd.Parameters.AddWithValue("@purpose", txtpurpose.Text.Trim());
                        cmd.Parameters.AddWithValue("@allergies", txtallergies.Text.Trim());
                        cmd.Parameters.AddWithValue("@note", txtNote.Text.Trim());
                        cmd.Parameters.AddWithValue("@blood_group", comBlood.SelectedItem);
                        cmd.Parameters.AddWithValue("@username", txtuname.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());




                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        con.Close();


                    }
                }



            }
           


        }
    
        private bool IsFormValid()
        {
            if (txtfname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Full Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfname.Focus();
                return false;
            }
            if (txtNic.Text.Trim() == string.Empty)
            {
                MessageBox.Show("NIC Number is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNic.Focus();
                return false;
            }

            if (txtpurpose.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purpose is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpurpose.Focus();
                return false;
            }
            if (txtphno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Purpose is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphno.Focus();
                return false;
            }
            if (txtuname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuname.Focus();
                return false;
            }
            if (txtpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return false;
            }

            return true;


        }


    
      
 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM patient WHERE patient_Id = @patient_Id", con))
                    {

                        cmd.Parameters.AddWithValue("@patient_Id", this.Edit_Patient_Id);
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









