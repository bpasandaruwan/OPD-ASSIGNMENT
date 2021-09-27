
namespace OPD_ASSIGNMENT
{
    partial class Login_Form_Staff
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
            this.txt_l_password = new System.Windows.Forms.TextBox();
            this.txt_l_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.Btn_l_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_l_password
            // 
            this.txt_l_password.BackColor = System.Drawing.Color.White;
            this.txt_l_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_l_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_l_password.Location = new System.Drawing.Point(23, 316);
            this.txt_l_password.Name = "txt_l_password";
            this.txt_l_password.Size = new System.Drawing.Size(388, 36);
            this.txt_l_password.TabIndex = 4;
            this.txt_l_password.Text = "admin";
            this.txt_l_password.UseSystemPasswordChar = true;
            // 
            // txt_l_username
            // 
            this.txt_l_username.BackColor = System.Drawing.Color.White;
            this.txt_l_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_l_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l_username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_l_username.Location = new System.Drawing.Point(23, 240);
            this.txt_l_username.Name = "txt_l_username";
            this.txt_l_username.Size = new System.Drawing.Size(388, 36);
            this.txt_l_username.TabIndex = 3;
            this.txt_l_username.Text = "kavindu";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_password.Location = new System.Drawing.Point(18, 286);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 25);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_username.Location = new System.Drawing.Point(18, 211);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(98, 25);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Username";
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.White;
            this.pb_login.Image = global::OPD_ASSIGNMENT.Properties.Resources.hospital_w_01;
            this.pb_login.Location = new System.Drawing.Point(123, 1);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(188, 156);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_login.TabIndex = 7;
            this.pb_login.TabStop = false;
            // 
            // Btn_l_login
            // 
            this.Btn_l_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_l_login.Location = new System.Drawing.Point(162, 405);
            this.Btn_l_login.Name = "Btn_l_login";
            this.Btn_l_login.Size = new System.Drawing.Size(110, 49);
            this.Btn_l_login.TabIndex = 8;
            this.Btn_l_login.Text = "Login";
            this.Btn_l_login.UseVisualStyleBackColor = true;
            this.Btn_l_login.Click += new System.EventHandler(this.Btn_l_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(18, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Forgot Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(107, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "STAFF LOGIN";
            // 
            // Login_Form_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_l_login);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.txt_l_password);
            this.Controls.Add(this.txt_l_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_Form_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAFF LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_l_password;
        private System.Windows.Forms.TextBox txt_l_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Button Btn_l_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

