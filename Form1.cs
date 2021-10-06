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
using system Data.SqlClient;

namespace complain
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clearbutton1_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtmobile.Text = "";
            cmb_ctype.Text = "";
            cmb_cby.Text = "";
            txtdescription.Text = "";
            cmb_adby.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void openbutton1_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                //string file = OpenFileDialog.filename;

                //string[] f = file.Split('\\');
                //string[] f = f[(f.Length) - 1];
                //string dest = @"G:\opdsys\c#\uploadimg";
                //file.CopyTo(file, DesktopBounds, true);

                //string q = "insert into [data_file]values('" + fn + "','" + dest + "')";
                //ProcessCmdKey().ExecuteNonQuery();
                //MessageBox.Show("success");
            }
        }

        /private void open_FileOk(object sender, CancelEventArgs e)
        {
            DialogResult result = OpenFileDialog1.showDialog();
            if (result == DialogResult.OK)
            {
                string file = OpenFileDialog1.filename;

                string[] f = file.Split('\\');
                string[] f = f[(f.Length) - 1];
                string dest = @"G:\opdsys\c#\uploadimg";
                file.CopyTo(file, DesktopBounds, true);

                string q = "insert into [data_file]values('" + fn + "','" + dest + "')";
                ProcessCmdKey().ExecuteNonQuery();
                MessageBox.Show("success");
            }
        }

        private void submitbutton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new sqlConnection("Data Source=LAKMA\SQLEXPRESS;Initial Catalog = itest;Intergrated Security=True");
            con.open();
            sqlCommand cmd = new sqlCommand("insert into complain"id
                )values (txtid.Text,txtmobile.Text,cmb_ctype.Items,cmb_cby.Items)values('"+')
                int i = cmd.ExecuteNonquery();
            if (i != 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.close();
        }*/
    }
}