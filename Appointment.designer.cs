
namespace OPD_ASSIGNMENT
{
    partial class Appointment_From
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_appo_officer = new System.Windows.Forms.ComboBox();
            this.txt_appo_time = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dp_appo_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cob_appo_patient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_appo_symptoms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cob_appo_specialy_area = new System.Windows.Forms.ComboBox();
            this.btn_ur_save = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_appo_number = new System.Windows.Forms.TextBox();
            this.dt_appointment = new System.Windows.Forms.DataGridView();
            this.btn_u_search = new System.Windows.Forms.Button();
            this.cob_search = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cob_appo_officer);
            this.groupBox1.Controls.Add(this.txt_appo_time);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dp_appo_date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cob_appo_patient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_appo_symptoms);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cob_appo_specialy_area);
            this.groupBox1.Controls.Add(this.btn_ur_save);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_appo_number);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 318);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE NEW APPOINTMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(365, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Medical Officer";
            // 
            // cob_appo_officer
            // 
            this.cob_appo_officer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_appo_officer.FormattingEnabled = true;
            this.cob_appo_officer.Location = new System.Drawing.Point(369, 219);
            this.cob_appo_officer.Name = "cob_appo_officer";
            this.cob_appo_officer.Size = new System.Drawing.Size(329, 33);
            this.cob_appo_officer.TabIndex = 6;
            // 
            // txt_appo_time
            // 
            this.txt_appo_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appo_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_appo_time.Location = new System.Drawing.Point(369, 78);
            this.txt_appo_time.Name = "txt_appo_time";
            this.txt_appo_time.ShowUpDown = true;
            this.txt_appo_time.Size = new System.Drawing.Size(325, 30);
            this.txt_appo_time.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(365, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Time";
            // 
            // dp_appo_date
            // 
            this.dp_appo_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_appo_date.CustomFormat = "dd-MM-yyyy";
            this.dp_appo_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_appo_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_appo_date.Location = new System.Drawing.Point(9, 219);
            this.dp_appo_date.Name = "dp_appo_date";
            this.dp_appo_date.Size = new System.Drawing.Size(325, 30);
            this.dp_appo_date.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(4, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Date";
            // 
            // cob_appo_patient
            // 
            this.cob_appo_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_appo_patient.FormattingEnabled = true;
            this.cob_appo_patient.Location = new System.Drawing.Point(9, 149);
            this.cob_appo_patient.Name = "cob_appo_patient";
            this.cob_appo_patient.Size = new System.Drawing.Size(329, 33);
            this.cob_appo_patient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Patient";
            // 
            // txt_appo_symptoms
            // 
            this.txt_appo_symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appo_symptoms.Location = new System.Drawing.Point(730, 78);
            this.txt_appo_symptoms.Multiline = true;
            this.txt_appo_symptoms.Name = "txt_appo_symptoms";
            this.txt_appo_symptoms.Size = new System.Drawing.Size(332, 174);
            this.txt_appo_symptoms.TabIndex = 7;
            this.txt_appo_symptoms.Text = "Test Address Gampola";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(725, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 58;
            this.label9.Text = "Symptoms";
            // 
            // cob_appo_specialy_area
            // 
            this.cob_appo_specialy_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_appo_specialy_area.FormattingEnabled = true;
            this.cob_appo_specialy_area.Location = new System.Drawing.Point(370, 147);
            this.cob_appo_specialy_area.Name = "cob_appo_specialy_area";
            this.cob_appo_specialy_area.Size = new System.Drawing.Size(329, 33);
            this.cob_appo_specialy_area.TabIndex = 5;
            this.cob_appo_specialy_area.SelectedIndexChanged += new System.EventHandler(this.cob_appo_specialy_area_SelectedIndexChanged);
            // 
            // btn_ur_save
            // 
            this.btn_ur_save.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ur_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ur_save.FlatAppearance.BorderSize = 0;
            this.btn_ur_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ur_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ur_save.ForeColor = System.Drawing.Color.White;
            this.btn_ur_save.Location = new System.Drawing.Point(856, 273);
            this.btn_ur_save.Name = "btn_ur_save";
            this.btn_ur_save.Size = new System.Drawing.Size(206, 34);
            this.btn_ur_save.TabIndex = 61;
            this.btn_ur_save.Text = "Save";
            this.btn_ur_save.UseVisualStyleBackColor = false;
            this.btn_ur_save.Click += new System.EventHandler(this.btn_ur_save_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(364, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 25);
            this.label14.TabIndex = 52;
            this.label14.Text = "Specialty Area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(4, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "Appointment Number";
            // 
            // txt_appo_number
            // 
            this.txt_appo_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appo_number.Location = new System.Drawing.Point(9, 78);
            this.txt_appo_number.Name = "txt_appo_number";
            this.txt_appo_number.Size = new System.Drawing.Size(325, 30);
            this.txt_appo_number.TabIndex = 0;
            // 
            // dt_appointment
            // 
            this.dt_appointment.AllowUserToAddRows = false;
            this.dt_appointment.AllowUserToDeleteRows = false;
            this.dt_appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_appointment.Location = new System.Drawing.Point(8, 428);
            this.dt_appointment.Name = "dt_appointment";
            this.dt_appointment.ReadOnly = true;
            this.dt_appointment.RowHeadersWidth = 51;
            this.dt_appointment.RowTemplate.Height = 24;
            this.dt_appointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_appointment.Size = new System.Drawing.Size(1078, 372);
            this.dt_appointment.TabIndex = 77;
            this.dt_appointment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_appointment_CellDoubleClick);
            // 
            // btn_u_search
            // 
            this.btn_u_search.Location = new System.Drawing.Point(717, 367);
            this.btn_u_search.Name = "btn_u_search";
            this.btn_u_search.Size = new System.Drawing.Size(179, 37);
            this.btn_u_search.TabIndex = 78;
            this.btn_u_search.Text = "Search";
            this.btn_u_search.UseVisualStyleBackColor = true;
            this.btn_u_search.Click += new System.EventHandler(this.btn_u_search_Click);
            // 
            // cob_search
            // 
            this.cob_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cob_search.FormattingEnabled = true;
            this.cob_search.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Completed"});
            this.cob_search.Location = new System.Drawing.Point(361, 369);
            this.cob_search.Name = "cob_search";
            this.cob_search.Size = new System.Drawing.Size(329, 33);
            this.cob_search.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(130, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Appointment Status";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(907, 367);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(179, 37);
            this.btn_refresh.TabIndex = 79;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Appointment_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 804);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cob_search);
            this.Controls.Add(this.btn_u_search);
            this.Controls.Add(this.dt_appointment);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Appointment_From";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPOINTMENT";
            this.Load += new System.EventHandler(this.Appointment_From_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_appo_symptoms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cob_appo_specialy_area;
        private System.Windows.Forms.Button btn_ur_save;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_appo_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dp_appo_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cob_appo_patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_appo_time;
        private System.Windows.Forms.ComboBox cob_appo_officer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt_appointment;
        private System.Windows.Forms.Button btn_u_search;
        private System.Windows.Forms.ComboBox cob_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_refresh;
    }
}