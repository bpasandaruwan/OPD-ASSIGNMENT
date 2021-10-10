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
    public partial class Appointment_Edit_Form : Form
    {
        public Appointment_Edit_Form()
        {
            InitializeComponent();


           
        }
        public int Edit_appointment_ID { get; set; }
        private void Appointment_Edit_Form_Load(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM patient ORDER BY full_name ASC", con))
                {

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dtRoles = new DataTable();
                        sda.Fill(dtRoles);
                        cob_appo_patient.DisplayMember = "full_name";
                        cob_appo_patient.ValueMember = "patient_Id";
                        cob_appo_patient.DataSource = dtRoles;
                    }

                }
            }

            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM speciality_area WHERE status = 'Active'", con))
                {

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dtRoles = new DataTable();
                        sda.Fill(dtRoles);
                        cob_appo_specialy_area.DisplayMember = "area_type";
                        cob_appo_specialy_area.ValueMember = "id";
                        cob_appo_specialy_area.DataSource = dtRoles;
                    }

                }
            }


            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE role_id = 3 AND status = 'Active'", con))
                {


                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dtRoles = new DataTable();



                        sda.Fill(dtRoles);
                        cob_appo_officer.SelectedIndex = -1;
                        cob_appo_officer.DisplayMember = "name";
                        cob_appo_officer.ValueMember = "id";
                        cob_appo_officer.DataSource = dtRoles;
                        //con.Close();
                    }

                }
            }



            



            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM appoinment WHERE id = @AppointmentId", con))
                {

                

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    cmd.Parameters.AddWithValue("@AppointmentId", Edit_appointment_ID);
                    DataTable dtUser = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dtUser.Load(sdr);

                    DataRow row = dtUser.Rows[0];

                    txt_appo_number.Text = row["appointment_number"].ToString();
                    cob_appo_patient.SelectedValue = row["patient_id"]; 
                    dp_appo_date.Text = row["appointment_date"].ToString();
                    txt_appo_time.Text = row["appointment_time"].ToString();
                    cob_appo_specialy_area.SelectedValue = row["specialty_area"];
                    cob_appo_officer.SelectedValue = row["medical_id"];
                    txt_appo_symptoms.Text = row["symptoms"].ToString();
                    cobStatus.Text = row["status"].ToString();
                
 
                }

 

            }


            if (cobStatus.Text == "Approved")
            {
                btnPrint.Visible = true;
                btnPDF.Visible = true;
            }
            else
            {
                btnPrint.Visible = false;
                btnPDF.Visible = false;
            }




        }

      
    

        private void cob_appo_specialy_area_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cob_appo_specialy_area.SelectedValue.ToString() != null)
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE role_id = 3 AND status = 'Active' AND specialty_area = @specialy_area", con))
                    {


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@specialy_area", cob_appo_specialy_area.SelectedValue.ToString());
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dtRoles = new DataTable();



                            sda.Fill(dtRoles);
                            cob_appo_officer.SelectedIndex = -1;
                            cob_appo_officer.DisplayMember = "name";
                            cob_appo_officer.ValueMember = "id";
                            cob_appo_officer.DataSource = dtRoles;
                            //con.Close();
                        }

                    }
                }

            }
        }

        private void btn_ur_update_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE appoinment SET appointment_number = @appointment_number,
                                                                                      appointment_date = @appointment_date,
                                                                                      appointment_time = @appointment_time,
                                                                                      symptoms = @symptoms,
                                                                                      approved_date = @approved_date,
                                                                                      status = @status,
                                                                                      patient_id = @patient_id,
                                                                                      specialty_area = @specialty_area,
                                                                                      medical_id = @medical_id,
                                                                                      added_person = @added_person 
                                                                                WHERE id = @AppointmentId", con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentId", Edit_appointment_ID);
                        cmd.Parameters.AddWithValue("@appointment_number", txt_appo_number.Text.Trim());
                        cmd.Parameters.AddWithValue("@appointment_date", dp_appo_date.Value.ToString());
                        cmd.Parameters.AddWithValue("@appointment_time", txt_appo_time.Text.Trim());
                        cmd.Parameters.AddWithValue("@symptoms", txt_appo_symptoms.Text.Trim());
                        cmd.Parameters.AddWithValue("@approved_date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@status", cobStatus.SelectedItem);
                        cmd.Parameters.AddWithValue("@patient_id", cob_appo_patient.SelectedValue);
                        cmd.Parameters.AddWithValue("@specialty_area", cob_appo_specialy_area.SelectedValue);
                        cmd.Parameters.AddWithValue("@medical_id", cob_appo_officer.SelectedValue);
                        cmd.Parameters.AddWithValue("@added_person", Login_User_Details.Logged_UserID);


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
            if (txt_appo_number.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_appo_number.Focus();
                return false;
            }

            if (cob_appo_patient.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cob_appo_patient.Focus();
                return false;
            }

            if (cob_appo_specialy_area.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cob_appo_specialy_area.Focus();
                return false;
            }

            if (cob_appo_officer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cob_appo_officer.Focus();
                return false;
            }

            if (txt_appo_symptoms.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_appo_symptoms.Focus();
                return false;
            }

            return true;
        }

       
    }
}
