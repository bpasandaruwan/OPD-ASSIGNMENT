
namespace OPD_ASSIGNMENT
{
    partial class Welcome_Form
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
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.Btn_wel_patient_login = new System.Windows.Forms.Button();
            this.Btn_wel_staff_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.White;
            this.pb_login.Image = global::OPD_ASSIGNMENT.Properties.Resources.hospital_w_01;
            this.pb_login.Location = new System.Drawing.Point(142, 26);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(188, 156);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_login.TabIndex = 8;
            this.pb_login.TabStop = false;
            // 
            // Btn_wel_patient_login
            // 
            this.Btn_wel_patient_login.BackColor = System.Drawing.Color.White;
            this.Btn_wel_patient_login.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_wel_patient_login.FlatAppearance.BorderSize = 2;
            this.Btn_wel_patient_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_wel_patient_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_wel_patient_login.Location = new System.Drawing.Point(53, 281);
            this.Btn_wel_patient_login.Name = "Btn_wel_patient_login";
            this.Btn_wel_patient_login.Size = new System.Drawing.Size(163, 49);
            this.Btn_wel_patient_login.TabIndex = 0;
            this.Btn_wel_patient_login.Text = "Patient Login";
            this.Btn_wel_patient_login.UseVisualStyleBackColor = false;
            this.Btn_wel_patient_login.Click += new System.EventHandler(this.Btn_wel_patient_login_Click);
            // 
            // Btn_wel_staff_login
            // 
            this.Btn_wel_staff_login.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_wel_staff_login.FlatAppearance.BorderSize = 2;
            this.Btn_wel_staff_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_wel_staff_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_wel_staff_login.Location = new System.Drawing.Point(256, 281);
            this.Btn_wel_staff_login.Name = "Btn_wel_staff_login";
            this.Btn_wel_staff_login.Size = new System.Drawing.Size(163, 49);
            this.Btn_wel_staff_login.TabIndex = 1;
            this.Btn_wel_staff_login.Text = "Staff Login";
            this.Btn_wel_staff_login.UseVisualStyleBackColor = true;
            this.Btn_wel_staff_login.Click += new System.EventHandler(this.Btn_wel_staff_login_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 444);
            this.Controls.Add(this.Btn_wel_staff_login);
            this.Controls.Add(this.Btn_wel_patient_login);
            this.Controls.Add(this.pb_login);
            this.Name = "Welcome_Form";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Button Btn_wel_patient_login;
        private System.Windows.Forms.Button Btn_wel_staff_login;
    }
}