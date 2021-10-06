using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OPD_ASSIGNMENT.General;
using System.IO;

namespace OPD_ASSIGNMENT
{
    public partial class Patient : Form
    {
      //  SqlConnection con = new SqlConnection(@"Data Source=LENOVOPC;Initial Catalog=opd_system;Integrated Security=True");
      //  SqlCommand cmd;
        public Patient()
        {
            InitializeComponent();
        }
        public int PatientId { get; set; }

        private void label4_Click(object sender, EventArgs e)
        {

        }

 

       

       
            

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {


                using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
                {

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO patient (added_by, full_name, address, nic, phone, purpose, allergies, note, attached_doument, blood_group, date) VALUES (@added_by, @full_name, @address, @nic, @phone, @purpose, @allergies, @note, @attached_document, @blood_group, @date)", con))
                    {

                        cmd.Parameters.AddWithValue("@added_by", 5);
                        cmd.Parameters.AddWithValue("@full_name", txtfname.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtaddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic", txtNic.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtphno.Text.Trim());
                        cmd.Parameters.AddWithValue("@purpose", txtpurpose.Text.Trim());
                        cmd.Parameters.AddWithValue("@allergies", txtallergies.Text.Trim());
                        cmd.Parameters.AddWithValue("@note", txtNote.Text.Trim());
                     
                        cmd.Parameters.AddWithValue("@blood_group", comBlood.SelectedItem);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

 

                        FileStream fistream = File.OpenRead(docLocation);
                        byte[] contents = new byte[fistream.Length];
                        fistream.Read(contents, 0, (int)fistream.Length);
                       
                        cmd.Parameters.AddWithValue("@attached_document", contents);

                  




                        try
                        {

                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtfname.Clear();
                                txtaddress.Focus();


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
            if (txtfname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Full Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfname.Focus();
                return false;
            }
            if (txtNic.Text.Trim() == string.Empty)
            {
                MessageBox.Show("NIC Number is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfname.Focus();
                return false;
            }


            return true;
        }

        string docLocation = "";

        private void AttachDocBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to upload this PDF File?", "OPD System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        //string flename = dlg.FileName;
                        docLocation = dlg.FileName.ToString();
                        // uploadFile(flename);


                    }




                }
            }

        
        }
        public void uploadFile(string file)
        {
            using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
            {


                con.Open();
                FileStream fistream = File.OpenRead(file);
                byte[] contents = new byte[fistream.Length];
                fistream.Read(contents, 0, (int)fistream.Length);
                fistream.Close();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO patient(attached_document)VALUES(@attached_document)", con))
                {
                    cmd.Parameters.AddWithValue("@attached_document", contents);

                }
                MessageBox.Show("");


            }
                

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            //Patient_Role_Grid_Load();
        }
        //private void Patient_Role_Grid_Load()
        //{
        //    using (SqlConnection con = new SqlConnection(App_Connection.GetConnectionString()))
        //    {

        //        using (SqlCommand cmd = new SqlCommand("SELECT pid AS patient_Id, addedby AS added_by, fname AS full_name, ad AS address,nicno as nic,phno as phone,pur as purpose,allergy as allergies,nt as note,attachdoc as attached_document,bldgroup as blood_group, dt as date FROM patient  ORDER BY id DESC", con))
        //        {
        //            try
        //            {


        //                if (con.State != ConnectionState.Open)
        //                {
        //                    con.Open();
        //                    SqlDataReader reader = cmd.ExecuteReader();
        //                    DataTable dt = new DataTable();
        //                    dt.Load(reader);
        //                    PatientGrid.DataSource = dt;
        //                    con.Close();

        //                }




        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }


        //        }

        //    }
        //}
        
    }
    
}
