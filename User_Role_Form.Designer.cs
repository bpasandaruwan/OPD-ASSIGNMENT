
namespace OPD_ASSIGNMENT
{
    partial class User_Role_Form
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
            this.btn_ur_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_userrole = new System.Windows.Forms.Label();
            this.txt_userrole = new System.Windows.Forms.TextBox();
            this.dt_user_role = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_user_role)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ur_save
            // 
            this.btn_ur_save.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ur_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ur_save.FlatAppearance.BorderSize = 0;
            this.btn_ur_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ur_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ur_save.ForeColor = System.Drawing.Color.White;
            this.btn_ur_save.Location = new System.Drawing.Point(529, 35);
            this.btn_ur_save.Name = "btn_ur_save";
            this.btn_ur_save.Size = new System.Drawing.Size(139, 34);
            this.btn_ur_save.TabIndex = 4;
            this.btn_ur_save.Text = "Save";
            this.btn_ur_save.UseVisualStyleBackColor = false;
            this.btn_ur_save.Click += new System.EventHandler(this.btn_ur_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_userrole);
            this.groupBox1.Controls.Add(this.lbl_userrole);
            this.groupBox1.Controls.Add(this.btn_ur_save);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATE NEW USER ROLE";
            // 
            // lbl_userrole
            // 
            this.lbl_userrole.AutoSize = true;
            this.lbl_userrole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_userrole.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_userrole.Location = new System.Drawing.Point(6, 40);
            this.lbl_userrole.Name = "lbl_userrole";
            this.lbl_userrole.Size = new System.Drawing.Size(106, 25);
            this.lbl_userrole.TabIndex = 7;
            this.lbl_userrole.Text = "Role Name";
            // 
            // txt_userrole
            // 
            this.txt_userrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userrole.Location = new System.Drawing.Point(129, 37);
            this.txt_userrole.Name = "txt_userrole";
            this.txt_userrole.Size = new System.Drawing.Size(369, 30);
            this.txt_userrole.TabIndex = 6;
            // 
            // dt_user_role
            // 
            this.dt_user_role.AllowUserToAddRows = false;
            this.dt_user_role.AllowUserToDeleteRows = false;
            this.dt_user_role.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_user_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_user_role.Location = new System.Drawing.Point(12, 122);
            this.dt_user_role.Name = "dt_user_role";
            this.dt_user_role.ReadOnly = true;
            this.dt_user_role.RowHeadersWidth = 51;
            this.dt_user_role.RowTemplate.Height = 24;
            this.dt_user_role.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_user_role.Size = new System.Drawing.Size(676, 416);
            this.dt_user_role.TabIndex = 6;
            this.dt_user_role.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_user_role_CellDoubleClick);
            // 
            // User_Role_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 550);
            this.Controls.Add(this.dt_user_role);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "User_Role_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER ROLE";
            this.Load += new System.EventHandler(this.User_Role_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_user_role)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ur_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_userrole;
        private System.Windows.Forms.TextBox txt_userrole;
        private System.Windows.Forms.DataGridView dt_user_role;
    }
}