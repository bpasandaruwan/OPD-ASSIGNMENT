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
    public partial class Patient : Form
    {
      
        public Patient()
        {
            InitializeComponent();
        }
      
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
   

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
               

                    using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                    {

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO patient (added_by, full_name, address, nic, phone, purpose, allergies, note, blood_group, date, username, password) VALUES (@added_by, @full_name, @address, @nic, @phone, @purpose, @allergies, @note, @blood_group, @date, @username, @password)", con))
                        {

                            cmd.Parameters.AddWithValue("@added_by", Login_User_Details.Logged_PatientID);
                            cmd.Parameters.AddWithValue("@full_name", txtfname.Text.Trim());
                            cmd.Parameters.AddWithValue("@address", txtaddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", txtphno.Text.Trim());
                            cmd.Parameters.AddWithValue("@purpose", txtpurpose.Text.Trim());
                            cmd.Parameters.AddWithValue("@allergies", txtallergies.Text.Trim());
                            cmd.Parameters.AddWithValue("@note", txtNote.Text.Trim());

                            cmd.Parameters.AddWithValue("@blood_group", comBlood.SelectedItem);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@username", txtuname.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());









                        if (con.State != ConnectionState.Open)

                                con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtfname.Clear();
                            txtaddress.Clear();
                            txtallergies.Clear();
                            txtNic.Clear();
                            txtNote.Clear();
                            txtphno.Clear();
                            txtpurpose.Clear();

                            txtfname.Focus();

                            Patient_Load();

                            con.Close();






                        }

                    }


            }
            else
            {
                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO patient (added_by, full_name, address, nic, phone, purpose, allergies, note, blood_group, date, username, password) VALUES (@added_by, @full_name, @address, @nic, @phone, @purpose, @allergies, @note, @blood_group, @date, @username, @password)", con))
                    {

                        cmd.Parameters.AddWithValue("@added_by", Login_User_Details.Logged_PatientID);
                        cmd.Parameters.AddWithValue("@full_name", txtfname.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtaddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtphno.Text.Trim());
                        cmd.Parameters.AddWithValue("@purpose", txtpurpose.Text.Trim());
                        cmd.Parameters.AddWithValue("@allergies", txtallergies.Text.Trim());
                        cmd.Parameters.AddWithValue("@note", txtNote.Text.Trim());

                        cmd.Parameters.AddWithValue("@blood_group", comBlood.SelectedItem);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@username", txtuname.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());



                        if (con.State != ConnectionState.Open)

                            con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtfname.Clear();
                        txtaddress.Clear();
                        txtallergies.Clear();
                        txtNic.Clear();
                        txtNote.Clear();
                        txtphno.Clear();
                        txtpurpose.Clear();

                        txtfname.Focus();

                        Patient_Load();

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

            return true;
        }

       


        private void Patient_Load(object sender, EventArgs e)
        {
            Patient_Load();
        }
        private void Patient_Load()
        { 
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {

                using (SqlCommand cmd = new SqlCommand(@"SELECT patient_Id AS ID,
                                                                username AS USERNAME,
                                                                date as DATE,
                                                                full_name AS NAME,
                                                                address AS ADDRESS,
                                                                nic as NIC,
                                                                phone as PHONE,
                                                                purpose as PURPOSE,
                                                                allergies as ALLERGY,
                                                                note as NOTE,
                                                                blood_group as BLOODGROUP 
                                                                FROM patient ORDER BY patient_Id ASC", con))
                {
                    try
                    {


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            PatientGrid.DataSource = dt;
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
       

        

        private void PatientGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int set_patient_Id = Convert.ToInt32(PatientGrid.SelectedRows[0].Cells[0].Value);
            //MessageBox.Show(set_patient_Id.ToString());



            Patient_Edit Patient_Edit = new Patient_Edit();
            Patient_Edit.Edit_Patient_Id = set_patient_Id;
            Patient_Edit.ShowDialog();
            Patient_Load();
        }
    }
    
}
