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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTN_Patient = new System.Windows.Forms.Button();
            this.BTN_Appointment = new System.Windows.Forms.Button();
            this.BTN_Complaint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 109);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::OPD_ASSIGNMENT.Properties.Resources.hospital_w_01;
            this.pictureBox2.Location = new System.Drawing.Point(21, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BTN_Patient
            // 
            this.BTN_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.BTN_Patient.FlatAppearance.BorderSize = 0;
            this.BTN_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Patient.ForeColor = System.Drawing.Color.White;
            this.BTN_Patient.Location = new System.Drawing.Point(48, 256);
            this.BTN_Patient.Name = "BTN_Patient";
            this.BTN_Patient.Size = new System.Drawing.Size(181, 47);
            this.BTN_Patient.TabIndex = 9;
            this.BTN_Patient.Text = "PROFILE";
            this.BTN_Patient.UseVisualStyleBackColor = false;
            this.BTN_Patient.Click += new System.EventHandler(this.BTN_Patient_Click);
            // 
            // BTN_Appointment
            // 
            this.BTN_Appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.BTN_Appointment.FlatAppearance.BorderSize = 0;
            this.BTN_Appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Appointment.ForeColor = System.Drawing.Color.White;
            this.BTN_Appointment.Location = new System.Drawing.Point(274, 256);
            this.BTN_Appointment.Name = "BTN_Appointment";
            this.BTN_Appointment.Size = new System.Drawing.Size(181, 47);
            this.BTN_Appointment.TabIndex = 10;
            this.BTN_Appointment.Text = "APPOINTMENT";
            this.BTN_Appointment.UseVisualStyleBackColor = false;
            this.BTN_Appointment.Click += new System.EventHandler(this.BTN_Appointment_Click);
            // 
            // BTN_Complaint
            // 
            this.BTN_Complaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.BTN_Complaint.FlatAppearance.BorderSize = 0;
            this.BTN_Complaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Complaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Complaint.ForeColor = System.Drawing.Color.White;
            this.BTN_Complaint.Location = new System.Drawing.Point(518, 256);
            this.BTN_Complaint.Name = "BTN_Complaint";
            this.BTN_Complaint.Size = new System.Drawing.Size(181, 47);
            this.BTN_Complaint.TabIndex = 11;
            this.BTN_Complaint.Text = "COMPLAINT";
            this.BTN_Complaint.UseVisualStyleBackColor = false;
            this.BTN_Complaint.Click += new System.EventHandler(this.BTN_Complaint_Click);
            // 
            // Patient_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 394);
            this.Controls.Add(this.BTN_Complaint);
            this.Controls.Add(this.BTN_Appointment);
            this.Controls.Add(this.BTN_Patient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Patient_Dashboard";
            this.Text = "Patient_Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}