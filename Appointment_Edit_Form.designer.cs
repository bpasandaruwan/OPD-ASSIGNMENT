
namespace OPD_ASSIGNMENT
{
    partial class Appointment_Edit_Form
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
            this.btn_ur_update = new System.Windows.Forms.Button();
            this.cobStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_appo_number = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnPDF);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btn_ur_update);
            this.groupBox1.Controls.Add(this.cobStatus);
            this.groupBox1.Controls.Add(this.label3);
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
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_appo_number);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 318);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE NEW APPOINTMENT";
            // 
            // btn_ur_update
            // 
            this.btn_ur_update.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ur_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ur_update.FlatAppearance.BorderSize = 0;
            this.btn_ur_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ur_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ur_update.ForeColor = System.Drawing.Color.White;
            this.btn_ur_update.Location = new System.Drawing.Point(924, 275);
            this.btn_ur_update.Name = "btn_ur_update";
            this.btn_ur_update.Size = new System.Drawing.Size(139, 34);
            this.btn_ur_update.TabIndex = 79;
            this.btn_ur_update.Text = "Update";
            this.btn_ur_update.UseVisualStyleBackColor = false;
            this.btn_ur_update.Click += new System.EventHandler(this.btn_ur_update_Click);
            // 
            // cobStatus
            // 
            this.cobStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobStatus.FormattingEnabled = true;
            this.cobStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Completed"});
            this.cobStatus.Location = new System.Drawing.Point(730, 75);
            this.cobStatus.Name = "cobStatus";
            this.cobStatus.Size = new System.Drawing.Size(329, 33);
            this.cobStatus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(724, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Status";
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
            this.txt_appo_symptoms.Location = new System.Drawing.Point(730, 149);
            this.txt_appo_symptoms.Multiline = true;
            this.txt_appo_symptoms.Name = "txt_appo_symptoms";
            this.txt_appo_symptoms.Size = new System.Drawing.Size(332, 103);
            this.txt_appo_symptoms.TabIndex = 8;
            this.txt_appo_symptoms.Text = "Test Address Gampola";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(725, 118);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(770, 275);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 34);
            this.btnPrint.TabIndex = 80;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPDF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(615, 275);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(139, 34);
            this.btnPDF.TabIndex = 81;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // Appointment_Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 341);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Appointment_Edit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment_Edit_Form";
            this.Load += new System.EventHandler(this.Appointment_Edit_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_appo_officer;
        private System.Windows.Forms.DateTimePicker txt_appo_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dp_appo_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cob_appo_patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_appo_symptoms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cob_appo_specialy_area;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_appo_number;
        private System.Windows.Forms.ComboBox cobStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ur_update;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPDF;
    }
}