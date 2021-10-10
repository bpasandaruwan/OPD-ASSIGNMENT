namespace OPD_ASSIGNMENT
{
    partial class Patient_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_Patient = new System.Windows.Forms.Button();
            this.BTN_Appointment = new System.Windows.Forms.Button();
            this.BTN_Complaint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-188, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 109);
            this.panel2.TabIndex = 8;
            // 
            // BTN_Patient
            // 
            this.BTN_Patient.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_Patient.FlatAppearance.BorderSize = 0;
            this.BTN_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Patient.ForeColor = System.Drawing.Color.White;
            this.BTN_Patient.Location = new System.Drawing.Point(25, 195);
            this.BTN_Patient.Name = "BTN_Patient";
            this.BTN_Patient.Size = new System.Drawing.Size(170, 43);
            this.BTN_Patient.TabIndex = 9;
            this.BTN_Patient.Text = "PROFILE";
            this.BTN_Patient.UseVisualStyleBackColor = false;
            this.BTN_Patient.Click += new System.EventHandler(this.BTN_Patient_Click);
            // 
            // BTN_Appointment
            // 
            this.BTN_Appointment.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_Appointment.FlatAppearance.BorderSize = 0;
            this.BTN_Appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Appointment.ForeColor = System.Drawing.Color.White;
            this.BTN_Appointment.Location = new System.Drawing.Point(260, 195);
            this.BTN_Appointment.Name = "BTN_Appointment";
            this.BTN_Appointment.Size = new System.Drawing.Size(181, 43);
            this.BTN_Appointment.TabIndex = 10;
            this.BTN_Appointment.Text = "APPOINTMENT";
            this.BTN_Appointment.UseVisualStyleBackColor = false;
            this.BTN_Appointment.Click += new System.EventHandler(this.BTN_Appointment_Click);
            // 
            // BTN_Complaint
            // 
            this.BTN_Complaint.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_Complaint.FlatAppearance.BorderSize = 0;
            this.BTN_Complaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Complaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Complaint.ForeColor = System.Drawing.Color.White;
            this.BTN_Complaint.Location = new System.Drawing.Point(514, 195);
            this.BTN_Complaint.Name = "BTN_Complaint";
            this.BTN_Complaint.Size = new System.Drawing.Size(181, 43);
            this.BTN_Complaint.TabIndex = 11;
            this.BTN_Complaint.Text = "COMPLAINT";
            this.BTN_Complaint.UseVisualStyleBackColor = false;
            this.BTN_Complaint.Click += new System.EventHandler(this.BTN_Complaint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.BTN_Complaint);
            this.groupBox1.Controls.Add(this.BTN_Patient);
            this.groupBox1.Controls.Add(this.BTN_Appointment);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 256);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OPD_ASSIGNMENT.Properties.Resources.complaint;
            this.pictureBox5.Location = new System.Drawing.Point(514, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 156);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OPD_ASSIGNMENT.Properties.Resources.appoint;
            this.pictureBox4.Location = new System.Drawing.Point(260, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 155);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OPD_ASSIGNMENT.Properties.Resources.patient;
            this.pictureBox3.Location = new System.Drawing.Point(25, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::OPD_ASSIGNMENT.Properties.Resources.hospital_w_01;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::OPD_ASSIGNMENT.Properties.Resources.hospital_w_01;
            this.pictureBox1.Location = new System.Drawing.Point(21, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Patient_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Patient_Dashboard";
            this.Text = "Patient_Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTN_Patient;
        private System.Windows.Forms.Button BTN_Appointment;
        private System.Windows.Forms.Button BTN_Complaint;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}