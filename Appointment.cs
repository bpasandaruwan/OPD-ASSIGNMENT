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
    public partial class Appointment_From : Form
    {
        public Appointment_From()
        {
            InitializeComponent();

 

        }
     
     
        private void Appointment_From_Load(object sender, EventArgs e)
        {

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

            appointment_Load();

        }


        private void appointment_Load()
        {
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
              string Condition;
              string sql = @"SELECT a.id AS ID, 
                                    a.appointment_number AS NUMBER,
                                    a.appointment_date AS DATE,
                                    a.appointment_time AS TIME,
                                    a.status AS STATUS,
                                    p.full_name AS PATIENT,  
                                    sa.area_type AS SPECIALTYAREA,
                                    a.medical_id AS MedicalOfficer
                                    FROM appoinment a
                                    INNER JOIN patient p ON a.patient_id = p.patient_Id
                                    INNER JOIN speciality_area sa ON a.specialty_area = sa.id 
                                    ";

                if (cob_search.Text != string.Empty)
                {
                    Condition = " WHERE a.status = @status";
                    sql += Condition; 
                }
                Condition = " ORDER BY a.id DESC";
                sql += Condition;




                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    try
                    {


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@status", cob_search.Text.Trim());
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dt_appointment.DataSource = dt;
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

        private void btn_ur_save_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO appoinment (appointment_number,
                                                                                      appointment_date,
                                                                                      appointment_time,
                                                                                      symptoms,
                                                                                      approved_date,
                                                                                      status,
                                                                                      patient_id,
                                                                                      specialty_area,
                                                                                      medical_id,
                                                                                      added_person
                                                                                      )
                                                                                 VALUES
                                                                                       (@appointment_number,
                                                                                        @appointment_date,
                                                                                        @appointment_time,
                                                                                        @symptoms,
                                                                                        @approved_date,
                                                                                        @status,
                                                                                        @patient_id,
                                                                                        @specialty_area,
                                                                                        @medical_id,
                                                                                        @added_person
                                                                                        )", con))
                    {
                        cmd.Parameters.AddWithValue("@appointment_number", txt_appo_number.Text.Trim());
                        cmd.Parameters.AddWithValue("@appointment_date", dp_appo_date.Value.ToString());
                        cmd.Parameters.AddWithValue("@appointment_time", txt_appo_time.Text.Trim());
                        cmd.Parameters.AddWithValue("@symptoms", txt_appo_symptoms.Text.Trim());
                        cmd.Parameters.AddWithValue("@approved_date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@status", "Approved");
                        cmd.Parameters.AddWithValue("@patient_id", cob_appo_patient.SelectedValue);
                        cmd.Parameters.AddWithValue("@specialty_area", cob_appo_specialy_area.SelectedValue);
                        cmd.Parameters.AddWithValue("@medical_id", cob_appo_officer.SelectedValue);
                        cmd.Parameters.AddWithValue("@added_person", Login_User_Details.Logged_UserID);


                        try
                        {

                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                txt_appo_number.Clear();
                                txt_appo_symptoms.Clear(); 
                                txt_appo_number.Focus(); 
                                appointment_Load();

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

        private void btn_u_search_Click(object sender, EventArgs e)
        {
            appointment_Load();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {
                 
                string sql = @"SELECT a.id AS ID,
                                    a.appointment_number AS NUMBER,
                                    a.appointment_date AS DATE,
                                    a.appointment_time AS TIME,
                                    a.status AS STATUS,
                                    p.full_name AS PATIENT,  
                                    sa.area_type AS SPECIALTYAREA,
                                    a.medical_id AS MedicalOfficer
                                    FROM appoinment a
                                    INNER JOIN patient p ON a.patient_id = p.patient_Id
                                    INNER JOIN speciality_area sa ON a.specialty_area = sa.id 
                                    ORDER BY a.id DESC";

     




                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    try
                    {


                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@status", cob_search.Text.Trim());
                            SqlDataReader reader = cmd.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dt_appointment.DataSource = dt;
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

        private void dt_appointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int set_appointment_id = Convert.ToInt32(dt_appointment.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(set_appointment_id.ToString());

            User_Edit User_Edit = new User_Edit();
            //User_Edit.Edit_User_ID = set_user_id;
            //User_Edit.ShowDialog();
        }
    }
}
