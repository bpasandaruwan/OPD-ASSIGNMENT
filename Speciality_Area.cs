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
using System.Configuration;


namespace OPD_ASSIGNMENT
{
    public partial class Speciality_Area : Form
    {
        public Speciality_Area()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {

                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO speciality_area (area_type, created_by, created_date) VALUES (@txt_area_type, @created_by, @created_date)", con))
                    {

                        cmd.Parameters.AddWithValue("@txt_area_type", txt_area_type.Text.Trim());
                        cmd.Parameters.AddWithValue("@created_by", Login_User_Details.Logged_UserID);
                        cmd.Parameters.AddWithValue("@created_date", DateTime.Now);

                        try
                        {


                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txt_area_type.Clear();
                                txt_area_type.Focus();
                                gridbind();
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


            if (txt_area_type.Text.Trim() == string.Empty)
            {
                MessageBox.Show("This field is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_area_type.Focus();
                return false;
            }

            return true;


        }

        private void Speciality_Area_Load(object sender, EventArgs e)
        {
            gridbind();

        }
        private void gridbind()
        {
            string connstring = ConfigurationManager.ConnectionStrings["ums"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from speciality_area", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int set_area_type = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //MessageBox.Show(set_user_id.ToString());

            SPECIALITY_AREA_EDIT SpecialityareaEdit = new Speciality_Area_Edit();
            SpecialityareaEdit.AreaId = set_area_type;
            SpecialityareaEdit.ShowDialog();
            
        }

      
    }
}

        
    

